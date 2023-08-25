using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace DemosCommonCode
{
    /// <summary>
    /// A base form for the application "About" dialog.
    /// </summary>
    public partial class AboutBoxBaseForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutBoxBaseForm"/> class.
        /// </summary>
        public AboutBoxBaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutBoxBaseForm"/> class.
        /// </summary>
        /// <param name="productPrefix">Product prefix.</param>
        public AboutBoxBaseForm(string productPrefix)
            : this()
        {
            nameLabel.Text = string.Format(nameLabel.Text, AssemblyTitle, AssemblyShortVersion);
            imagingSDKVersionLabel.Text = string.Format(imagingSDKVersionLabel.Text, ImagingSDKVersion);
            productLinkLabel.Text = string.Format(productLinkLabel.Text, productPrefix);
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the assembly title.
        /// </summary>
        [Browsable(false)]
        public string AssemblyTitle
        {
            get
            {

                object[] attributes = Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Gets the assembly version.
        /// </summary>
        [Browsable(false)]
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetEntryAssembly().GetName().Version.ToString();
            }
        }

        /// <summary>
        /// Gets the aseembly short version.
        /// </summary>
        [Browsable(false)]
        public string AssemblyShortVersion
        {
            get
            {
                Version ver = Assembly.GetEntryAssembly().GetName().Version;
                return string.Format("{0}.{1}", ver.Major, ver.Minor);
            }
        }

        /// <summary>
        /// Gets the version of VintaSoft Imaging .NET SDK.
        /// </summary>
        [Browsable(false)]
        public string ImagingSDKVersion
        {
            get
            {
                Assembly imagingAssembly = Assembly.GetAssembly(typeof(Vintasoft.Imaging.VintasoftImage));
                return imagingAssembly.GetName().Version.ToString();
            }
        }

        #endregion



        #region Methods

        #region UI

        /// <summary>
        /// Handles the Click event of OkButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            // close the form
            Close();
        }

        /// <summary>
        /// Handles the LinkClicked event of LinkLabel object.
        /// </summary>
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // open link in web browser
            DemosTools.OpenBrowser(((LinkLabel)sender).Text);
        }

        /// <summary>
        /// Handles the Click event of VintasoftLogoPictureBox object.
        /// </summary>
        private void vintasoftLogoPictureBox_Click(object sender, EventArgs e)
        {
            // open the VintaSoft web page in web browser
            DemosTools.OpenBrowser("https://www.vintasoft.com");
        }

        #endregion


        /// <summary>
        /// Updates the form title.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            Text = "About...";
            base.OnLoad(e);
        }

        #endregion

    }
}
