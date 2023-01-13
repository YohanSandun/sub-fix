namespace SubFix
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEditRules = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFix = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRules = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSource = new System.Windows.Forms.ToolStripMenuItem();
            this.lstInput = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.toopTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditRules
            // 
            this.btnEditRules.Location = new System.Drawing.Point(204, 206);
            this.btnEditRules.Name = "btnEditRules";
            this.btnEditRules.Size = new System.Drawing.Size(122, 38);
            this.btnEditRules.TabIndex = 0;
            this.btnEditRules.Text = "Edit Rules";
            this.btnEditRules.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 26);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 48);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open File(s)";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFix,
            this.mnuEdit,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuOpenFolder,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(174, 26);
            this.mnuOpen.Text = "Open File(s)";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuOpenFolder
            // 
            this.mnuOpenFolder.Name = "mnuOpenFolder";
            this.mnuOpenFolder.Size = new System.Drawing.Size(174, 26);
            this.mnuOpenFolder.Text = "Open Folder";
            this.mnuOpenFolder.Click += new System.EventHandler(this.mnuOpenFolder_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(174, 26);
            this.mnuSave.Text = "Save File(s)";
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(174, 26);
            this.mnuSaveAs.Text = "Save As";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(174, 26);
            this.mnuExit.Text = "Exit";
            // 
            // mnuFix
            // 
            this.mnuFix.Name = "mnuFix";
            this.mnuFix.Size = new System.Drawing.Size(84, 24);
            this.mnuFix.Text = "Fix File(s)";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditRules});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(49, 24);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuEditRules
            // 
            this.mnuEditRules.Name = "mnuEditRules";
            this.mnuEditRules.Size = new System.Drawing.Size(157, 26);
            this.mnuEditRules.Text = "Edit Rules";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuSource});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(55, 24);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(137, 26);
            this.mnuAbout.Text = "About";
            // 
            // mnuSource
            // 
            this.mnuSource.Name = "mnuSource";
            this.mnuSource.Size = new System.Drawing.Size(137, 26);
            this.mnuSource.Text = "Source";
            // 
            // lstInput
            // 
            this.lstInput.FormattingEnabled = true;
            this.lstInput.ItemHeight = 20;
            this.lstInput.Location = new System.Drawing.Point(16, 132);
            this.lstInput.Name = "lstInput";
            this.lstInput.Size = new System.Drawing.Size(157, 204);
            this.lstInput.TabIndex = 3;
            this.lstInput.SelectedIndexChanged += new System.EventHandler(this.lstInput_SelectedIndexChanged);
            this.lstInput.MouseHover += new System.EventHandler(this.lstInput_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstOutput);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEditRules);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.lstInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 355);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // btnFix
            // 
            this.btnFix.Enabled = false;
            this.btnFix.Location = new System.Drawing.Point(204, 26);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(122, 48);
            this.btnFix.TabIndex = 8;
            this.btnFix.Text = "Fix File(s)";
            this.btnFix.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output File(s)";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(356, 132);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(157, 204);
            this.lstOutput.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(356, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 48);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save File(s)";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input File(s)";
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "SRT Files (*.srt)|*.srt| All (*.*) |*.*";
            this.dlgOpen.Multiselect = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubFix - Sinhala Subtitle Corrector for Windows 11";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditRules;
        private Button btnOpen;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuSaveAs;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuEditRules;
        private ListBox lstInput;
        private GroupBox groupBox1;
        private Button btnFix;
        private Label label2;
        private ListBox lstOutput;
        private Button btnSave;
        private Label label1;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        private ToolStripMenuItem mnuSource;
        private ToolStripMenuItem mnuFix;
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
        private FolderBrowserDialog dlgFolder;
        private ToolStripMenuItem mnuOpenFolder;
        private ToolTip toopTip;
    }
}