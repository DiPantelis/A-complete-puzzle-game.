using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class PuzzleGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleGame));
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.homebttn = new System.Windows.Forms.PictureBox();
            this.sndbttn = new System.Windows.Forms.PictureBox();
            this.musicbutton = new System.Windows.Forms.PictureBox();
            this.playpausebttn = new System.Windows.Forms.PictureBox();
            this.buttonshuffle = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.nextpbttn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TimeCounter = new System.Windows.Forms.Label();
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.picbox3 = new System.Windows.Forms.PictureBox();
            this.picbox4 = new System.Windows.Forms.PictureBox();
            this.picbox5 = new System.Windows.Forms.PictureBox();
            this.picbox6 = new System.Windows.Forms.PictureBox();
            this.picbox7 = new System.Windows.Forms.PictureBox();
            this.picbox8 = new System.Windows.Forms.PictureBox();
            this.picbox9 = new System.Windows.Forms.PictureBox();
            this.picbox10 = new System.Windows.Forms.PictureBox();
            this.picbox11 = new System.Windows.Forms.PictureBox();
            this.picbox12 = new System.Windows.Forms.PictureBox();
            this.picbox13 = new System.Windows.Forms.PictureBox();
            this.picbox14 = new System.Windows.Forms.PictureBox();
            this.picbox15 = new System.Windows.Forms.PictureBox();
            this.picbox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dlvltxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homebttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sndbttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpausebttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonshuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextpbttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOriginal
            // 
            this.gbOriginal.AccessibleDescription = "Original";
            this.gbOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOriginal.BackColor = System.Drawing.Color.Transparent;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbOriginal.Location = new System.Drawing.Point(22, 114);
            this.gbOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.gbOriginal.MaximumSize = new System.Drawing.Size(968, 664);
            this.gbOriginal.MinimumSize = new System.Drawing.Size(468, 464);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Padding = new System.Windows.Forms.Padding(0);
            this.gbOriginal.Size = new System.Drawing.Size(568, 564);
            this.gbOriginal.TabIndex = 0;
            this.gbOriginal.TabStop = false;
            // 
            // tmrTimeElapse
            // 
            this.tmrTimeElapse.Enabled = true;
            this.tmrTimeElapse.Interval = 900;
            this.tmrTimeElapse.Tick += new System.EventHandler(this.UpdateTimeElapsed);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // homebttn
            // 
            this.homebttn.AccessibleDescription = "homebttn";
            this.homebttn.AccessibleName = "homebttn";
            this.homebttn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.homebttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homebttn.BackColor = System.Drawing.Color.Transparent;
            this.homebttn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.homebttn;
            this.homebttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebttn.Location = new System.Drawing.Point(1128, 42);
            this.homebttn.Name = "homebttn";
            this.homebttn.Size = new System.Drawing.Size(62, 56);
            this.homebttn.TabIndex = 15;
            this.homebttn.TabStop = false;
            this.homebttn.Click += new System.EventHandler(this.homeBttn_Click);
            // 
            // sndbttn
            // 
            this.sndbttn.AccessibleDescription = "sndbttn";
            this.sndbttn.AccessibleName = "sndbttn";
            this.sndbttn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.sndbttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sndbttn.BackColor = System.Drawing.Color.Transparent;
            this.sndbttn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.soundbttn;
            this.sndbttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sndbttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sndbttn.Location = new System.Drawing.Point(1060, 42);
            this.sndbttn.Name = "sndbttn";
            this.sndbttn.Size = new System.Drawing.Size(62, 56);
            this.sndbttn.TabIndex = 14;
            this.sndbttn.TabStop = false;
            this.sndbttn.Click += new System.EventHandler(this.sndBttn_Click);
            // 
            // musicbutton
            // 
            this.musicbutton.AccessibleDescription = "musicbutton";
            this.musicbutton.AccessibleName = "musicbutton";
            this.musicbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.musicbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.musicbutton.BackColor = System.Drawing.Color.Transparent;
            this.musicbutton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.musicbttn;
            this.musicbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musicbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicbutton.InitialImage = null;
            this.musicbutton.Location = new System.Drawing.Point(994, 42);
            this.musicbutton.Name = "musicbutton";
            this.musicbutton.Size = new System.Drawing.Size(60, 56);
            this.musicbutton.TabIndex = 13;
            this.musicbutton.TabStop = false;
            this.musicbutton.WaitOnLoad = true;
            this.musicbutton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // playpausebttn
            // 
            this.playpausebttn.AccessibleName = "playpausebttn";
            this.playpausebttn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.playpausebttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playpausebttn.BackColor = System.Drawing.Color.PeachPuff;
            this.playpausebttn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.playallbttn;
            this.playpausebttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playpausebttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playpausebttn.Location = new System.Drawing.Point(768, 695);
            this.playpausebttn.Name = "playpausebttn";
            this.playpausebttn.Size = new System.Drawing.Size(71, 53);
            this.playpausebttn.TabIndex = 12;
            this.playpausebttn.TabStop = false;
            this.playpausebttn.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // buttonshuffle
            // 
            this.buttonshuffle.AccessibleName = "nextpbttn";
            this.buttonshuffle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonshuffle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonshuffle.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonshuffle.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.shufflebutton;
            this.buttonshuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonshuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonshuffle.Location = new System.Drawing.Point(1085, 695);
            this.buttonshuffle.Name = "buttonshuffle";
            this.buttonshuffle.Size = new System.Drawing.Size(71, 53);
            this.buttonshuffle.TabIndex = 11;
            this.buttonshuffle.TabStop = false;
            this.buttonshuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.shufflettext;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(896, 695);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(192, 53);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // nextpbttn
            // 
            this.nextpbttn.AccessibleName = "nextpbttn";
            this.nextpbttn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.nextpbttn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextpbttn.BackColor = System.Drawing.Color.PeachPuff;
            this.nextpbttn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.swapbttn;
            this.nextpbttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextpbttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextpbttn.InitialImage = null;
            this.nextpbttn.Location = new System.Drawing.Point(329, 695);
            this.nextpbttn.Name = "nextpbttn";
            this.nextpbttn.Size = new System.Drawing.Size(71, 53);
            this.nextpbttn.TabIndex = 0;
            this.nextpbttn.TabStop = false;
            this.nextpbttn.WaitOnLoad = true;
            this.nextpbttn.Click += new System.EventHandler(this.swaPbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.swapimagetext1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 695);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 53);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pugame;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(461, 695);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(301, 53);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // TimeCounter
            // 
            this.TimeCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeCounter.AutoSize = true;
            this.TimeCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeCounter.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCounter.ForeColor = System.Drawing.Color.PeachPuff;
            this.TimeCounter.Image = global::WindowsFormsApplication1.Properties.Resources.pastel;
            this.TimeCounter.Location = new System.Drawing.Point(477, 25);
            this.TimeCounter.Name = "TimeCounter";
            this.TimeCounter.Size = new System.Drawing.Size(266, 82);
            this.TimeCounter.TabIndex = 3;
            this.TimeCounter.Text = "00:00:00";
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.AccessibleDescription = "gbPuzzleBox";
            this.gbPuzzleBox.AccessibleName = "gbPuzzleBox";
            this.gbPuzzleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPuzzleBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbPuzzleBox.BackColor = System.Drawing.Color.Transparent;
            this.gbPuzzleBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pastel;
            this.gbPuzzleBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbPuzzleBox.Controls.Add(this.picbox1);
            this.gbPuzzleBox.Controls.Add(this.picbox2);
            this.gbPuzzleBox.Controls.Add(this.picbox3);
            this.gbPuzzleBox.Controls.Add(this.picbox4);
            this.gbPuzzleBox.Controls.Add(this.picbox5);
            this.gbPuzzleBox.Controls.Add(this.picbox6);
            this.gbPuzzleBox.Controls.Add(this.picbox7);
            this.gbPuzzleBox.Controls.Add(this.picbox8);
            this.gbPuzzleBox.Controls.Add(this.picbox9);
            this.gbPuzzleBox.Controls.Add(this.picbox10);
            this.gbPuzzleBox.Controls.Add(this.picbox11);
            this.gbPuzzleBox.Controls.Add(this.picbox12);
            this.gbPuzzleBox.Controls.Add(this.picbox13);
            this.gbPuzzleBox.Controls.Add(this.picbox14);
            this.gbPuzzleBox.Controls.Add(this.picbox15);
            this.gbPuzzleBox.Controls.Add(this.picbox16);
            this.gbPuzzleBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbPuzzleBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPuzzleBox.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gbPuzzleBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbPuzzleBox.Location = new System.Drawing.Point(630, 114);
            this.gbPuzzleBox.Margin = new System.Windows.Forms.Padding(0);
            this.gbPuzzleBox.MaximumSize = new System.Drawing.Size(668, 664);
            this.gbPuzzleBox.MinimumSize = new System.Drawing.Size(468, 464);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbPuzzleBox.Size = new System.Drawing.Size(568, 564);
            this.gbPuzzleBox.TabIndex = 0;
            this.gbPuzzleBox.TabStop = false;
            // 
            // picbox1
            // 
            this.picbox1.AccessibleDescription = "picbox1";
            this.picbox1.AccessibleName = "picbox1";
            this.picbox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox1.BackColor = System.Drawing.Color.Transparent;
            this.picbox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox1.Location = new System.Drawing.Point(17, 15);
            this.picbox1.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox1.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(135, 135);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            this.picbox1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox2
            // 
            this.picbox2.AccessibleDescription = "picbox2";
            this.picbox2.AccessibleName = "picbox2";
            this.picbox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox2.BackColor = System.Drawing.Color.Transparent;
            this.picbox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox2.Location = new System.Drawing.Point(149, 15);
            this.picbox2.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox2.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(135, 135);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox2.TabIndex = 0;
            this.picbox2.TabStop = false;
            this.picbox2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox3
            // 
            this.picbox3.AccessibleDescription = "picbox3";
            this.picbox3.AccessibleName = "picbox3";
            this.picbox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox3.BackColor = System.Drawing.Color.Transparent;
            this.picbox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox3.Location = new System.Drawing.Point(281, 15);
            this.picbox3.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox3.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox3.Name = "picbox3";
            this.picbox3.Size = new System.Drawing.Size(135, 135);
            this.picbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox3.TabIndex = 0;
            this.picbox3.TabStop = false;
            this.picbox3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox4
            // 
            this.picbox4.AccessibleDescription = "picbox4";
            this.picbox4.AccessibleName = "picbox4";
            this.picbox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox4.BackColor = System.Drawing.Color.Transparent;
            this.picbox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox4.Location = new System.Drawing.Point(413, 15);
            this.picbox4.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox4.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox4.Name = "picbox4";
            this.picbox4.Size = new System.Drawing.Size(135, 135);
            this.picbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox4.TabIndex = 3;
            this.picbox4.TabStop = false;
            this.picbox4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox5
            // 
            this.picbox5.AccessibleDescription = "picbox5";
            this.picbox5.AccessibleName = "picbox5";
            this.picbox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox5.BackColor = System.Drawing.Color.Transparent;
            this.picbox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox5.Location = new System.Drawing.Point(17, 147);
            this.picbox5.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox5.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox5.Name = "picbox5";
            this.picbox5.Size = new System.Drawing.Size(135, 135);
            this.picbox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox5.TabIndex = 0;
            this.picbox5.TabStop = false;
            this.picbox5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox6
            // 
            this.picbox6.AccessibleDescription = "picbox6";
            this.picbox6.AccessibleName = "picbox6";
            this.picbox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox6.BackColor = System.Drawing.Color.Transparent;
            this.picbox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox6.Location = new System.Drawing.Point(149, 147);
            this.picbox6.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox6.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox6.Name = "picbox6";
            this.picbox6.Size = new System.Drawing.Size(135, 135);
            this.picbox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox6.TabIndex = 0;
            this.picbox6.TabStop = false;
            this.picbox6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox7
            // 
            this.picbox7.AccessibleDescription = "picbox7";
            this.picbox7.AccessibleName = "picbox7";
            this.picbox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox7.BackColor = System.Drawing.Color.Transparent;
            this.picbox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox7.Location = new System.Drawing.Point(281, 147);
            this.picbox7.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox7.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox7.Name = "picbox7";
            this.picbox7.Size = new System.Drawing.Size(135, 135);
            this.picbox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox7.TabIndex = 0;
            this.picbox7.TabStop = false;
            this.picbox7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox8
            // 
            this.picbox8.AccessibleDescription = "picbox8";
            this.picbox8.AccessibleName = "picbox8";
            this.picbox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox8.BackColor = System.Drawing.Color.Transparent;
            this.picbox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox8.Location = new System.Drawing.Point(413, 147);
            this.picbox8.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox8.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox8.Name = "picbox8";
            this.picbox8.Size = new System.Drawing.Size(135, 135);
            this.picbox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox8.TabIndex = 1;
            this.picbox8.TabStop = false;
            this.picbox8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox9
            // 
            this.picbox9.AccessibleDescription = "picbox9";
            this.picbox9.AccessibleName = "picbox9";
            this.picbox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox9.BackColor = System.Drawing.Color.Transparent;
            this.picbox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox9.Location = new System.Drawing.Point(17, 279);
            this.picbox9.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox9.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox9.Name = "picbox9";
            this.picbox9.Size = new System.Drawing.Size(135, 135);
            this.picbox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox9.TabIndex = 0;
            this.picbox9.TabStop = false;
            this.picbox9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox10
            // 
            this.picbox10.AccessibleDescription = "picbox10";
            this.picbox10.AccessibleName = "picbox10";
            this.picbox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox10.BackColor = System.Drawing.Color.Transparent;
            this.picbox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox10.Location = new System.Drawing.Point(149, 279);
            this.picbox10.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox10.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox10.Name = "picbox10";
            this.picbox10.Size = new System.Drawing.Size(135, 135);
            this.picbox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox10.TabIndex = 0;
            this.picbox10.TabStop = false;
            this.picbox10.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox11
            // 
            this.picbox11.AccessibleDescription = "picbox11";
            this.picbox11.AccessibleName = "picbox11";
            this.picbox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox11.BackColor = System.Drawing.Color.Transparent;
            this.picbox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox11.Location = new System.Drawing.Point(281, 279);
            this.picbox11.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox11.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox11.Name = "picbox11";
            this.picbox11.Size = new System.Drawing.Size(135, 135);
            this.picbox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox11.TabIndex = 0;
            this.picbox11.TabStop = false;
            this.picbox11.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox12
            // 
            this.picbox12.AccessibleDescription = "picbox12";
            this.picbox12.AccessibleName = "picbox12";
            this.picbox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox12.BackColor = System.Drawing.Color.Transparent;
            this.picbox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox12.Location = new System.Drawing.Point(413, 279);
            this.picbox12.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picbox12.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox12.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox12.Name = "picbox12";
            this.picbox12.Size = new System.Drawing.Size(135, 135);
            this.picbox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox12.TabIndex = 2;
            this.picbox12.TabStop = false;
            this.picbox12.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox13
            // 
            this.picbox13.AccessibleDescription = "picbox13";
            this.picbox13.AccessibleName = "picbox13";
            this.picbox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox13.BackColor = System.Drawing.Color.Transparent;
            this.picbox13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox13.Location = new System.Drawing.Point(17, 411);
            this.picbox13.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox13.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox13.Name = "picbox13";
            this.picbox13.Size = new System.Drawing.Size(135, 135);
            this.picbox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox13.TabIndex = 4;
            this.picbox13.TabStop = false;
            this.picbox13.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox14
            // 
            this.picbox14.AccessibleDescription = "picbox14";
            this.picbox14.AccessibleName = "picbox14";
            this.picbox14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox14.BackColor = System.Drawing.Color.Transparent;
            this.picbox14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox14.Location = new System.Drawing.Point(149, 411);
            this.picbox14.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox14.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox14.Name = "picbox14";
            this.picbox14.Size = new System.Drawing.Size(135, 135);
            this.picbox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox14.TabIndex = 5;
            this.picbox14.TabStop = false;
            this.picbox14.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox15
            // 
            this.picbox15.AccessibleDescription = "picbox15";
            this.picbox15.AccessibleName = "picbox15";
            this.picbox15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox15.BackColor = System.Drawing.Color.Transparent;
            this.picbox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox15.Location = new System.Drawing.Point(281, 411);
            this.picbox15.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox15.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox15.Name = "picbox15";
            this.picbox15.Size = new System.Drawing.Size(135, 135);
            this.picbox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox15.TabIndex = 6;
            this.picbox15.TabStop = false;
            this.picbox15.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbox16
            // 
            this.picbox16.AccessibleDescription = "picbox16";
            this.picbox16.AccessibleName = "picbox16";
            this.picbox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox16.BackColor = System.Drawing.Color.Transparent;
            this.picbox16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox16.Location = new System.Drawing.Point(413, 411);
            this.picbox16.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picbox16.MaximumSize = new System.Drawing.Size(135, 135);
            this.picbox16.MinimumSize = new System.Drawing.Size(135, 135);
            this.picbox16.Name = "picbox16";
            this.picbox16.Size = new System.Drawing.Size(135, 135);
            this.picbox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox16.TabIndex = 7;
            this.picbox16.TabStop = false;
            this.picbox16.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-79, 695);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1801, 53);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // dlvltxt
            // 
            this.dlvltxt.AccessibleDescription = "dlvltxt";
            this.dlvltxt.AccessibleName = "dlvltxt";
            this.dlvltxt.AutoSize = true;
            this.dlvltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dlvltxt.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlvltxt.ForeColor = System.Drawing.Color.PeachPuff;
            this.dlvltxt.Image = global::WindowsFormsApplication1.Properties.Resources.pastel;
            this.dlvltxt.Location = new System.Drawing.Point(32, 25);
            this.dlvltxt.Name = "dlvltxt";
            this.dlvltxt.Size = new System.Drawing.Size(2, 82);
            this.dlvltxt.TabIndex = 17;
            // 
            // PuzzleGame
            // 
            this.AccessibleDescription = "MissingPiece";
            this.AccessibleName = "MissingPiece";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 760);
            this.Controls.Add(this.dlvltxt);
            this.Controls.Add(this.homebttn);
            this.Controls.Add(this.sndbttn);
            this.Controls.Add(this.musicbutton);
            this.Controls.Add(this.playpausebttn);
            this.Controls.Add(this.buttonshuffle);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.nextpbttn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TimeCounter);
            this.Controls.Add(this.gbOriginal);
            this.Controls.Add(this.gbPuzzleBox);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MissingPiece";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskPermissionBeforeQuit);
            this.Load += new System.EventHandler(this.GameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homebttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sndbttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpausebttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonshuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextpbttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.Label TimeCounter;
        private System.Windows.Forms.Timer tmrTimeElapse;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox buttonshuffle;
        private PictureBox playpausebttn;
        public PictureBox nextpbttn;
        public PictureBox musicbutton;
        private PictureBox sndbttn;
        private PictureBox picbox16;
        private PictureBox picbox13;
        private PictureBox picbox14;
        private PictureBox picbox15;
        private PictureBox picbox4;
        private PictureBox picbox12;
        private PictureBox picbox8;
        private PictureBox picbox1;
        private PictureBox picbox2;
        private PictureBox picbox3;
        private PictureBox picbox5;
        private PictureBox picbox6;
        private PictureBox picbox7;
        private PictureBox picbox9;
        private PictureBox picbox10;
        private PictureBox picbox11;
        private PictureBox homebttn;
        private Label dlvltxt;
    }
}

