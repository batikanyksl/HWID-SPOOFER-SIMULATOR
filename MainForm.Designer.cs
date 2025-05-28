namespace HWIDSpooferProject
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblBiosSerial;
        private System.Windows.Forms.Label lblDiskID;
        private System.Windows.Forms.Label lblCPUID;
        private System.Windows.Forms.Label lblSpoofBIOS;
        private System.Windows.Forms.Label lblSpoofDisk;
        private System.Windows.Forms.Label lblSpoofCPU;
        private System.Windows.Forms.Button btnSpoof;

        private void InitializeComponent()
        {
            lblBiosSerial = new System.Windows.Forms.Label();
            lblDiskID = new System.Windows.Forms.Label();
            lblCPUID = new System.Windows.Forms.Label();
            lblSpoofBIOS = new System.Windows.Forms.Label();
            lblSpoofDisk = new System.Windows.Forms.Label();
            lblSpoofCPU = new System.Windows.Forms.Label();
            btnSpoof = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBiosSerial
            // 
            lblBiosSerial.AutoSize = true;
            lblBiosSerial.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            lblBiosSerial.Location = new System.Drawing.Point(26, 22);
            lblBiosSerial.Name = "lblBiosSerial";
            lblBiosSerial.Size = new System.Drawing.Size(66, 15);
            lblBiosSerial.TabIndex = 0;
            lblBiosSerial.Text = "BIOS Serial:";
            // 
            // lblDiskID
            // 
            lblDiskID.AutoSize = true;
            lblDiskID.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            lblDiskID.Location = new System.Drawing.Point(26, 45);
            lblDiskID.Name = "lblDiskID";
            lblDiskID.Size = new System.Drawing.Size(46, 15);
            lblDiskID.TabIndex = 1;
            lblDiskID.Text = "Disk ID:";
            // 
            // lblCPUID
            // 
            lblCPUID.AutoSize = true;
            lblCPUID.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            lblCPUID.Location = new System.Drawing.Point(26, 68);
            lblCPUID.Name = "lblCPUID";
            lblCPUID.Size = new System.Drawing.Size(47, 15);
            lblCPUID.TabIndex = 2;
            lblCPUID.Text = "CPU ID:";
            // 
            // lblSpoofBIOS
            // 
            lblSpoofBIOS.AutoSize = true;
            lblSpoofBIOS.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            lblSpoofBIOS.Location = new System.Drawing.Point(26, 100);
            lblSpoofBIOS.Name = "lblSpoofBIOS";
            lblSpoofBIOS.Size = new System.Drawing.Size(100, 15);
            lblSpoofBIOS.TabIndex = 3;
            lblSpoofBIOS.Text = "Spoof BIOS Serial:";
            // 
            // lblSpoofDisk
            // 
            lblSpoofDisk.AutoSize = true;
            lblSpoofDisk.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            lblSpoofDisk.Location = new System.Drawing.Point(26, 120);
            lblSpoofDisk.Name = "lblSpoofDisk";
            lblSpoofDisk.Size = new System.Drawing.Size(80, 15);
            lblSpoofDisk.TabIndex = 4;
            lblSpoofDisk.Text = "Spoof Disk ID:";
            // 
            // lblSpoofCPU
            // 
            lblSpoofCPU.AutoSize = true;
            lblSpoofCPU.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            lblSpoofCPU.Location = new System.Drawing.Point(26, 140);
            lblSpoofCPU.Name = "lblSpoofCPU";
            lblSpoofCPU.Size = new System.Drawing.Size(81, 15);
            lblSpoofCPU.TabIndex = 5;
            lblSpoofCPU.Text = "Spoof CPU ID:";
            // 
            // btnSpoof
            // 
            btnSpoof.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnSpoof.Location = new System.Drawing.Point(26, 170);
            btnSpoof.Name = "btnSpoof";
            btnSpoof.Size = new System.Drawing.Size(75, 23);
            btnSpoof.TabIndex = 6;
            btnSpoof.Text = "Spoof";
            btnSpoof.UseVisualStyleBackColor = false;
            btnSpoof.Click += btnSpoof_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new System.Drawing.Point(-6, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(313, 258);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(300, 220);
            Controls.Add(lblBiosSerial);
            Controls.Add(lblDiskID);
            Controls.Add(lblCPUID);
            Controls.Add(lblSpoofBIOS);
            Controls.Add(lblSpoofDisk);
            Controls.Add(lblSpoofCPU);
            Controls.Add(btnSpoof);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "HWID Reader";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
