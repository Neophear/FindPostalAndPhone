namespace FindPostalAndPhone
{
    partial class Form1
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
            this.btnFindFile = new System.Windows.Forms.Button();
            this.ofdExcelFile = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblOpenFile = new System.Windows.Forms.Label();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.tssLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.flpRunStop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.ssBottom.SuspendLayout();
            this.flpRunStop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindFile
            // 
            this.btnFindFile.Location = new System.Drawing.Point(13, 76);
            this.btnFindFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(112, 32);
            this.btnFindFile.TabIndex = 1;
            this.btnFindFile.Text = "Find fil";
            this.btnFindFile.UseVisualStyleBackColor = true;
            this.btnFindFile.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(79, 43);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(412, 26);
            this.txtFilePath.TabIndex = 3;
            // 
            // lblOpenFile
            // 
            this.lblOpenFile.AutoSize = true;
            this.lblOpenFile.Location = new System.Drawing.Point(13, 46);
            this.lblOpenFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpenFile.Name = "lblOpenFile";
            this.lblOpenFile.Size = new System.Drawing.Size(58, 20);
            this.lblOpenFile.TabIndex = 4;
            this.lblOpenFile.Text = "Excelfil";
            // 
            // ssBottom
            // 
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLeft,
            this.tssRight});
            this.ssBottom.Location = new System.Drawing.Point(0, 120);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Size = new System.Drawing.Size(504, 22);
            this.ssBottom.SizingGrip = false;
            this.ssBottom.TabIndex = 5;
            this.ssBottom.Text = "statusStrip1";
            // 
            // tssLeft
            // 
            this.tssLeft.Name = "tssLeft";
            this.tssLeft.Size = new System.Drawing.Size(380, 17);
            this.tssLeft.Spring = true;
            this.tssLeft.Text = "Klar";
            this.tssLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssRight
            // 
            this.tssRight.Name = "tssRight";
            this.tssRight.Size = new System.Drawing.Size(109, 17);
            this.tssRight.Text = "Made by Stiig Gade";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(122, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 32);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Kør";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(479, 20);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Adresserne skal starte med http eller https. De skal stå i kolonne 1.";
            // 
            // flpRunStop
            // 
            this.flpRunStop.Controls.Add(this.btnRun);
            this.flpRunStop.Controls.Add(this.btnStop);
            this.flpRunStop.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpRunStop.Location = new System.Drawing.Point(292, 76);
            this.flpRunStop.Name = "flpRunStop";
            this.flpRunStop.Size = new System.Drawing.Size(200, 41);
            this.flpRunStop.TabIndex = 8;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(41, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 32);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 142);
            this.Controls.Add(this.flpRunStop);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.ssBottom);
            this.Controls.Add(this.lblOpenFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnFindFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Find postnumre";
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.flpRunStop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFindFile;
        private System.Windows.Forms.OpenFileDialog ofdExcelFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblOpenFile;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.ToolStripStatusLabel tssRight;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStripStatusLabel tssLeft;
        private System.Windows.Forms.FlowLayoutPanel flpRunStop;
        private System.Windows.Forms.Button btnStop;
    }
}

