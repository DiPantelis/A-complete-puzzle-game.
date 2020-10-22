namespace WindowsFormsApplication1
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.homebttn2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.homebttn2)).BeginInit();
            this.SuspendLayout();
            // 
            // homebttn2
            // 
            this.homebttn2.AccessibleDescription = "homebttn2";
            this.homebttn2.AccessibleName = "homebttn2";
            this.homebttn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.homebttn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homebttn2.BackColor = System.Drawing.Color.Transparent;
            this.homebttn2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.homebttn;
            this.homebttn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebttn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebttn2.Location = new System.Drawing.Point(1064, 29);
            this.homebttn2.Name = "homebttn2";
            this.homebttn2.Size = new System.Drawing.Size(62, 56);
            this.homebttn2.TabIndex = 16;
            this.homebttn2.TabStop = false;
            this.homebttn2.Click += new System.EventHandler(this.homebttn2_Click);
            // 
            // HowToPlay
            // 
            this.AccessibleDescription = "HowToPlay";
            this.AccessibleName = "HowToPlay";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 698);
            this.Controls.Add(this.homebttn2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HowToPlay";
            this.Text = "How to play";
            this.Load += new System.EventHandler(this.HowToPlay_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskPermissionBeforeQuit3);
            ((System.ComponentModel.ISupportInitialize)(this.homebttn2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox homebttn2;
    }
}