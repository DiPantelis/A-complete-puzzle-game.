using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{
    public partial class MainMenu : Form
    {
        //Global variables declaration
        System.Media.SoundPlayer menuplayerbttns = new System.Media.SoundPlayer();
        WindowsMediaPlayer menuplayer = new WindowsMediaPlayer();
        public int musiconoff, soundonoff, difmode;

        //Constructor method for when the MainMenu form is initially called from the main program.
        public MainMenu()
        {
            InitializeComponent();
            if (soundbttn.Checked == true)
            {
                soundonoff = 1;
            }
            if (easybttn.Checked == true)
            {
                difmode = 1;
            }
            else if (normalbttn.Checked == true)
            {
                difmode = 2;
            }
            else if (hardbttn.Checked == true)
            {
                difmode = 3;
            }
        }
       
        //Constructor method for when the MainMenu form is called from the GameBoard form.
        //Information such as the difficulty, sound and music settings are transfered to this form, from the GameBoard form that made the call. 
        public MainMenu(int a, int b, int c)
        {
            InitializeComponent();
            this.musiconoff = a;
            this.soundonoff = b;
            this.difmode = c;
            if (this.soundonoff == 1)
            {
                soundbttn.Checked = true;
            }
            else
                soundbttn.Checked = false;
            if (this.musiconoff == 1)
            {
                musicbttn.Checked = true;
            }
            else
                musicbttn.Checked = false;
            if (this.difmode == 1)
            {
                easybttn.Checked = true;
                normalbttn.Checked = false;
                hardbttn.Checked = false;
            }
            else if (this.difmode == 2 )
            {
                normalbttn.Checked = true;
                easybttn.Checked = false;
                hardbttn.Checked = false;
            }
            else if (this.difmode == 3)
            {
                hardbttn.Checked = true;
                normalbttn.Checked = false;
                easybttn.Checked = false;
                
            }

        }

        //Action perfomed when the form is initially loaded.
        private void Menu_Load(object sender, EventArgs e)
        {
       
            playmusic();
            
        }

        //Method that plays the info page soundtrack if the user's settings allow it.
        private void playmusic()
        {
            if (musicbttn.Checked == true)
            {
                musiconoff = 1;
                menuplayer.URL = "deabeSound.mp3";
                menuplayer.settings.setMode("Loop", true);
                menuplayer.settings.volume = 30;
                menuplayer.controls.play();

            }
        }

        //Action perfomed when the user presses the play button.
        private void playgameBttn_Click(object sender, EventArgs e)
        {
            if (soundbttn.Checked == true)
            {
                menuplayerbttns.SoundLocation = "menubSound.wav";
                menuplayerbttns.Play();

            }
            //Hide this form, open a GameBoard form and transfer the difficulty, sound and music settings, to it.
            this.Hide();
            menuplayer.controls.stop();
            PuzzleGame gb = new PuzzleGame(musiconoff,soundonoff,difmode);
            gb.ShowDialog();
           
            
        }

        //Action perfomed when the user presses the info button.
        private void infobttn_Click(object sender, EventArgs e)
        {
            if (soundbttn.Checked == true)
            {
                menuplayerbttns.SoundLocation = "menubSound.wav";
                menuplayerbttns.Play();

            }
            //Hide this form, open a HowToPlay(info) form and transfer the difficulty, sound and music settings, to it.
            this.Hide();
            menuplayer.controls.stop();
            HowToPlay info = new HowToPlay(musiconoff, soundonoff, difmode);
            info.ShowDialog();

        }

        //Action perfomed when the user presses the sound-settings checkbox.
        private void soundbttn_CheckedChanged(object sender, EventArgs e)
        {
            if (soundbttn.Checked == true)
            {
                menuplayerbttns.SoundLocation = "chebxSound.wav";
                menuplayerbttns.Play();
                soundonoff = 1;

            }
            if (soundbttn.Checked == false)
            {
                soundonoff = 0;

            }

        }

        //Action perfomed when the user presses the music-settings checkbox.
        private void musicBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (soundonoff==1)
            {
                menuplayerbttns.SoundLocation = "chebxSound.wav";
                menuplayerbttns.Play();
            }
            if (musicbttn.Checked == true)
            {

                playmusic();
                musiconoff = 1;
                
            }
            if (musicbttn.Checked == false)
            {
                menuplayer.controls.stop();
                musiconoff = 0;
            }
        }

        //Action perfomed when the user presses the easy-difficulty checkbox.
        private void easybttn_CheckedChanged(object sender, EventArgs e)
        {
            if (soundbttn.Checked == true)
            {
                menuplayerbttns.SoundLocation = "chebxSound.wav";
                menuplayerbttns.Play();

            }
            //If the user checks the checkbox, set the difficulty mode to easy and uncheck the other difficulty modes' checkboxes.
            if (easybttn.Checked == true)
            {

                difmode = 1;
                normalbttn.Checked = false;
                hardbttn.Checked = false;
            }
            //If the user unchecks the checkbox, set the difficulty mode to normal.
            if ((easybttn.Checked == false) && (hardbttn.Checked == false))
            {

                difmode = 2;
                normalbttn.Checked = true;
            }

        }

        //Action perfomed when the user presses the normal-difficulty checkbox.
        private void normalbttn_CheckedChanged(object sender, EventArgs e)
        {
            if (soundbttn.Checked == true)
            {
                menuplayerbttns.SoundLocation = "chebxSound.wav";
                menuplayerbttns.Play();

            }

            //If the user checks the checkbox, set the difficulty mode to normal and uncheck the other difficulty modes' checkboxes.
            if (normalbttn.Checked == true)
            {

                difmode = 2;
                easybttn.Checked = false;
                hardbttn.Checked = false;
            }
            //If the user unchecks the checkbox, set the difficulty mode to easy.
            if ((normalbttn.Checked == false)&& (hardbttn.Checked == false))
            {

                difmode = 1;
                easybttn.Checked = true;
            }
        }

        //Action perfomed when the user presses the hard-difficulty checkbox.
        private void hardbttn_CheckedChanged(object sender, EventArgs e)
        {
            if (soundbttn.Checked == true)
            {
                menuplayerbttns.SoundLocation = "chebxSound.wav";
                menuplayerbttns.Play();

            }

            //If the user checks the checkbox, set the difficulty mode to hard and uncheck the other difficulty modes' checkboxes.
            if (hardbttn.Checked == true)
            {

                difmode = 3;
                normalbttn.Checked = false;
                easybttn.Checked = false;
            }
            //If the user unchecks the checkbox, set the difficulty mode to normal.
            if (hardbttn.Checked == false)
            {

                difmode = 2;
                normalbttn.Checked = true;
            }
        }

        //Action performed when the X button is pressed
        private void AskPermissionBeforeQuit2(object sender, FormClosingEventArgs e)
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
