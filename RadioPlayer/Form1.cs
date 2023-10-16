using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radio1Button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://a.files.bbci.co.uk/media/live/manifesto/audio/simulcast/hls/uk/sbr_high/ak/bbc_radio_one.m3u8";
        }

        private void radio2Button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://a.files.bbci.co.uk/media/live/manifesto/audio/simulcast/hls/uk/sbr_high/ak/bbc_radio_two.m3u8";
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            DialogResult file = openFileDialog1.ShowDialog();

            if (file == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void radio3Button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://a.files.bbci.co.uk/media/live/manifesto/audio/simulcast/hls/uk/sbr_high/ak/bbc_radio_three.m3u8";
        }

        private void radio4Button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://a.files.bbci.co.uk/media/live/manifesto/audio/simulcast/hls/uk/sbr_high/ak/bbc_radio_fourfm.m3u8";
        }

        private void radio5Button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://a.files.bbci.co.uk/media/live/manifesto/audio/simulcast/hls/uk/sbr_high/ak/bbc_radio_five_live.m3u8";
        }
    }
}
