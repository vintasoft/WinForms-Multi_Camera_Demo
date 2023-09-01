using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.UI.VisualTools;
using Vintasoft.Imaging.UIActions;


namespace DemosCommonCode
{
    /// <summary>
    /// Contains collection of helper-algorithms for demo applications.
    /// </summary>
    public class DemosTools
    {

        #region Constructors

        /// <summary>
        /// Initializes the <see cref="DemosTools"/> class.
        /// </summary>
        public DemosTools()
        {
        }

        #endregion



        #region Methods

        /// <summary>
        /// Parses the float value.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        public static bool ParseFloat(string text, string fieldName, out float value)
        {
            if (ParseFloat(text, out value))
                return true;
            ShowErrorMessage(string.Format("{0} has invalid format.", fieldName));
            return false;
        }

        /// <summary>
        /// Parses the float value.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="value">The value.</param>
        public static bool ParseFloat(string text, out float value)
        {
            return float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
        }

        /// <summary>
        /// Convert float value to string.
        /// </summary>
        /// <param name="value">The value.</param>
        public static string ToString(float value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Convert float value to string.
        /// </summary>
        /// <param name="value">The value.</param>
        public static string ToString(float? value)
        {
            if (value.HasValue)
                return ToString(value.Value);
            return "";
        }


        /// <summary>
        /// Opens the web browser with specified URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        public static void OpenBrowser(string url)
        {
            ProcessStartInfo pi = new ProcessStartInfo("cmd", string.Format("/c start {0}", url));
            pi.CreateNoWindow = true;
            pi.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(pi);
        }

        /// <summary>
        /// Sets the enabled state of the specified menu item.
        /// </summary>
        public static void SetMenuEnabledState(ToolStripItem item, bool enabled)
        {
            ToolStripDropDownItem dropDownItem = item as ToolStripDropDownItem;
            if (dropDownItem != null && dropDownItem.DropDownItems.Count > 0)
            {
                for (int i = 0; i < dropDownItem.DropDownItems.Count; i++)
                    dropDownItem.DropDownItems[i].Enabled = enabled;
            }
            else
            {
                item.Enabled = enabled;
            }
        }


        /// <summary>
        /// Shows an error (exception) message.
        /// </summary>
        /// <param name="caption">MessageBox caption.</param>
        /// <param name="ex">The exception.</param>
        public static void ShowErrorMessage(string caption, Exception ex)
        {
            MessageBox.Show(GetFullExceptionMessage(ex), caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows an error (exception) message.
        /// </summary>
        /// <param name="caption">MessageBox caption.</param>
        /// <param name="message">The text of error.</param>
        public static void ShowErrorMessage(string caption, string message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows an error (exception) message.
        /// </summary>
        /// <param name="message">The text of error.</param>
        public static void ShowErrorMessage(string message)
        {
            ShowErrorMessage("Error", message);
        }

        /// <summary>
        /// Shows an error (exception) message.
        /// </summary>
        /// <param name="ex">The exception.</param>
        public static void ShowErrorMessage(Exception ex)
        {
            ShowErrorMessage("Error", ex);
        }

        /// <summary>
        /// Shows an error (exception) message.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <param name="filename">A filename.</param>
        public static void ShowErrorMessage(Exception ex, string filename)
        {
            MessageBox.Show(string.Format("{0} ({1})", ex.Message, Path.GetFileName(filename)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows a warning message.
        /// </summary>
        /// <param name="caption">MessageBox caption.</param>
        /// <param name="message">The message.</param>
        public static void ShowWarningMessage(string caption, string message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Shows a warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void ShowWarningMessage(string message)
        {
            ShowWarningMessage("Warning", message);
        }

        /// <summary>
        /// Shows an information message.
        /// </summary>
        /// <param name="caption">MessageBox caption.</param>
        /// <param name="message">The message.</param>
        public static void ShowInfoMessage(string caption, string message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows an information message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void ShowInfoMessage(string message)
        {
            ShowInfoMessage("Information", message);
        }


        /// <summary>
        /// Sets the folder with test files as initial folder for the file dialog.
        /// </summary>
        /// <param name="fileDialog">The file dialog.</param>
        public static void SetTestFilesFolder(FileDialog fileDialog)
        {
            string imagesFolder = FindTestFilesFolder();
            if (imagesFolder != "")
                fileDialog.InitialDirectory = imagesFolder;
            fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(fileDialog_FileOk);
        }

        /// <summary>
        /// Sets the folder with test XLSX files as initial folder for the file dialog.
        /// </summary>
        /// <param name="fileDialog">The file dialog.</param>
        public static void SetTestXlsxFolder(FileDialog fileDialog)
        {
            string imagesFolder = FindTestFilesFolder();
            if (imagesFolder != "")
                fileDialog.InitialDirectory = Path.Combine(imagesFolder, "Xlsx");
            fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(fileDialog_FileOk);
        }

        /// <summary>
        /// User is clicked on the Open or Save button on a file dialog box.
        /// </summary>
        private static void fileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileDialog dialog = ((FileDialog)sender);
            dialog.InitialDirectory = "";
            dialog.FileOk -= new System.ComponentModel.CancelEventHandler(fileDialog_FileOk);
        }

        /// <summary>
        /// Sets the folder with test files as initial folder for the folder browser dialog.
        /// </summary>
        /// <param name="folderBrowserDialog">The folder browser dialog.</param>
        public static void SetTestFilesFolder(FolderBrowserDialog folderBrowserDialog)
        {
            string imagesFolder = FindTestFilesFolder();
            if (imagesFolder != "")
                folderBrowserDialog.SelectedPath = imagesFolder;
        }

        /// <summary>
        /// Returns a full path to the folder with test files.
        /// </summary>
        /// <returns>
        /// Full path to the folder with test files if folder is found; otherwise, empty string.
        /// </returns>
        public static string FindTestFilesFolder()
        {
            try
            {
                // search folders
                string[] folders = new string[] {
                    @"..\..\..\TestFiles\",
                    @"..\..\..\..\TestFiles\",
                    @"..\..\..\..\..\TestFiles\",
                    @"..\..\..\..\..\..\..\TestFiles\"
                };
                string demoBinFolder = Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName);
                foreach (string dir in folders)
                {
                    string testFilesFolder = Path.Combine(demoBinFolder, dir);
                    if (Directory.Exists(testFilesFolder))
                        return Path.GetFullPath(testFilesFolder);
                }
            }
            catch
            {
            }

            return "";
        }

        /// <summary>
        /// Reloads the images in the specified image viewer.
        /// </summary>
        /// <param name="imageViewer">The image viewer.</param>
        public static void ReloadImagesInViewer(ImageViewerBase imageViewer)
        {
            try
            {
                ImageCollection images = imageViewer.Images;
                int focusedIndex = imageViewer.FocusedIndex;
                VintasoftImage focusedImage = null;
                if (focusedIndex >= 0 && focusedIndex < images.Count)
                {
                    focusedImage = images[focusedIndex];
                    if (focusedImage != null)
                        focusedImage.Reload(true);
                }

                foreach (VintasoftImage nextImage in imageViewer.Images)
                {
                    if (nextImage != focusedImage)
                        nextImage.Reload(true);
                }
            }
            catch (Exception e)
            {
                ShowErrorMessage(e);
            }
        }

        /// <summary>
        /// Returns the message of exception and inner exceptions.
        /// </summary>
        public static string GetFullExceptionMessage(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ex.Message);

            Exception innerException = ex.InnerException;
            while (innerException != null)
            {
                if (ex.Message != innerException.Message)
                    sb.AppendLine(string.Format("Inner exception: {0}", innerException.Message));
                innerException = innerException.InnerException;
            }

            return sb.ToString();
        }


        /// <summary>
        /// Catches the visual tool exceptions of the specified viewer.
        /// </summary>
        /// <param name="imageViewer">The image viewer.</param>
        public static void CatchVisualToolExceptions(ImageViewer imageViewer)
        {
            imageViewer.CatchVisualToolExceptions = true;
            imageViewer.VisualToolException += new EventHandler<ExceptionEventArgs>(imageViewer_VisualToolException);
        }

        /// <summary>
        /// Auto fit toolstrip buttons. 
        /// </summary>
        /// <param name="toolStrip">Toolstrip.</param>
        public static void AutoFitToolstripButtons(ToolStrip toolStrip)
        {
            // for each item in toolstrip
            foreach(ToolStripItem item in toolStrip.Items)
            {
                // if item is button
                if (item is ToolStripButton || item is ToolStripSplitButton)
                {
                    using (System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd(toolStrip.Handle))
                    {
                        // get size of button text
                        System.Drawing.SizeF textSize = g.MeasureString(item.Text, item.Font);
                        // button has dropdown button
                        if (item is ToolStripSplitButton)
                        {
                            // add dropdown button width to the width of button text
                            textSize.Width += ((ToolStripSplitButton)item).DropDownButtonWidth;
                        }
                        // if button width is less than width of button text
                        if (item.Width < textSize.Width)
                            // increase the button width
                            item.Width = (int)textSize.Width;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the VisualToolException event of the ImageViewer control.
        /// </summary>
        private static void imageViewer_VisualToolException(object sender, ExceptionEventArgs e)
        {
            ShowErrorMessage(e.Exception);
        }

        /// <summary>
        /// Returns the UI action of the visual tool.
        /// </summary>
        /// <param name="visualTool">Visual tool.</param>
        /// <returns>The UI action of the visual tool.</returns>
        public static T GetUIAction<T>(VisualTool visualTool)
            where T : UIAction
        {
            IList<UIAction> uiActions = null;
            // if visual tool has actions
            if (TryGetCurrentToolActions(visualTool, out uiActions))
            {
                // for each action in list
                foreach (UIAction uiAction in uiActions)
                {
                    if (uiAction is T)
                        return (T)uiAction;
                }
            }
            return default(T);
        }

        /// <summary>
        /// Returns the UI actions of visual tool.
        /// </summary>
        /// <param name="visualTool">The visual tool.</param>
        /// <param name="uiActions">The list of UI actions supported by the current visual tool.</param>
        /// <returns>
        /// <b>true</b> - UI actions are found; otherwise, <b>false</b>.
        /// </returns>
        public static bool TryGetCurrentToolActions(
            VisualTool visualTool,
            out IList<UIAction> uiActions)
        {
            uiActions = null;
            ISupportUIActions currentToolWithUIActions = visualTool as ISupportUIActions;
            if (currentToolWithUIActions != null)
                uiActions = currentToolWithUIActions.GetSupportedUIActions();

            return uiActions != null;
        }

        /// <summary>
        /// Returns the loading error string.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <returns>The loading error string.</returns>
        public static object GetShortLoadingErrorString(VintasoftImage image)
        {
            if (!image.LoadingError)
                return "";
            if (image.LoadingErrorString.Length <= 150)
                return image.LoadingErrorString;
            return image.LoadingErrorString.Substring(0, 150) + "...";
        }

        /// <summary>
        /// Enables the license exception displaying.
        /// </summary>
        public static void EnableLicenseExceptionDisplaying()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        /// <summary>
        /// Handles the UnhandledException event of the AppDomain.CurrentDomain.
        /// </summary>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            System.ComponentModel.LicenseException licenseException = GetLicenseException(e.ExceptionObject);
            if (licenseException != null)
            {
                // show information about licensing exception
                MessageBox.Show(string.Format("{0}: {1}", licenseException.GetType().Name, licenseException.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // open article with information about usage of evaluation license
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "https://www.vintasoft.com/docs/vsimaging-dotnet/Licensing-Evaluation.html";
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
        }

        /// <summary>
        /// Returns the license exception from specified exception.
        /// </summary>
        /// <param name="exceptionObject">The exception object.</param>
        /// <returns>Instance of <see cref="LicenseException"/>.</returns>
        private static LicenseException GetLicenseException(object exceptionObject)
        {
            Exception ex = exceptionObject as Exception;
            if (ex == null)
                return null;
            if (ex is LicenseException)
                return (LicenseException)exceptionObject;
            if (ex.InnerException != null)
                return GetLicenseException(ex.InnerException);
            return null;
        }

        #endregion

    }
}
