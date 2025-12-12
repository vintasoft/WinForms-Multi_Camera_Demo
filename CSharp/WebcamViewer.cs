using System;
using System.ComponentModel;
using System.Threading;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Media;
using Vintasoft.Imaging.UI;

namespace MultiCameraDemo
{
    /// <summary>
    /// Image viewer that shows images captured from webcamera.
    /// </summary>
    public class WebcamViewer : ImageViewer
    {

        #region Fields

        /// <summary>
        /// Image capture source.
        /// </summary>
        ImageCaptureSource _imageCaptureSource;

        /// <summary>
        /// Indicates when image was painted.
        /// </summary>
        bool _imagePainted;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WebcamViewer"/> class.
        /// </summary>
        public WebcamViewer()
        {
            ShortcutDelete = System.Windows.Forms.Shortcut.None;
            ShortcutCut = System.Windows.Forms.Shortcut.None;
            ShortcutInsert = System.Windows.Forms.Shortcut.None;
        }

        #endregion



        #region Properties

        ImageCaptureDevice _captureDevice;
        /// <summary>
        /// Image capture device.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ImageCaptureDevice CaptureDevice
        {
            get
            {
                return _captureDevice;
            }
            set
            {
                if (_captureDevice != value)
                {
                    Stop();

                    if (_captureDevice != null)
                    {
                        _imageCaptureSource.CaptureCompleted -= new EventHandler<ImageCaptureCompletedEventArgs>(CaptureSource_CaptureCompleted);
                    }
                    _captureDevice = value;

                    if (_captureDevice != null)
                    {
                        _imageCaptureSource = new ImageCaptureSource();
                        _imageCaptureSource.CaptureCompleted += new EventHandler<ImageCaptureCompletedEventArgs>(CaptureSource_CaptureCompleted);
                        _imageCaptureSource.CaptureDevice = _captureDevice;
                    }
                    else
                    {
                        this.Image = null;
                    }
                }
            }
        }

        int _captureTimeout = 0;
        /// <summary>
        /// Image capture timeout.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CaptureTimeout
        {
            get
            {
                return _captureTimeout;
            }
            set
            {
                _captureTimeout = value;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Starts image capturing.
        /// </summary>
        public void Start()
        {
            if (_imageCaptureSource != null && _imageCaptureSource.State != ImageCaptureState.Started)
            {
                _imagePainted = true;
                _imageCaptureSource.Start();
                _imageCaptureSource.CaptureAsync();
            }
        }

        /// <summary>
        /// Stops image capturing.
        /// </summary>
        public void Stop()
        {
            if (_imageCaptureSource != null)
            {
                _imageCaptureSource.Stop();
            }
        }

        /// <summary>
        /// Gets a captured image.
        /// </summary>
        public VintasoftImage GetCapturedImage()
        {
            while (Image != null)
            {
                VintasoftImage image = Image;
                if (image == null)
                    return null;

                lock (image)
                {
                    if (!image.IsDisposed)
                        return (VintasoftImage)image.Clone();
                }
            }
            return null;
        }

        /// <summary>
        /// Raises the <see cref="E:Vintasoft.Imaging.UI.ImageViewer.ImagePainted" /> event.
        /// </summary>
        /// <param name="sender">Painted image.</param>
        /// <param name="e">An <see cref="T:Vintasoft.Imaging.ImageLoadedEventArgs" /> that contains
        /// the event data.</param>
        protected override void OnImagePainted(object sender, ImageLoadedEventArgs e)
        {
            _imagePainted = true;
            base.OnImagePainted(sender, e);
        }

        /// <summary>
        /// Image is captured.
        /// </summary>
        private void CaptureSource_CaptureCompleted(object sender, ImageCaptureCompletedEventArgs e)
        {
            if (_imageCaptureSource.State == ImageCaptureState.Stopped)
                return;

            // if previous image was painted
            if (Image == null || _imagePainted)
            {
                _imagePainted = false;
                // show captured image in the preview viewer
                if (Image != null)
                    Image.SetImage(e.GetCapturedImage());
                else
                    Image = e.GetCapturedImage();
            }
            
            // if capture source is started
            if (_imageCaptureSource.State == ImageCaptureState.Started)
            {
                // sleep...
                if (_captureTimeout > 0)
                    Thread.Sleep(_captureTimeout);
                // if capture source is started
                if (_imageCaptureSource.State == ImageCaptureState.Started)
                    // initialize new image capture request
                    _imageCaptureSource.CaptureAsync();
            }
        }

        #endregion

    }
}
