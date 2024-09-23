using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Media;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;

namespace MultiCameraDemo
{
    /// <summary>
    /// The main form of Multi Camera Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// "Slave" viewers.
        /// </summary>
        WebcamViewer[] _slaveViewers;

        /// <summary>
        /// All webcam viewers.
        /// </summary>
        WebcamViewer[] _viewers;

        /// <summary>
        /// Save image dialog.
        /// </summary>
        SaveFileDialog _saveImageDialog;

        /// <summary>
        /// Available image capture devices monitor.
        /// </summary>
        ImageCaptureDevicesMonitor _captureDevicesMonitor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

            _slaveViewers = new WebcamViewer[]{
                webcamViewer1,
                webcamViewer2,
                webcamViewer3,
                webcamViewer4,
            };
            _viewers = new WebcamViewer[]{
                masterWebcamViewer,
                webcamViewer1,
                webcamViewer2,
                webcamViewer3,
                webcamViewer4,
            };

            // set timeout in milliseconds
            masterWebcamViewer.CaptureTimeout = 5;
            foreach (WebcamViewer viewer in _slaveViewers)
            {
                viewer.CaptureTimeout = 1000 / 25;
            }

            Text = string.Format("VintaSoft Multi Camera Demo v{0}", ImagingGlobalSettings.ProductVersion);

            _captureDevicesMonitor = new ImageCaptureDevicesMonitor();
            _captureDevicesMonitor.Timeout = 500;
            _captureDevicesMonitor.CaptureDevicesChanged += new EventHandler<ImageCaptureDevicesChangedEventArgs>(CaptureDevicesMonitor_CaptureDevicesChanged);
            _captureDevicesMonitor.Start();

            _saveImageDialog = new SaveFileDialog();
            CodecsFileFilters.SetSaveFileDialogFilter(_saveImageDialog, false, false);
        }

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Processes a command key.
        /// </summary>
        /// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />,
        /// passed by reference, that represents the window message to process.</param>
        /// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values
        /// that represents the key to process.</param>
        /// <returns>
        /// <b>true</b> if the character was processed by the control; otherwise, <b>false</b>.
        /// </returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.Control | Keys.Add))
            {
                RotateViewClockwise();
                return true;
            }

            if (keyData == (Keys.Shift | Keys.Control | Keys.Subtract))
            {
                RotateViewCounterClockwise();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion


        #region PRIVATE

        #region UI

        #region 'File' menu

        /// <summary>
        /// Handles the Click event of exitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Handles the Click event of rotateClockwiseToolStripMenuItem object.
        /// </summary>
        private void rotateClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateViewClockwise();
        }

        /// <summary>
        /// Handles the Click event of rotateCounterclockwiseToolStripMenuItem object.
        /// </summary>
        private void rotateCounterclockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateViewCounterClockwise();
        }

        #endregion


        #region 'Webcam' menu

        /// <summary>
        /// Handles the Click event of startAllToolStripMenuItem object.
        /// </summary>
        private void startAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // start image capturing from all cameras
            StartAll();
        }

        /// <summary>
        /// Handles the Click event of stopAllToolStripMenuItem object.
        /// </summary>
        private void stopAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // stop image capturing from all cameras
            StopAll();
        }

        /// <summary>
        /// Handles the Click event of masterViewerToolStripMenuItem object.
        /// </summary>
        private void masterViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // select a capture device in master viewer
            SelectCaptureDevice(masterWebcamViewer);
        }

        /// <summary>
        /// Handles the Click event of viewer1ToolStripMenuItem object.
        /// </summary>
        private void viewer1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // select a capture device in viewer1
            SelectCaptureDevice(webcamViewer1);
        }

        /// <summary>
        /// Handles the Click event of viewer2ToolStripMenuItem object.
        /// </summary>
        private void viewer2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // select a capture device in viewer2
            SelectCaptureDevice(webcamViewer2);
        }

        /// <summary>
        /// Handles the Click event of viewer3ToolStripMenuItem object.
        /// </summary>
        private void viewer3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // select a capture device in viewer3
            SelectCaptureDevice(webcamViewer3);
        }

        /// <summary>
        /// Handles the Click event of viewer4ToolStripMenuItem object.
        /// </summary>
        private void viewer4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // select a capture device in viewer4
            SelectCaptureDevice(webcamViewer4);
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of aboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        #region Main Form

        /// <summary>
        /// Handles the Shown event of MainForm object.
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            // get available capture devices
            ReadOnlyCollection<ImageCaptureDevice> devices = ImageCaptureDeviceConfiguration.GetCaptureDevices();
            int viewerIndex = 0;

            // add devices to slave webcam viewers
            foreach (ImageCaptureDevice device in devices)
            {
                _slaveViewers[viewerIndex].CaptureDevice = device;
                viewerIndex++;
                if (viewerIndex >= _slaveViewers.Length)
                    break;
            }
            masterWebcamViewer.CaptureDevice = webcamViewer1.CaptureDevice;
            StartAll();
        }

        /// <summary>
        /// Handles the FormClosing event of MainForm object.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAll();
        }

        #endregion


        #region Webcam Context menu

        /// <summary>
        /// Handles the Click event of selectDeviceToolStripMenuItem object.
        /// </summary>
        private void selectDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // select a capture device in current webcam viewer
            WebcamViewer viewer = (WebcamViewer)cameraViewerContextMenuStrip.SourceControl;
            SelectCaptureDevice(viewer);
        }

        /// <summary>
        /// Handles the Click event of captureAndSaveImageToolStripMenuItem object.
        /// </summary>
        private void captureAndSaveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebcamViewer viewer = (WebcamViewer)cameraViewerContextMenuStrip.SourceControl;
            // capture image
            VintasoftImage image = viewer.GetCapturedImage();
            if (image != null)
            {
                if (_saveImageDialog.ShowDialog() == DialogResult.OK)
                {
                    // save captured image to a file
                    image.Save(_saveImageDialog.FileName);
                }
                image.Dispose();
            }
        }

        /// <summary>
        /// Handles the Click event of startToolStripMenuItem object.
        /// </summary>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebcamViewer viewer = (WebcamViewer)cameraViewerContextMenuStrip.SourceControl;
            try
            {
                // start image capturing in current webcam viewer
                viewer.Start();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of stopToolStripMenuItem object.
        /// </summary>
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebcamViewer viewer = (WebcamViewer)cameraViewerContextMenuStrip.SourceControl;
            try
            {
                // stop image capturing in current webcam viewer
                viewer.Stop();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        #endregion


        #region WebcamViewer

        /// <summary>
        /// Handles the Click event of slaveWebcamViewer object.
        /// </summary>
        private void slaveWebcamViewer_Click(object sender, EventArgs e)
        {
            WebcamViewer viewer = (WebcamViewer)sender;
            if (viewer.CaptureDevice != null)
            {
                // set selected viewer capture device to master viewer
                masterWebcamViewer.CaptureDevice = viewer.CaptureDevice;
                try
                {
                    masterWebcamViewer.Start();
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }
        }

        /// <summary>
        /// Handles the DoubleClick event of webcamViewer object.
        /// </summary>
        private void webcamViewer_DoubleClick(object sender, EventArgs e)
        {
            // change capture device in webcam viewer
            SelectCaptureDevice((WebcamViewer)sender);
        }

        #endregion

        #endregion


        #region View Rotation

        /// <summary>
        /// Rotates the image in all webcam viewers by 90 degrees clockwise.
        /// </summary>
        private void RotateViewClockwise()
        {
            masterWebcamViewer.RotateViewClockwise();
            webcamViewer1.RotateViewClockwise();
            webcamViewer2.RotateViewClockwise();
            webcamViewer3.RotateViewClockwise();
            webcamViewer4.RotateViewClockwise();
        }

        /// <summary>
        /// Rotates the image in all webcam viewers by 90 degrees counterclockwise.
        /// </summary>
        private void RotateViewCounterClockwise()
        {
            masterWebcamViewer.RotateViewCounterClockwise();
            webcamViewer1.RotateViewCounterClockwise();
            webcamViewer2.RotateViewCounterClockwise();
            webcamViewer3.RotateViewCounterClockwise();
            webcamViewer4.RotateViewCounterClockwise();
        }

        #endregion


        /// <summary>
        /// Starts all webcam viewers.
        /// </summary>
        private void StartAll()
        {
            try
            {
                masterWebcamViewer.Start();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }

            foreach (WebcamViewer viewer in _slaveViewers)
            {
                try
                {
                    viewer.Start();
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }
        }

        /// <summary>
        /// Stops all webcam viewers.
        /// </summary>
        private void StopAll()
        {
            masterWebcamViewer.Stop();
            foreach (WebcamViewer viewer in _slaveViewers)
                viewer.Stop();
        }

        /// <summary>
        /// Starts image capturing in webcam viewers with specified capture device.
        /// </summary>
        /// <param name="device">The capture device.</param>
        private void Start(ImageCaptureDevice device)
        {
            if (masterWebcamViewer.CaptureDevice == device)
                masterWebcamViewer.Start();

            foreach (WebcamViewer viewer in _slaveViewers)
            {
                if (viewer.CaptureDevice == device)
                    viewer.Start();
            }
        }

        /// <summary>
        /// Stops image capturing in webcam viewers of the specified capture device.
        /// </summary>
        /// <param name="device">The capture device.</param>
        private void Stop(ImageCaptureDevice device)
        {
            if (masterWebcamViewer.CaptureDevice == device)
                masterWebcamViewer.Stop();

            foreach (WebcamViewer viewer in _slaveViewers)
            {
                if (viewer.CaptureDevice == device)
                    viewer.Stop();
            }
        }

        /// <summary>
        /// Selects image capture device in specified webcam viewer.
        /// </summary>
        /// <param name="viewer">The webcam viewer.</param>
        private void SelectCaptureDevice(WebcamViewer viewer)
        {
            try
            {
                WebcamSelectionForm webcamSelection = new WebcamSelectionForm();
                webcamSelection.SelectedWebcam = viewer.CaptureDevice;
                if (webcamSelection.ShowDialog() == DialogResult.OK)
                {
                    viewer.CaptureDevice = webcamSelection.SelectedWebcam;
                    if (webcamSelection.SelectedFormat != null &&
                        viewer.CaptureDevice.DesiredFormat != webcamSelection.SelectedFormat)
                    {
                        Stop(viewer.CaptureDevice);
                        viewer.CaptureDevice.DesiredFormat = webcamSelection.SelectedFormat;
                        Start(viewer.CaptureDevice);
                    }
                    else
                    {
                        viewer.Start();
                    }
                }
            }
            catch (Exception e)
            {
                DemosTools.ShowErrorMessage(e);
            }
        }

        /// <summary>
        /// Handler of the ImageCaptureDevicesMonitor.CapturedDevicesChanged event.
        /// </summary>
        private void CaptureDevicesMonitor_CaptureDevicesChanged(object sender, ImageCaptureDevicesChangedEventArgs e)
        {
            // remove deleted devices
            foreach (ImageCaptureDevice device in e.RemovedDevices)
                foreach (WebcamViewer viewer in _viewers)
                    if (viewer.CaptureDevice == device)
                        viewer.CaptureDevice = null;

            // add new devices
            foreach (ImageCaptureDevice device in e.AddedDevices)
            {
                bool added = false;
                foreach (WebcamViewer viewer in _slaveViewers)
                {
                    if (viewer.CaptureDevice == null)
                    {
                        viewer.CaptureDevice = device;
                        viewer.Start();
                        added = true;
                        break;
                    }
                }

                if (!added)
                    break;
            }
        }

        #endregion

        #endregion

    }
}
