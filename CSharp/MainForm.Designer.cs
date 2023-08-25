namespace MultiCameraDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

         #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewer3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewer4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.webcamViewer1 = new MultiCameraDemo.WebcamViewer();
            this.cameraViewerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureAndSaveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.webcamViewer2 = new MultiCameraDemo.WebcamViewer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.webcamViewer3 = new MultiCameraDemo.WebcamViewer();
            this.webcamViewer4 = new MultiCameraDemo.WebcamViewer();
            this.masterWebcamViewer = new MultiCameraDemo.WebcamViewer();
            this.rotateClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCounterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.cameraViewerContextMenuStrip.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.cameraToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // rotateViewToolStripMenuItem
            // 
            this.rotateViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateClockwiseToolStripMenuItem,
            this.rotateCounterclockwiseToolStripMenuItem});
            this.rotateViewToolStripMenuItem.Name = "rotateViewToolStripMenuItem";
            this.rotateViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotateViewToolStripMenuItem.Text = "Rotate View";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAllToolStripMenuItem,
            this.stopAllToolStripMenuItem,
            this.captureDeviceToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // startAllToolStripMenuItem
            // 
            this.startAllToolStripMenuItem.Name = "startAllToolStripMenuItem";
            this.startAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.startAllToolStripMenuItem.Text = "Start All";
            this.startAllToolStripMenuItem.Click += new System.EventHandler(this.startAllToolStripMenuItem_Click);
            // 
            // stopAllToolStripMenuItem
            // 
            this.stopAllToolStripMenuItem.Name = "stopAllToolStripMenuItem";
            this.stopAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.stopAllToolStripMenuItem.Text = "Stop All";
            this.stopAllToolStripMenuItem.Click += new System.EventHandler(this.stopAllToolStripMenuItem_Click);
            // 
            // captureDeviceToolStripMenuItem
            // 
            this.captureDeviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterViewerToolStripMenuItem,
            this.viewer1ToolStripMenuItem,
            this.viewer2ToolStripMenuItem,
            this.viewer3ToolStripMenuItem,
            this.viewer4ToolStripMenuItem});
            this.captureDeviceToolStripMenuItem.Name = "captureDeviceToolStripMenuItem";
            this.captureDeviceToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.captureDeviceToolStripMenuItem.Text = "Capture Device";
            // 
            // masterViewerToolStripMenuItem
            // 
            this.masterViewerToolStripMenuItem.Name = "masterViewerToolStripMenuItem";
            this.masterViewerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.masterViewerToolStripMenuItem.Text = "Master Viewer...";
            this.masterViewerToolStripMenuItem.Click += new System.EventHandler(this.masterViewerToolStripMenuItem_Click);
            // 
            // viewer1ToolStripMenuItem
            // 
            this.viewer1ToolStripMenuItem.Name = "viewer1ToolStripMenuItem";
            this.viewer1ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewer1ToolStripMenuItem.Text = "Viewer1...";
            this.viewer1ToolStripMenuItem.Click += new System.EventHandler(this.viewer1ToolStripMenuItem_Click);
            // 
            // viewer2ToolStripMenuItem
            // 
            this.viewer2ToolStripMenuItem.Name = "viewer2ToolStripMenuItem";
            this.viewer2ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewer2ToolStripMenuItem.Text = "Viewer2...";
            this.viewer2ToolStripMenuItem.Click += new System.EventHandler(this.viewer2ToolStripMenuItem_Click);
            // 
            // viewer3ToolStripMenuItem
            // 
            this.viewer3ToolStripMenuItem.Name = "viewer3ToolStripMenuItem";
            this.viewer3ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewer3ToolStripMenuItem.Text = "Viewer3...";
            this.viewer3ToolStripMenuItem.Click += new System.EventHandler(this.viewer3ToolStripMenuItem_Click);
            // 
            // viewer4ToolStripMenuItem
            // 
            this.viewer4ToolStripMenuItem.Name = "viewer4ToolStripMenuItem";
            this.viewer4ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewer4ToolStripMenuItem.Text = "Viewer4...";
            this.viewer4ToolStripMenuItem.Click += new System.EventHandler(this.viewer4ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(784, 638);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.masterWebcamViewer);
            this.splitContainer1.Size = new System.Drawing.Size(778, 632);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.webcamViewer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(778, 144);
            this.splitContainer2.SplitterDistance = 192;
            this.splitContainer2.TabIndex = 0;
            // 
            // webcamViewer1
            // 
            this.webcamViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webcamViewer1.CaptureDevice = null;
            this.webcamViewer1.CaptureTimeout = 0;
            this.webcamViewer1.ContextMenuStrip = this.cameraViewerContextMenuStrip;
            this.webcamViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webcamViewer1.ImageRotationAngle = 0;
            this.webcamViewer1.Location = new System.Drawing.Point(0, 0);
            this.webcamViewer1.Name = "webcamViewer1";
            this.webcamViewer1.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.webcamViewer1.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.webcamViewer1.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.webcamViewer1.Size = new System.Drawing.Size(192, 144);
            this.webcamViewer1.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.webcamViewer1.TabIndex = 1;
            this.webcamViewer1.Text = "webcamViewer2";
            this.webcamViewer1.Click += new System.EventHandler(this.slaveWebcamViewer_Click);
            this.webcamViewer1.DoubleClick += new System.EventHandler(this.webcamViewer_DoubleClick);
            // 
            // cameraViewerContextMenuStrip
            // 
            this.cameraViewerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDeviceToolStripMenuItem,
            this.captureAndSaveImageToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.cameraViewerContextMenuStrip.Name = "webacmViewerContextMenuStrip";
            this.cameraViewerContextMenuStrip.Size = new System.Drawing.Size(212, 92);
            // 
            // selectDeviceToolStripMenuItem
            // 
            this.selectDeviceToolStripMenuItem.Name = "selectDeviceToolStripMenuItem";
            this.selectDeviceToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.selectDeviceToolStripMenuItem.Text = "Select Device...";
            this.selectDeviceToolStripMenuItem.Click += new System.EventHandler(this.selectDeviceToolStripMenuItem_Click);
            // 
            // captureAndSaveImageToolStripMenuItem
            // 
            this.captureAndSaveImageToolStripMenuItem.Name = "captureAndSaveImageToolStripMenuItem";
            this.captureAndSaveImageToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.captureAndSaveImageToolStripMenuItem.Text = "Capture and Save Image...";
            this.captureAndSaveImageToolStripMenuItem.Click += new System.EventHandler(this.captureAndSaveImageToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.webcamViewer2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(582, 144);
            this.splitContainer3.SplitterDistance = 191;
            this.splitContainer3.TabIndex = 0;
            // 
            // webcamViewer2
            // 
            this.webcamViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webcamViewer2.CaptureDevice = null;
            this.webcamViewer2.CaptureTimeout = 0;
            this.webcamViewer2.ContextMenuStrip = this.cameraViewerContextMenuStrip;
            this.webcamViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webcamViewer2.ImageRotationAngle = 0;
            this.webcamViewer2.Location = new System.Drawing.Point(0, 0);
            this.webcamViewer2.Name = "webcamViewer2";
            this.webcamViewer2.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.webcamViewer2.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.webcamViewer2.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.webcamViewer2.Size = new System.Drawing.Size(191, 144);
            this.webcamViewer2.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.webcamViewer2.TabIndex = 1;
            this.webcamViewer2.Text = "webcamViewer3";
            this.webcamViewer2.Click += new System.EventHandler(this.slaveWebcamViewer_Click);
            this.webcamViewer2.DoubleClick += new System.EventHandler(this.webcamViewer_DoubleClick);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.webcamViewer3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.webcamViewer4);
            this.splitContainer4.Size = new System.Drawing.Size(387, 144);
            this.splitContainer4.SplitterDistance = 191;
            this.splitContainer4.TabIndex = 0;
            // 
            // webcamViewer3
            // 
            this.webcamViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webcamViewer3.CaptureDevice = null;
            this.webcamViewer3.CaptureTimeout = 0;
            this.webcamViewer3.ContextMenuStrip = this.cameraViewerContextMenuStrip;
            this.webcamViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webcamViewer3.ImageRotationAngle = 0;
            this.webcamViewer3.Location = new System.Drawing.Point(0, 0);
            this.webcamViewer3.Name = "webcamViewer3";
            this.webcamViewer3.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.webcamViewer3.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.webcamViewer3.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.webcamViewer3.Size = new System.Drawing.Size(191, 144);
            this.webcamViewer3.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.webcamViewer3.TabIndex = 1;
            this.webcamViewer3.Text = "webcamViewer4";
            this.webcamViewer3.Click += new System.EventHandler(this.slaveWebcamViewer_Click);
            this.webcamViewer3.DoubleClick += new System.EventHandler(this.webcamViewer_DoubleClick);
            // 
            // webcamViewer4
            // 
            this.webcamViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webcamViewer4.CaptureDevice = null;
            this.webcamViewer4.CaptureTimeout = 0;
            this.webcamViewer4.ContextMenuStrip = this.cameraViewerContextMenuStrip;
            this.webcamViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webcamViewer4.ImageRotationAngle = 0;
            this.webcamViewer4.Location = new System.Drawing.Point(0, 0);
            this.webcamViewer4.Name = "webcamViewer4";
            this.webcamViewer4.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.webcamViewer4.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.webcamViewer4.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.webcamViewer4.Size = new System.Drawing.Size(192, 144);
            this.webcamViewer4.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.webcamViewer4.TabIndex = 1;
            this.webcamViewer4.Text = "webcamViewer5";
            this.webcamViewer4.Click += new System.EventHandler(this.slaveWebcamViewer_Click);
            this.webcamViewer4.DoubleClick += new System.EventHandler(this.webcamViewer_DoubleClick);
            // 
            // masterWebcamViewer
            // 
            this.masterWebcamViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masterWebcamViewer.CaptureDevice = null;
            this.masterWebcamViewer.CaptureTimeout = 0;
            this.masterWebcamViewer.ContextMenuStrip = this.cameraViewerContextMenuStrip;
            this.masterWebcamViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterWebcamViewer.ImageRotationAngle = 0;
            this.masterWebcamViewer.Location = new System.Drawing.Point(0, 0);
            this.masterWebcamViewer.Name = "masterWebcamViewer";
            this.masterWebcamViewer.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.masterWebcamViewer.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.masterWebcamViewer.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.masterWebcamViewer.Size = new System.Drawing.Size(778, 484);
            this.masterWebcamViewer.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.masterWebcamViewer.TabIndex = 0;
            this.masterWebcamViewer.Text = "webcamViewer1";
            this.masterWebcamViewer.DoubleClick += new System.EventHandler(this.webcamViewer_DoubleClick);
            // 
            // rotateClockwiseToolStripMenuItem
            // 
            this.rotateClockwiseToolStripMenuItem.Name = "rotateClockwiseToolStripMenuItem";
            this.rotateClockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Ctrl+Plus";
            this.rotateClockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Oemplus)));
            this.rotateClockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.rotateClockwiseToolStripMenuItem.Text = "Clockwise";
            this.rotateClockwiseToolStripMenuItem.Click += new System.EventHandler(this.rotateClockwiseToolStripMenuItem_Click);
            // 
            // rotateCounterclockwiseToolStripMenuItem
            // 
            this.rotateCounterclockwiseToolStripMenuItem.Name = "rotateCounterclockwiseToolStripMenuItem";
            this.rotateCounterclockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Ctrl+Minus";
            this.rotateCounterclockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.OemMinus)));
            this.rotateCounterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.rotateCounterclockwiseToolStripMenuItem.Text = "Counterclockwise";
            this.rotateCounterclockwiseToolStripMenuItem.Click += new System.EventHandler(this.rotateCounterclockwiseToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.cameraViewerContextMenuStrip.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private WebcamViewer masterWebcamViewer;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private WebcamViewer webcamViewer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private WebcamViewer webcamViewer2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private WebcamViewer webcamViewer3;
        private WebcamViewer webcamViewer4;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewer1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewer2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewer3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewer4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cameraViewerContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureAndSaveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCounterclockwiseToolStripMenuItem;
    }
}
