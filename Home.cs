using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EmuArk_0._0._1
{
    public partial class Home : Form
    {
        private const string Path = "C:/Program Files (x86)/PCSX2/pcsx2.exe";

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Dolphin = @"C:\Program Files (x86)\EmuArk\0.0.6 - Alpha\Emulators\Dolphin-x64\Dolphin.exe";
            Process.Start(Dolphin);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ePSXe = @"C:\Program Files (x86)\EmuArk\0.0.6 - Alpha\Emulators\ePSXe\ePSXe.exe";
            Process.Start(ePSXe);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void borderlessButton1_Click(object sender, EventArgs e)
        {
            var newformhelppage = new Form2();
            newformhelppage.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string PCSX2 = @"C:\Program Files (x86)\PCSX2\pcsx2.exe";
            Process.Start(PCSX2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string proj64start  = @"C:\Program Files (x86)\Project64 2.3\Project64.exe";
            Process.Start(proj64start);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string nesstart = @"C:\Program Files (x86)\EmuArk\0.0.6 - Alpha\Emulators\Mesen_0.9.8\Mesen.exe";
            Process.Start(nesstart);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string PS3START = @"C:\Users\Euans Omen 15 Laptop\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\rpcs3-v0.0.11-10753-995cb812_win64\rpcs3.exe\";
            Process.Start(PS3START);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var newforminstallerpage = new InstallerPage();
            newforminstallerpage.Show();
        }
    }
}
