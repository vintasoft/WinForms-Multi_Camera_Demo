using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

using Vintasoft.Imaging.Media;

namespace DemosCommonCode.Imaging
{
    /// <summary>
    /// A form that allows to select the webcam from webcam list.
    /// </summary>
    public partial class WebcamSelectionForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WebcamSelectionForm"/> class.
        /// </summary>
        public WebcamSelectionForm()
        {
            InitializeComponent();

            ReadOnlyCollection<ImageCaptureDevice> devices = ImageCaptureDeviceConfiguration.GetCaptureDevices();
            foreach (ImageCaptureDevice device in devices)
                devicesComboBox.Items.Add(device);

            if (devices.Count > 0)
                devicesComboBox.SelectedIndex = 0;
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets the selected webcam.
        /// </summary>
        public ImageCaptureDevice SelectedWebcam
        {
            get
            {
                return (ImageCaptureDevice)devicesComboBox.SelectedItem;
            }
            set
            {
                if (value != null)
                {
                    devicesComboBox.SelectedItem = value;
                }
            }
        }

        /// <summary>
        /// Gets the image capture selected format.
        /// </summary>
        public ImageCaptureFormat SelectedFormat
        {
            get
            {
                return (ImageCaptureFormat)videoFormatComboBox.SelectedItem;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether image capture format can be changed.
        /// </summary>
        /// <value>
        /// <b>True</b> if image capture format can be changed; otherwise, <b>false</b>.
        /// </value>
        public bool CanSelectFormat
        {
            get
            {
                return videoFormatLabel.Visible;
            }
            set
            {
                videoFormatLabel.Visible = value;
                videoFormatComboBox.Visible = value;
            }
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Shows the form for webcam selection.
        /// </summary>
        /// <returns>
        /// The selected webcam.
        /// </returns>
        public static ImageCaptureDevice SelectWebcam()
        {
            ReadOnlyCollection<ImageCaptureDevice> devices = ImageCaptureDeviceConfiguration.GetCaptureDevices();
            if (devices.Count == 0)
                throw new Exception("Webcam is not found.");
            if (devices.Count == 1)
                return devices[0];

            // create webcam selection dialog
            using (WebcamSelectionForm dialog = new WebcamSelectionForm())
            {
                // disable changing of the capturing image format
                dialog.CanSelectFormat = false;

                // if webcam is selected
                if (dialog.ShowDialog() == DialogResult.OK)
                    return dialog.SelectedWebcam;

                return null;
            }
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Handles the SelectedIndexChanged event of DevicesComboBox object.
        /// </summary>
        private void devicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear image formats
            videoFormatComboBox.Items.Clear();

            // if webcam is selected
            if (SelectedWebcam != null)
            {
                // list with image formats
                List<uint> imageCaptureFormatSizes = new List<uint>();
                // for each image format in webcam supported formats
                for (int i = 0; i < SelectedWebcam.SupportedFormats.Count; i++)
                {
                    // if format has bit depth less or equal than 12 bit
                    if (SelectedWebcam.SupportedFormats[i].BitsPerPixel <= 12)
                        // ignore formats with bit depth less or equal than 12 bit because they may cause issues on Windows 8
                        continue;

                    // get image capture format size
                    uint imageCaptureFormatSize = (uint)(SelectedWebcam.SupportedFormats[i].Width | (SelectedWebcam.SupportedFormats[i].Height << 16));
                    // if the format has not been added
                    if (!imageCaptureFormatSizes.Contains(imageCaptureFormatSize))
                    {
                        // add image format
                        imageCaptureFormatSizes.Add(imageCaptureFormatSize);
                        videoFormatComboBox.Items.Add(SelectedWebcam.SupportedFormats[i]);
                    }
                }

                // update selected webcam format
                if (SelectedWebcam.DesiredFormat != null && videoFormatComboBox.Items.Contains(SelectedWebcam.DesiredFormat))
                    videoFormatComboBox.SelectedItem = SelectedWebcam.DesiredFormat;
                else
                    videoFormatComboBox.SelectedIndex = -1;
            }
        }

        #endregion

        #endregion

    }
}
