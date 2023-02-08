using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace countdownBenLeberg
{
    public partial class Form1 : Form
    {       
        private int buttonState = 1;
        SoundPlayer player = new SoundPlayer(Properties.Resources.waveAudio);
        SoundPlayer beepboop = new SoundPlayer(Properties.Resources.beepboopAudio);
        SoundPlayer cymbol = new SoundPlayer(Properties.Resources.cymbolAudio);
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonGreen() {
            playButton.Text = "P  L  A  Y\nP  L  A  Y\nP  L  A  Y";
            playButton.ForeColor = Color.White;
            playButton.BackColor = Color.Green;
            beepboop.Play();
        }

        private void wait(int time) {
            Refresh();
            Thread.Sleep(time);
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            buttonState = 3;
        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            buttonState = 2;
            buttonGreen();
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            buttonState = 1;
        }
        //Hi Mr T! I was talking to some friends who took this course last semester about trying to make a button
        //which switches from black and green constantly, and they advised me to look at timers in the oneNote!
        //I know this is a little jenky but it allowed me to have something almost like a: while (1==1) loop :) 
        private void stateControlTimer_Tick(object sender, EventArgs e)
        {
            //if the mouse is not on the button
            if (buttonState == 1)
            {
                playButton.Text = "P L A Y";
                playButton.ForeColor = Color.Black;
                playButton.BackColor = Color.White;
            }
            //if the mouse is on the button
            if (buttonState == 2)
            {
                buttonGreen();
                wait(stateControlTimer.Interval / 2);
                playButton.BackColor = Color.Black;
            }
            //after the button is pressed
            if (buttonState == 3)
            {
                playButton.Enabled = false;
                playButton.Visible = false;
                countdownLabel.BackColor = Color.Black;
                BackColor = Color.Black;
                wait(1700);
                countdownLabel.ForeColor = Color.White;
                wait(500);
                countdownLabel.Text = ". .";
                wait(500);
                countdownLabel.Text = ".";
                wait(500);
                countdownLabel.Text = "";
                wait(3000);
                for (int x = 3; x > 0; x--) {
                    player.PlaySync();
                    countdownLabel.Text = x.ToString();
                    wait(1250);
                }
                wait(250);
                cymbol.Play();
                countdownLabel.Text = "G O";
                for (int x = 12; x < 75; x++)
                {
                    countdownLabel.ForeColor= Color.White;
                    //I also looked up how to set a font size! I just wanted you to know im not copying
                    //anyone-- I was just looking into a few extra things! thank you!
                    countdownLabel.Font = new Font("Castellar", x, FontStyle.Bold);
                    wait(5);
                    countdownLabel.ForeColor = Color.Black;
                    wait(5);
                }
                countdownLabel.ForeColor = Color.Black;
            }

        }
    }
}
