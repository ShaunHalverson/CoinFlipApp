using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlipGame
{
    public partial class CoinFlipGame : Form
    {
        int heads = 0;
        int tails = 0;

        public CoinFlipGame()
        {
            InitializeComponent();
        }

        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            Random coinFlip = new Random();
            int result = coinFlip.Next(1, 3);

            //The result is heads
            if(result == 1)
            {
                CoinImage.ImageLocation = @"C:\Users\Shaun\Videos\CoinFlip\Heads.png";
                CoinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                heads++;
                HeadsLabel.Text = "Heads: " + heads.ToString();
            }
            //The result is tails
            else
            {
                CoinImage.ImageLocation = @"C:\Users\Shaun\Videos\CoinFlip\Tails.png";
                CoinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                tails++;
                TailsLabel.Text = "Tails: " + tails.ToString();
            }
        }
    }
}
