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
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.toopTip = new System.Windows.Forms.ToolTip(this.components);
            this.pWelcome = new System.Windows.Forms.Panel();
            this.horizontalLine1 = new SubFix.HorizontalLine();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pInput = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pProgress = new System.Windows.Forms.Panel();
            this.horizontalLine5 = new SubFix.HorizontalLine();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.pOutput = new System.Windows.Forms.Panel();
            this.horizontalLine4 = new SubFix.HorizontalLine();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.rbChoose = new System.Windows.Forms.RadioButton();
            this.rbOverwrite = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pOptions = new System.Windows.Forms.Panel();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.lblInstallFont = new System.Windows.Forms.LinkLabel();
            this.rbIskoolaPota = new System.Windows.Forms.RadioButton();
            this.rbBindumathi = new System.Windows.Forms.RadioButton();
            this.horizontalLine3 = new SubFix.HorizontalLine();
            this.chkRemoveCopyright = new System.Windows.Forms.CheckBox();
            this.chkFix = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pInputFiles = new System.Windows.Forms.Panel();
            this.horizontalLine2 = new SubFix.HorizontalLine();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lstInput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pProgress.SuspendLayout();
            this.pOutput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.pOptions.SuspendLayout();
            this.grpFont.SuspendLayout();
            this.pInputFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "SRT Files (*.srt)|*.srt";
            this.dlgOpen.Multiselect = true;
            // 
            // pWelcome
            // 
            this.pWelcome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pWelcome.Controls.Add(this.horizontalLine1);
            this.pWelcome.Controls.Add(this.label4);
            this.pWelcome.Controls.Add(this.label3);
            this.pWelcome.Controls.Add(this.pictureBox1);
            this.pWelcome.Location = new System.Drawing.Point(0, 0);
            this.pWelcome.Name = "pWelcome";
            this.pWelcome.Size = new System.Drawing.Size(666, 435);
            this.pWelcome.TabIndex = 5;
            // 
            // horizontalLine1
            // 
            this.horizontalLine1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.horizontalLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine1.Location = new System.Drawing.Point(217, 433);
            this.horizontalLine1.Name = "horizontalLine1";
            this.horizontalLine1.Size = new System.Drawing.Size(449, 2);
            this.horizontalLine1.TabIndex = 6;
            this.horizontalLine1.Text = "horizontalLine1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(246, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 68);
            this.label4.TabIndex = 2;
            this.label4.Text = "SubFix is a tool which you can use to fix Sinhala Unicode problem for SRT subtitl" +
    "e files.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(246, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome to SubFix for Windows 11";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SubFix.Properties.Resources.cover1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(545, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(415, 450);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(315, 450);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pInput
            // 
            this.pInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pInput.Controls.Add(this.pictureBox2);
            this.pInput.Controls.Add(this.pProgress);
            this.pInput.Controls.Add(this.pOutput);
            this.pInput.Controls.Add(this.pOptions);
            this.pInput.Controls.Add(this.pInputFiles);
            this.pInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInput.Location = new System.Drawing.Point(0, 0);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(666, 435);
            this.pInput.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::SubFix.Properties.Resources.cover2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(666, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pProgress
            // 
            this.pProgress.Controls.Add(this.horizontalLine5);
            this.pProgress.Controls.Add(this.lstLog);
            this.pProgress.Controls.Add(this.pb);
            this.pProgress.Controls.Add(this.label6);
            this.pProgress.Location = new System.Drawing.Point(0, 90);
            this.pProgress.Name = "pProgress";
            this.pProgress.Size = new System.Drawing.Size(666, 345);
            this.pProgress.TabIndex = 10;
            this.pProgress.Visible = false;
            // 
            // horizontalLine5
            // 
            this.horizontalLine5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.horizontalLine5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine5.Location = new System.Drawing.Point(0, 343);
            this.horizontalLine5.Name = "horizontalLine5";
            this.horizontalLine5.Size = new System.Drawing.Size(666, 2);
            this.horizontalLine5.TabIndex = 3;
            this.horizontalLine5.Text = "horizontalLine5";
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 20;
            this.lstLog.Location = new System.Drawing.Point(23, 96);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(620, 224);
            this.lstLog.TabIndex = 2;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(23, 51);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(620, 29);
            this.pb.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hang on while we are fixing your subtitles...";
            // 
            // pOutput
            // 
            this.pOutput.Controls.Add(this.horizontalLine4);
            this.pOutput.Controls.Add(this.grpOutput);
            this.pOutput.Controls.Add(this.rbChoose);
            this.pOutput.Controls.Add(this.rbOverwrite);
            this.pOutput.Controls.Add(this.label5);
            this.pOutput.Location = new System.Drawing.Point(0, 90);
            this.pOutput.Name = "pOutput";
            this.pOutput.Size = new System.Drawing.Size(666, 345);
            this.pOutput.TabIndex = 11;
            // 
            // horizontalLine4
            // 
            this.horizontalLine4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.horizontalLine4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine4.Location = new System.Drawing.Point(0, 343);
            this.horizontalLine4.Name = "horizontalLine4";
            this.horizontalLine4.Size = new System.Drawing.Size(666, 2);
            this.horizontalLine4.TabIndex = 4;
            this.horizontalLine4.Text = "horizontalLine4";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.btnBrowse);
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Enabled = false;
            this.grpOutput.Location = new System.Drawing.Point(56, 160);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(547, 134);
            this.grpOutput.TabIndex = 3;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(428, 83);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(23, 44);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(499, 27);
            this.txtOutput.TabIndex = 0;
            // 
            // rbChoose
            // 
            this.rbChoose.AutoSize = true;
            this.rbChoose.Location = new System.Drawing.Point(56, 104);
            this.rbChoose.Name = "rbChoose";
            this.rbChoose.Size = new System.Drawing.Size(185, 24);
            this.rbChoose.TabIndex = 2;
            this.rbChoose.Text = "Choose output location";
            this.rbChoose.UseVisualStyleBackColor = true;
            // 
            // rbOverwrite
            // 
            this.rbOverwrite.AutoSize = true;
            this.rbOverwrite.Checked = true;
            this.rbOverwrite.Location = new System.Drawing.Point(56, 66);
            this.rbOverwrite.Name = "rbOverwrite";
            this.rbOverwrite.Size = new System.Drawing.Size(125, 24);
            this.rbOverwrite.TabIndex = 1;
            this.rbOverwrite.TabStop = true;
            this.rbOverwrite.Text = "Overwrite files";
            this.rbOverwrite.UseVisualStyleBackColor = true;
            this.rbOverwrite.CheckedChanged += new System.EventHandler(this.rbOverwrite_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Please choose a location to save output files.";
            // 
            // pOptions
            // 
            this.pOptions.Controls.Add(this.grpFont);
            this.pOptions.Controls.Add(this.horizontalLine3);
            this.pOptions.Controls.Add(this.chkRemoveCopyright);
            this.pOptions.Controls.Add(this.chkFix);
            this.pOptions.Controls.Add(this.label2);
            this.pOptions.Location = new System.Drawing.Point(0, 90);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(666, 345);
            this.pOptions.TabIndex = 10;
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.lblInstallFont);
            this.grpFont.Controls.Add(this.rbIskoolaPota);
            this.grpFont.Controls.Add(this.rbBindumathi);
            this.grpFont.Location = new System.Drawing.Point(79, 96);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(430, 102);
            this.grpFont.TabIndex = 6;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Font";
            // 
            // lblInstallFont
            // 
            this.lblInstallFont.AutoSize = true;
            this.lblInstallFont.Location = new System.Drawing.Point(128, 62);
            this.lblInstallFont.Name = "lblInstallFont";
            this.lblInstallFont.Size = new System.Drawing.Size(81, 20);
            this.lblInstallFont.TabIndex = 6;
            this.lblInstallFont.TabStop = true;
            this.lblInstallFont.Text = "Install Font";
            this.lblInstallFont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInstallFont_LinkClicked);
            // 
            // rbIskoolaPota
            // 
            this.rbIskoolaPota.AutoSize = true;
            this.rbIskoolaPota.Checked = true;
            this.rbIskoolaPota.Location = new System.Drawing.Point(25, 26);
            this.rbIskoolaPota.Name = "rbIskoolaPota";
            this.rbIskoolaPota.Size = new System.Drawing.Size(110, 24);
            this.rbIskoolaPota.TabIndex = 4;
            this.rbIskoolaPota.TabStop = true;
            this.rbIskoolaPota.Text = "Iskoola Pota";
            this.rbIskoolaPota.UseVisualStyleBackColor = true;
            // 
            // rbBindumathi
            // 
            this.rbBindumathi.AutoSize = true;
            this.rbBindumathi.Location = new System.Drawing.Point(25, 61);
            this.rbBindumathi.Name = "rbBindumathi";
            this.rbBindumathi.Size = new System.Drawing.Size(106, 24);
            this.rbBindumathi.TabIndex = 5;
            this.rbBindumathi.Text = "Bindumathi";
            this.rbBindumathi.UseVisualStyleBackColor = true;
            // 
            // horizontalLine3
            // 
            this.horizontalLine3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.horizontalLine3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine3.Location = new System.Drawing.Point(0, 343);
            this.horizontalLine3.Name = "horizontalLine3";
            this.horizontalLine3.Size = new System.Drawing.Size(666, 2);
            this.horizontalLine3.TabIndex = 3;
            this.horizontalLine3.Text = "horizontalLine3";
            // 
            // chkRemoveCopyright
            // 
            this.chkRemoveCopyright.AutoSize = true;
            this.chkRemoveCopyright.Location = new System.Drawing.Point(56, 207);
            this.chkRemoveCopyright.Name = "chkRemoveCopyright";
            this.chkRemoveCopyright.Size = new System.Drawing.Size(200, 24);
            this.chkRemoveCopyright.TabIndex = 2;
            this.chkRemoveCopyright.Text = "Remove copyright details";
            this.chkRemoveCopyright.UseVisualStyleBackColor = true;
            // 
            // chkFix
            // 
            this.chkFix.AutoSize = true;
            this.chkFix.Checked = true;
            this.chkFix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFix.Location = new System.Drawing.Point(56, 66);
            this.chkFix.Name = "chkFix";
            this.chkFix.Size = new System.Drawing.Size(158, 24);
            this.chkFix.TabIndex = 1;
            this.chkFix.Text = "Fix Sinhala unicode";
            this.chkFix.UseVisualStyleBackColor = true;
            this.chkFix.CheckedChanged += new System.EventHandler(this.chkFix_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please choose one or more options to continue.";
            // 
            // pInputFiles
            // 
            this.pInputFiles.Controls.Add(this.horizontalLine2);
            this.pInputFiles.Controls.Add(this.btnRemoveAll);
            this.pInputFiles.Controls.Add(this.btnAddFiles);
            this.pInputFiles.Controls.Add(this.btnAddFolder);
            this.pInputFiles.Controls.Add(this.lstInput);
            this.pInputFiles.Controls.Add(this.label1);
            this.pInputFiles.Location = new System.Drawing.Point(0, 90);
            this.pInputFiles.Name = "pInputFiles";
            this.pInputFiles.Size = new System.Drawing.Size(666, 345);
            this.pInputFiles.TabIndex = 1;
            // 
            // horizontalLine2
            // 
            this.horizontalLine2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.horizontalLine2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine2.Location = new System.Drawing.Point(0, 343);
            this.horizontalLine2.Name = "horizontalLine2";
            this.horizontalLine2.Size = new System.Drawing.Size(666, 2);
            this.horizontalLine2.TabIndex = 10;
            this.horizontalLine2.Text = "horizontalLine2";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(530, 286);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(109, 29);
            this.btnRemoveAll.TabIndex = 9;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(530, 232);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(109, 29);
            this.btnAddFiles.TabIndex = 8;
            this.btnAddFiles.Text = "Add Files";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(530, 193);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(109, 29);
            this.btnAddFolder.TabIndex = 7;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lstInput
            // 
            this.lstInput.FormattingEnabled = true;
            this.lstInput.ItemHeight = 20;
            this.lstInput.Location = new System.Drawing.Point(23, 51);
            this.lstInput.Name = "lstInput";
            this.lstInput.Size = new System.Drawing.Size(486, 264);
            this.lstInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Files";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(666, 498);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pInput);
            this.Controls.Add(this.pWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubFix - Sinhala Subtitle Corrector for Windows 11";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pWelcome.ResumeLayout(false);
            this.pWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pProgress.ResumeLayout(false);
            this.pProgress.PerformLayout();
            this.pOutput.ResumeLayout(false);
            this.pOutput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.pOptions.ResumeLayout(false);
            this.pOptions.PerformLayout();
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.pInputFiles.ResumeLayout(false);
            this.pInputFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
        private FolderBrowserDialog dlgFolder;
        private ToolTip toopTip;
        private Panel pWelcome;
        private HorizontalLine horizontalLine1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnCancel;
        private Button btnNext;
        private Button btnBack;
        private Panel pInput;
        private Panel pInputFiles;
        private PictureBox pictureBox2;
        private Button btnRemoveAll;
        private Button btnAddFiles;
        private Button btnAddFolder;
        private ListBox lstInput;
        private Label label1;
        private HorizontalLine horizontalLine2;
        private Panel pOptions;
        private CheckBox chkRemoveCopyright;
        private CheckBox chkFix;
        private Label label2;
        private HorizontalLine horizontalLine3;
        private Panel pOutput;
        private GroupBox grpOutput;
        private Button btnBrowse;
        private TextBox txtOutput;
        private RadioButton rbChoose;
        private RadioButton rbOverwrite;
        private Label label5;
        private HorizontalLine horizontalLine4;
        private Panel pProgress;
        private ListBox lstLog;
        private ProgressBar pb;
        private Label label6;
        private GroupBox grpFont;
        private LinkLabel lblInstallFont;
        private RadioButton rbIskoolaPota;
        private RadioButton rbBindumathi;
        private HorizontalLine horizontalLine5;
    }
}