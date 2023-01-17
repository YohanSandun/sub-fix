﻿namespace SubFix
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
            this.pWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "SRT Files (*.srt)|*.srt| All (*.*) |*.*";
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
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(415, 450);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(315, 450);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pInput
            // 
            this.pInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInput.Location = new System.Drawing.Point(0, 0);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(666, 435);
            this.pInput.TabIndex = 9;
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
            this.Controls.Add(this.pWelcome);
            this.Controls.Add(this.pInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubFix - Sinhala Subtitle Corrector for Windows 11";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pWelcome.ResumeLayout(false);
            this.pWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}