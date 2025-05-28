using System;
using System.IO;
using System.Media;
using System.Windows.Forms;


namespace HWIDSpooferProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PlayStartupMusic()
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "startup.wav");
                SoundPlayer player = new SoundPlayer(path);
                player.PlayLooping(); // Eğer tek sefer çalsın istiyorsan .Play() kullan
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müzik çalınamadı: " + ex.Message);
            }
        }




        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateHWIDLabels();
        }

        private void btnSpoof_Click(object sender, EventArgs e)
        {
            HWIDReader.SpoofHWID();
            UpdateHWIDLabels();
            UpdateSpoofLabels();
            PlayStartupMusic();
            UpdateHWIDLabels();
        }

        private void UpdateHWIDLabels()
        {
            lblBiosSerial.Text = "BIOS Serial: " + HWIDReader.GetBIOSSerial();
            lblDiskID.Text = "Disk ID: " + HWIDReader.GetDiskID();
            lblCPUID.Text = "CPU ID: " + HWIDReader.GetCPUID();
        }

        private void UpdateSpoofLabels()
        {
            lblSpoofBIOS.Text = "Spoof BIOS Serial: " + HWIDReader.SpoofedBIOS;
            lblSpoofDisk.Text = "Spoof Disk ID: " + HWIDReader.SpoofedDisk;
            lblSpoofCPU.Text = "Spoof CPU ID: " + HWIDReader.SpoofedCPU;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
