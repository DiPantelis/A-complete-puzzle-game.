using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{

    public partial class HowToPlay : Form

    {
        //Global variables declaration
        System.Media.SoundPlayer infoplayerbttns = new System.Media.SoundPlayer();
        WindowsMediaPlayer infoplayer = new WindowsMediaPlayer();
        public int musiconoff2, soundonoff2, difmode2;

        //Constructor method for when the info form is called from the MainMenu form.
        //Information such as the difficulty, sound and music settings are transfered to this form. 
        public HowToPlay(int a, int b, int c)
        {

            InitializeComponent();
            this.musiconoff2 = a;
            this.soundonoff2 = b;
            this.difmode2 = c;
        }

        //Action perfomed when the form is initially loaded.
        private void HowToPlay_Load(object sender, EventArgs e)
        {
            playmusic();
        }

        //Method that plays the info page soundtrack if the user's settings allow it.
        private void playmusic()
        {
            if (musiconoff2 == 1)
            {

                infoplayer.URL = "deabeSound.mp3";
                infoplayer.settings.setMode("Loop", true);
                infoplayer.settings.volume = 30;
                infoplayer.controls.play();

            }
        }

        //Action performed when the home button is pressed.
        private void homebttn2_Click(object sender, EventArgs e)
        {
            //Play the home button's sound.
            if (soundonoff2 == 1)
            {
                infoplayerbttns.SoundLocation = "menubSound.wav";  
                infoplayerbttns.Play();

            }
            //Hide this form, open a MainMenu form and transfer the difficulty, sound and music settings, to it.
            this.Hide();                                           
            infoplayer.controls.stop();
            MainMenu mn = new MainMenu(musiconoff2, soundonoff2, difmode2);
            mn.ShowDialog();
            this.Close();
            Environment.Exit(0);
        }

        //Action performed when the X button is pressed
        private void AskPermissionBeforeQuit3(object sender, FormClosingEventArgs e)
        {

            DialogResult YesOrNO = MessageBox.Show("Are You Sure you want to Quit?", "Exit the game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If the users chooses not exit close the Message box that poped on the screen.
            if (YesOrNO == DialogResult.No)
                e.Cancel = true;

            //If the users chooses to exit, close the application.
            if (YesOrNO == DialogResult.Yes)
                Environment.Exit(0);

        }

  

    }
}
