using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{

    public partial class PuzzleGame : Form
    {

        //Creating the list in which we are going to store our puzzle-pieces and some global variables such as,
        // a time counter, sound player,music player, enable-disable music and sound variables,difficulty variable,puzzle-picture and song indexes and a MainMenu form object.
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        System.Media.SoundPlayer playerbttns = new System.Media.SoundPlayer();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int inNullSliceIndex, pnum, puzzlenumber, playb = 0;
        int songindex, msonoff, sndonoff, dlevel;
        Boolean playpausebttnenabled;
        MainMenu mn = new MainMenu();


        //Constructor method for when the PuzzleGame(GameBoard) form  is called from the MainMenu form.
        //Information such as the difficulty, sound and music settings are transfered to this form, from the MainMenu form that made the call. 
        public PuzzleGame(int a, int b, int c)
        {

            InitializeComponent();
            TimeCounter.Text = "00:00:00";
            this.msonoff = a;
            this.sndonoff = b;
            this.dlevel = c;
        }

        //Action perfomed when the form is initially loaded.
        private void GameBoard_Load(object sender, EventArgs e)
        {

            if (dlevel == 1)
                dlvltxt.Text = "Easy Mode";
            else if(dlevel == 2)
                dlvltxt.Text = "Normal Mode";
            else
                dlvltxt.Text = "Hard Mode";

            //Methods used to get the pictures and the according soundtrack when the form is loaded.
            songindex = getTheImage();
            makeSoundTrack();
            Shuffle();


        }

        //A method that activates whenever the puzzle is swapped with another one, or when the form is initially loaded.
        //It randomly picks a puzzle from the available ones and generates the necessary pictures from the resources folder.
        //It also returns the index, that signifies whish puzzle is displayed, so that the makeSoundTrack method generates the corresponding song.
        public int getTheImage()
        {
            //Generates a random  number from 1-8 that will be used as an index that signifies whish pictures will be used as the displaying puzzle.
            Random r1 = new Random();
            pnum = puzzlenumber;
            puzzlenumber = r1.Next(1, 9);
            while (pnum == puzzlenumber)
            {
                puzzlenumber = r1.Next(1, 9);
            }

            //Each case corresponds to a different puzzle.
            switch (puzzlenumber)
            {
                //"Frozen" puzzle.
                case 1:
                    lstOriginalPictureList.AddRange(collection: new Bitmap[] { Properties.Resources.Frozen1, Properties.Resources.Frozen2,
                        Properties.Resources.Frozen3, Properties.Resources.Frozen4, Properties.Resources.Frozen5, Properties.Resources.Frozen6, Properties.Resources.Frozen7,
                        Properties.Resources.Frozen8, Properties.Resources.Frozen9, Properties.Resources.Frozen10, Properties.Resources.Frozen11, Properties.Resources.Frozen12,
                        Properties.Resources.Frozen13, Properties.Resources.Frozen14, Properties.Resources.Frozen15, Properties.Resources.Frozen16, Properties.Resources.emptybox });
                    gbOriginal.BackgroundImage = Properties.Resources.Frozen;
                    this.BackgroundImage = Properties.Resources.FrozenBackg;
                    return puzzlenumber;

                //"Tangled" puzzle.	
                case 2:
                    lstOriginalPictureList.AddRange(collection: new Bitmap[] { Properties.Resources.Tangled1, Properties.Resources.Tangled2,
                        Properties.Resources.Tangled3, Properties.Resources.Tangled4, Properties.Resources.Tangled5, Properties.Resources.Tangled6, Properties.Resources.Tangled7,
                        Properties.Resources.Tangled8, Properties.Resources.Tangled9, Properties.Resources.Tangled10, Properties.Resources.Tangled11, Properties.Resources.Tangled12,
                        Properties.Resources.Tangled13, Properties.Resources.Tangled14, Properties.Resources.Tangled15, Properties.Resources.Tangled16, Properties.Resources.emptybox });
                    gbOriginal.BackgroundImage = Properties.Resources.Tangled;
                    this.BackgroundImage = Properties.Resources.TangledBackg;
                    return puzzlenumber;

                //"Inside Out" puzzle.
                case 3:
                    lstOriginalPictureList.AddRange(collection: new Bitmap[] { Properties.Resources.InsideOut1, Properties.Resources.InsideOut2,
                        Properties.Resources.InsideOut3, Properties.Resources.InsideOut4, Properties.Resources.InsideOut5, Properties.Resources.InsideOut6, Properties.Resources.InsideOut7,
                        Properties.Resources.InsideOut8, Properties.Resources.InsideOut9, Properties.Resources.InsideOut10, Properties.Resources.InsideOut11, Properties.Resources.InsideOut12,
                        Properties.Resources.InsideOut13, Properties.Resources.InsideOut14, Properties.Resources.InsideOut15, Properties.Resources.InsideOut16, Properties.Resources.emptybox });
                    gbOriginal.BackgroundImage = Properties.Resources.InsideOut;
                    this.BackgroundImage = Properties.Resources.InsideOutBackg;
                    return puzzlenumber;

                //"Toy Story" puzzle.
                case 4:
                    lstOriginalPictureList.AddRange(collection: new Bitmap[] { Properties.Resources.Toystory1, Properties.Resources.Toystory2,
                        Properties.Resources.Toystory3, Properties.Resources.Toystory4, Properties.Resources.Toystory5, Properties.Resources.Toystory6, Properties.Resources.Toystory7,
                        Properties.Resources.Toystory8, Properties.Resources.Toystory9, Properties.Resources.Toystory10, Properties.Resources.Toystory11, Properties.Resources.Toystory12,
                        Properties.Resources.Toystory13, Properties.Resources.Toystory14, Properties.Resources.Toystory15, Properties.Resources.Toystory16, Properties.Resources.emptybox });
                    gbOriginal.BackgroundImage = Properties.Resources.Toystory;
                    this.BackgroundImage = Properties.Resources.ToyStoryBackg;
                    return puzzlenumber;

                //"Moana" puzzle.
                case 5:
                    lstOriginalPictureList.AddRange(collection: new Bitmap[] { Properties.Resources.Moana1, Properties.Resources.Moana2,
                        Properties.Resources.Moana3, Properties.Resources.Moana4, Properties.Resources.Moana5, Properties.Resources.Moana6, Properties.Resources.Moana7,
                        Properties.Resources.Moana8, Properties.Resources.Moana9, Properties.Resources.Moana10, Properties.Resources.Moana11, Properties.Resources.Moana12,
                        Properties.Resources.Moana13, Properties.Resources.Moana14, Properties.Resources.Moana15, Properties.Resources.Moana16, Properties.Resources.emptybox });
                    gbOriginal.BackgroundImage = Properties.Resources.Moana;
                    this.BackgroundImage = Properties.Resources.MoanaBackg;
                    return puzzlenumber;

                //"Minions" puzzle.	
                case 6:
                    lstOriginalPictureList.AddRange(collection: new Bitmap[] { Properties.Resources.Minions1, Properties.Resources.Minions2,
                        Properties.Resources.Minions3, Properties.Resources.Minions4, Properties.Resources.Minions5, Properties.Resources.Minions6, Properties.Resources.Minions7,
                        Properties.Resources.Minions8, Properties.Resources.Minions9, Properties.Resources.Minions10, Properties.Resources.Minions11, Properties.Resources.Minions12,
                        Properties.Resources.Minions13, Properties.Resources.Minions14, Properties.Resources.Minions15, Properties.Resources.Minions16, Properties.Resources.emptybox });
                    gbOriginal.BackgroundImage = Properties.Resources.Minions;
                    this.BackgroundImage = Properties.Resources.MinionsBackg;
                    return puzzlenumber;

                //"Princess" puzzle.	
                case 7:
                    lstOriginalPictureList.AddRange(collection: new Bitmap[] { Properties.Resources.Princess1, Properties.Resources.Princess2,
                        Properties.Resources.Princess3, Properties.Resources.Princess4, Properties.Resources.Princess5, Properties.Resources.Princess6, Properties.Resources.Princess7,
                        Properties.Resources.Princess8, Properties.Resources.Princess9, Properties.Resources.Princess10, Properties.Resources.Princess11, Properties.Resources.Princess12,
                        Properties.Resources.Princess13, Properties.Resources.Princess14, Properties.Resources.Princess15, Properties.Resources.Princess16, Properties.Resources.emptybox });
                    gbOriginal.BackgroundImage = Properties.Resources.Princess;
                    this.BackgroundImage = Properties.Resources.PrincessBackg;
                    return puzzlenumber;

                //"Rio" puzzle.
                case 8:
                    lstOriginalPictureList.AddRange(collection: new Bitmap[] { Properties.Resources.Rio1, Properties.Resources.Rio2,
                        Properties.Resources.Rio3, Properties.Resources.Rio4, Properties.Resources.Rio5, Properties.Resources.Rio6, Properties.Resources.Rio7,
                        Properties.Resources.Rio8, Properties.Resources.Rio9, Properties.Resources.Rio10, Properties.Resources.Rio11, Properties.Resources.Rio12,
                        Properties.Resources.Rio13, Properties.Resources.Rio14, Properties.Resources.Rio15, Properties.Resources.Rio16, Properties.Resources.emptybox });
                    gbOriginal.BackgroundImage = Properties.Resources.Rio;
                    this.BackgroundImage = Properties.Resources.RioBackg;
                    return puzzlenumber;

                default:
                    return puzzlenumber;

            }
        }

        //The method activates whenever the puzzle is swapped and the song has to be swapped accordingly, or whenever the music on-off button is pressed.
        void makeSoundTrack()
        {

            switch (songindex)
            {
                //"Frozen" theme song.
                case 1:
                    if (msonoff == 1)
                    {
                        player.URL = "FrozenSound.mp3";
                        player.settings.setMode("Loop", true);
                        player.settings.volume = 30;
                        player.settings.setMode("Loop", true);
                    }
                    break;

                //"Tangled" theme song.
                case 2:
                    if (msonoff == 1)
                    {
                        player.URL = "TangledSound.mp3";
                        player.settings.setMode("Loop", true);
                        player.settings.volume = 30;
                        player.controls.play();
                    }
                    break;

                //"Inside Out" theme song.
                case 3:
                    if (msonoff == 1)
                    {
                        player.URL = "InsideOutSound.mp3";
                        player.settings.setMode("Loop", true);
                        player.settings.volume = 30;
                        player.controls.play();
                    }
                    break;

                //"Toy Story" theme song.
                case 4:
                    if (msonoff == 1)
                    {
                        player.URL = "ToyStorySound.mp3";
                        player.settings.setMode("Loop", true);
                        player.settings.volume = 30;
                        player.controls.play();
                    }
                    break;

                //"Moana" theme song.
                case 5:
                    if (msonoff == 1)
                    {
                        player.URL = "MoanaSound.mp3";
                        player.settings.setMode("Loop", true);
                        player.settings.volume = 30;
                        player.controls.play();
                    }
                    break;

                //"Minions" theme song.
                case 6:
                    if (msonoff == 1)
                    {
                        player.URL = "MinionsSound.mp3";
                        player.settings.setMode("Loop", true);
                        player.settings.volume = 30;
                        player.controls.play();
                    }
                    break;

                //"Princess" theme song.
                case 7:
                    if (msonoff == 1)
                    {
                        player.URL = "PrincessSound.mp3";
                        player.settings.setMode("Loop", true);
                        player.settings.volume = 30;
                        player.controls.play();
                    }
                    break;

                //"Rio" theme song.
                case 8:
                    if (msonoff == 1)
                    {
                        player.URL = "RioSound.mp3";
                        player.settings.setMode("Loop", true);
                        player.settings.volume = 30;
                        player.controls.play();
                    }
                    break;
            }
        }

        //This method is called whenever the puzzle's sliced pictures have to be shuffled or the puzzle is swapped.
        void Shuffle()
        {
            int j;
            //A list that contains the the puzzle's sliced pictures indexes. 
            //Index #15 is missing because it is the last piece of the puzzle and the star-image(empty picture box)will take its place.
            List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 8, 7, 9, 10, 11, 12, 13, 14, 16 });  
            Random r = new Random();
            for (int i = 0; i < 16; i++)
            {
                //Remove a random index from the list, in order not to reread it and get the same picture's index more than once.
                Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));

                //Place in the picturebox[i] of the gbPuzzleBox grid, the pictue[j] of the original sliced-picture list.
                ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];

                //Store star-image's index to isNullSliceIndex.
                if (j == 16)
                    inNullSliceIndex = i;                                                   
            }

        }

        //The following method checks if the pictures in the gbPuzzleBox, follows the same order as the pictures in the OriginalPictureList.
        bool VictoryCheck()
        {

            int i;
            for (i = 0; i < 15; i++)
            {
                
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i])
                   break;
                                 
            }
            if (i == 15)
                return true;
            else
                return false;
            
        }

        //The following method activates and deactivayes the time counter.
        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            //Check if the time counter has started counting and update the time that elpased.
            if (timer.Elapsed.ToString() != "00:00:00")
                TimeCounter.Text = timer.Elapsed.ToString().Remove(8);

            //Check if the time counter has started counting, and if it did, enable tha pause game button.
            if (timer.Elapsed.ToString() == "00:00:00")
                playpausebttnenabled = false;
            else
                playpausebttnenabled = true;

            //Check if the game is on easy mode and then check if the time elapsed equals to 2 minutes.
            //If it does disable the pause button, initalize the time counter and reshuffle the puzzle's pieces.
            if (dlevel == 1)
            {
                
                if (timer.Elapsed.Minutes.ToString() == "2")
                {
                    timer.Reset();
                    TimeCounter.Text = "00:00:00";
                    playpausebttnenabled = false;
                    MessageBox.Show("Time Is Up!!\nTry Again", "Missing Piece");
                    Shuffle();
                }
            }

            //Check if the game is on normal mode and then check if the time elapsed equals to 8 minutes.
            //If it does disable the pause button, initalize the time counter and reshuffle the puzzle's pieces.
            else if (dlevel == 2)
            {
                if (timer.Elapsed.Minutes.ToString() == "8")
                {
                    timer.Reset();
                    TimeCounter.Text = "00:00:00";
                    playpausebttnenabled = false;
                    MessageBox.Show("Time Is Up!!\nTry Again", "Missing Piece");
                    Shuffle();
                }
            }


            //Check if the game is on hard mode and then check if the time elapsed equals to 20 minutes.
            //If it does disable the pause button, initalize the time counter and reshuffle the puzzle's pieces.
            else if (dlevel == 3)
            {
                if (timer.Elapsed.Minutes.ToString() == "20")
                {
                    timer.Reset();
                    TimeCounter.Text = "00:00:00";
                    playpausebttnenabled = false;
                    MessageBox.Show("Time Is Up!!\nTry Again", "Missing Piece");
                    Shuffle();
                }
            }
        }

        //Action perfomed when the user presses the sound on-off button.
        private void sndBttn_Click(object sender, EventArgs e)
        {
            if (sndonoff == 1)
                sndonoff = 0;             
           else
            {
                sndonoff = 1;
                playerbttns.SoundLocation = "menubSound.wav";
                playerbttns.Play();
                
            }

        }

        //Action performed when the home button is pressed.
        private void homeBttn_Click(object sender, EventArgs e)
        {
            if (sndonoff == 1)
            {
                playerbttns.SoundLocation = "menubSound.wav";
                playerbttns.Play();

            }
            //Hide this form, open a MainMenu form and transfer the difficulty, sound and music settings, to it.
            this.Hide();
            player.controls.stop();
            MainMenu mn = new MainMenu(msonoff, sndonoff, dlevel);
            mn.ShowDialog();
            this.Close();
            Environment.Exit(0);
        }


        //Action performed when the shuffle button is pressed.
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (sndonoff == 1)
            {
                playerbttns.SoundLocation = "shuffleSound.wav";
                playerbttns.Play();

            }
            DialogResult YesOrNo = new DialogResult();

            //If the game has not started.
            if (TimeCounter.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Are You Sure you want to restart the puzzle?", "Got stuck?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            //If the game has not started or the player chose to reset the puzzle.
            if (YesOrNo == DialogResult.Yes || TimeCounter.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                TimeCounter.Text = "00:00:00";

            }

        }

        //Action performed, when you press the X button.
        private void AskPermissionBeforeQuit(object sender, FormClosingEventArgs e)
        {
          
             DialogResult YesOrNO = MessageBox.Show("Are You Sure you want to Quit?", "Exit the game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             //If the users chooses not exit close the Message box that poped on the screen.
             if (YesOrNO == DialogResult.No)
                 e.Cancel = true;

             //If the users chooses to exit, close the application.
             if (YesOrNO == DialogResult.Yes)
                 Environment.Exit(0);
            
        }


        //Action performed, when the user presses a puzzle box which is a neighbor to the emptybox of the Gameboard form's gbPuzzleBox.
        private void SwitchPictureBox(object sender, EventArgs e)
        {
            //Start the time counter.
            if (TimeCounter.Text == "00:00:00")
                timer.Start();
            //The index of the pressed pictured.
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);

            //Check if the difficulty is set to easy mode.
            if (dlevel == 1)
            {
                //Play the swap image sound.
                if (sndonoff == 1)
                {
                    playerbttns.SoundLocation = "picmoveSound.wav";
                    playerbttns.Play();

                }
                //Swap the image that was pressed  with the star-image (empty box).
                ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[16];
                inNullSliceIndex = inPictureBoxIndex;
               
                //Check if the player won the game.
                if (VictoryCheck())
                {
                    //Stop the time counter and swap the star-image with the last picture of the original picture list.
                    timer.Stop();
                    (gbPuzzleBox.Controls[15] as PictureBox).Image = lstOriginalPictureList[15];

                    //Play the victory sound if the settings allow it.
                    if (sndonoff == 1)
                    {
                        playerbttns.SoundLocation = "victorySound.wav";
                        playerbttns.Play();
                    }
                    MessageBox.Show("\t Congratulations!!! \n\n\t You solved the puzzle in : \t" + timer.Elapsed.ToString().Remove(8));
                    TimeCounter.Text = "00:00:00";
                    timer.Reset();


                    if (sndonoff == 1)
                    {
                        playerbttns.SoundLocation = "swapSound.wav";
                        playerbttns.Play();

                    }
                    //Clear the lstOriginalPictureList.
                    lstOriginalPictureList.Clear();

                    //Reset the time counter.
                    timer.Reset();
                    TimeCounter.Text = "00:00:00";

                    //Load new puzzle's pictures and theme song.
                    songindex = getTheImage();
                    makeSoundTrack();
                    Shuffle();
                }

            }
            //Check if the difficulty is set to normal mode.
            else if (dlevel == 2)
            {
                //Check if τηε ιμαγε τηατ ςασ πρεσσεδ ισ a neighnor to the emptybox horizontally, vertically or diagonally.
                if (((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X - 132 ||
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X + 132) &&
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y) ||
                    ((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y - 132 ||
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y + 132) &&
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X) ||
                    (((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X - 132) &&
                    ((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y - 132)))) ||
                    (((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X + 132) &&
                    ((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y - 132)))) ||
                    (((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X - 132) &&
                    ((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y + 132)))) ||
                    (((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X + 132) &&
                    ((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y + 132))))) 
                {
                    //Swap places with the emptybox.
                    if (sndonoff == 1)
                    {
                        playerbttns.SoundLocation = "picmoveSound.wav";
                        playerbttns.Play();

                    }
                    //Swap the image that was pressed  with the star-image (empty box).
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[16];

                    inNullSliceIndex = inPictureBoxIndex;

                    //Check if the player won the game.
                    if (VictoryCheck())
                    {
                        timer.Stop();
                        (gbPuzzleBox.Controls[15] as PictureBox).Image = lstOriginalPictureList[15];

                        if (sndonoff == 1)
                        {
                            playerbttns.SoundLocation = "victorySound.wav";
                            playerbttns.Play();
                        }

                        MessageBox.Show("\t Congratulations!!! \n\n\t You solved the puzzle in : \t" + timer.Elapsed.ToString().Remove(8));
                        TimeCounter.Text = "00:00:00";
                        timer.Reset();

                        if (sndonoff == 1)
                        {
                            playerbttns.SoundLocation = "swapSound.wav";
                            playerbttns.Play();

                        }
                        //Clear the lstOriginalPictureList.
                        lstOriginalPictureList.Clear();

                        //Reset the time counter.
                        timer.Reset();
                        TimeCounter.Text = "00:00:00";

                        //Load new puzzle's pictures and theme song.
                        songindex = getTheImage();
                        makeSoundTrack();
                        Shuffle();
                    }

                }
                else
                {   
                    //If the move the player is trying to make is not allowed play the error sound
                    if (sndonoff == 1)
                    {
                        playerbttns.SoundLocation = "errorpauseSound.wav";
                        playerbttns.Play();

                    }
                }

            }
            //Check if the difficulty is set to hard mode.
            else if (dlevel == 3)
            {
                //Check if it's a neighnor to the emptybox horizontally or vertically.
                if (((((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X - 132 ||
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X + 132) &&
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y) ||
                    (((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y - 132 ||
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.Y == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.Y + 132)
                    && ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Location.X == ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Location.X)
                {
                    //Swap places with the emptybox.
                    if (sndonoff == 1)
                    {
                        playerbttns.SoundLocation = "picmoveSound.wav";
                        playerbttns.Play();

                    }
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[16];
                    inNullSliceIndex = inPictureBoxIndex;

                    //Check if the player won the game.
                    if (VictoryCheck())
                    {
                        timer.Stop();
                        (gbPuzzleBox.Controls[15] as PictureBox).Image = lstOriginalPictureList[15];
                        if (sndonoff == 1)
                        {
                            playerbttns.SoundLocation = "victorySound.wav";
                            playerbttns.Play();
                        }
                        MessageBox.Show("\t Congratulations!!! \n\n\t You solved the puzzle in : \t" + timer.Elapsed.ToString().Remove(8));
                        TimeCounter.Text = "00:00:00";
                        timer.Reset();

                        if (sndonoff == 1)
                        {
                            playerbttns.SoundLocation = "swapSound.wav";
                            playerbttns.Play();

                        }
                        //Clear the lstOriginalPictureList.
                        lstOriginalPictureList.Clear();

                        //Reset the time counter.
                        timer.Reset();
                        TimeCounter.Text = "00:00:00";

                        //Load new puzzle's pictures and theme song.
                        songindex = getTheImage();
                        makeSoundTrack();
                        Shuffle();
                    }

                }
                else
                {
                    //If the move the player is trying to make is not allowed play the error sound
                    if (sndonoff == 1)
                    {
                        playerbttns.SoundLocation = "errorpauseSound.wav";
                        playerbttns.Play();

                    }
                }

            }
            
        }
    

        //Action performed, when the user presses the sound button.
        private void musicButton_Click(object sender, EventArgs e)
        {
            
            if (sndonoff == 1)
            {
                playerbttns.SoundLocation = "menubSound.wav";
                playerbttns.Play();
                
            }
            //If the music is playing, stop it, otherwise play the puzzle's according theme song.
            if (msonoff == 1)
            {
                msonoff = 0;
                player.controls.stop();
            }

            else
            {
                msonoff = 1;
                makeSoundTrack();
            }

        }

        //Action performed, when the user presses the swap-puzzle button.
        private void swaPbutton_Click(object sender, EventArgs e)
        {
            if (sndonoff == 1)
            {
                playerbttns.SoundLocation = "swapSound.wav";
                playerbttns.Play();

            }
            //Clear the lstOriginalPictureList.
            lstOriginalPictureList.Clear();

            //Reset the time counter.
            timer.Reset();
            TimeCounter.Text = "00:00:00";

            //Load new puzzle's pictures and theme song.
            songindex = getTheImage();
            makeSoundTrack();
            Shuffle();

        }

        //Action performed, when the user presses the pause-game button.
        private void PauseOrResume(object sender, EventArgs e)
        {
            //Check if the game has started. If not, then play the error button.
            if (playpausebttnenabled == false)
            {
                if (sndonoff == 1)
                {
                    playerbttns.SoundLocation = "errorpauseSound.wav";
                    playerbttns.Play();

                }
            }
            //Otherwise, play the pause button's sound.
            else
            {

                if (sndonoff == 1)
                {
                    playerbttns.SoundLocation = "pauseSound.wav";
                    playerbttns.Play();

                }
                //Check if the game is paused. If not, then hide the puzzle and pause the time counter. 
                if (playb == 0)
                {
                    timer.Stop();
                    gbPuzzleBox.Visible = false;
                    playb = 1;
                }
                //Otherwise make it visble and unpause the time counter.
                else
                {
                    timer.Start();
                    gbPuzzleBox.Visible = true;
                    playb = 0;
                }
            }
        }      

    
    }
}
