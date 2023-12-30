namespace AkmensSkeresPapirits
{
    partial class Form2
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
            this.butRock = new System.Windows.Forms.Button();
            this.butScissors = new System.Windows.Forms.Button();
            this.butPaper = new System.Windows.Forms.Button();
            this.labWinner = new System.Windows.Forms.Label();
            this.labComputer = new System.Windows.Forms.Label();
            this.labPlayer = new System.Windows.Forms.Label();
            this.labComputerScore = new System.Windows.Forms.Label();
            this.labPlayerScore = new System.Windows.Forms.Label();
            this.picBoxComputer = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // butRock
            // 
            this.butRock.BackColor = System.Drawing.Color.Red;
            this.butRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butRock.Location = new System.Drawing.Point(321, 276);
            this.butRock.Name = "butRock";
            this.butRock.Size = new System.Drawing.Size(250, 85);
            this.butRock.TabIndex = 12;
            this.butRock.Text = "Akmens";
            this.butRock.UseVisualStyleBackColor = false;
            this.butRock.Click += new System.EventHandler(this.butRock_Click);
            // 
            // butScissors
            // 
            this.butScissors.BackColor = System.Drawing.Color.Lime;
            this.butScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butScissors.Location = new System.Drawing.Point(321, 369);
            this.butScissors.Name = "butScissors";
            this.butScissors.Size = new System.Drawing.Size(250, 85);
            this.butScissors.TabIndex = 13;
            this.butScissors.Text = "Šķēres";
            this.butScissors.UseVisualStyleBackColor = false;
            this.butScissors.Click += new System.EventHandler(this.butScissors_Click);
            // 
            // butPaper
            // 
            this.butPaper.BackColor = System.Drawing.Color.Blue;
            this.butPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPaper.Location = new System.Drawing.Point(321, 460);
            this.butPaper.Name = "butPaper";
            this.butPaper.Size = new System.Drawing.Size(250, 85);
            this.butPaper.TabIndex = 14;
            this.butPaper.Text = "Papīrīts";
            this.butPaper.UseVisualStyleBackColor = false;
            this.butPaper.Click += new System.EventHandler(this.butPaper_Click);
            // 
            // labWinner
            // 
            this.labWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labWinner.Location = new System.Drawing.Point(216, 152);
            this.labWinner.Name = "labWinner";
            this.labWinner.Size = new System.Drawing.Size(453, 64);
            this.labWinner.TabIndex = 15;
            this.labWinner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labComputer
            // 
            this.labComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labComputer.Location = new System.Drawing.Point(675, 10);
            this.labComputer.Name = "labComputer";
            this.labComputer.Size = new System.Drawing.Size(197, 96);
            this.labComputer.TabIndex = 17;
            this.labComputer.Text = "Dators";
            this.labComputer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labPlayer
            // 
            this.labPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPlayer.Location = new System.Drawing.Point(10, -3);
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Size = new System.Drawing.Size(200, 107);
            this.labPlayer.TabIndex = 16;
            this.labPlayer.Text = "Spēlētājs";
            this.labPlayer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labComputerScore
            // 
            this.labComputerScore.AutoSize = true;
            this.labComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labComputerScore.Location = new System.Drawing.Point(667, 276);
            this.labComputerScore.Name = "labComputerScore";
            this.labComputerScore.Size = new System.Drawing.Size(69, 73);
            this.labComputerScore.TabIndex = 20;
            this.labComputerScore.Text = "0";
            // 
            // labPlayerScore
            // 
            this.labPlayerScore.AutoSize = true;
            this.labPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPlayerScore.Location = new System.Drawing.Point(12, 270);
            this.labPlayerScore.Name = "labPlayerScore";
            this.labPlayerScore.Size = new System.Drawing.Size(69, 73);
            this.labPlayerScore.TabIndex = 18;
            this.labPlayerScore.Text = "0";
            // 
            // picBoxComputer
            // 
            this.picBoxComputer.Location = new System.Drawing.Point(675, 110);
            this.picBoxComputer.Name = "picBoxComputer";
            this.picBoxComputer.Size = new System.Drawing.Size(200, 150);
            this.picBoxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxComputer.TabIndex = 8;
            this.picBoxComputer.TabStop = false;
            // 
            // picBoxPlayer
            // 
            this.picBoxPlayer.Location = new System.Drawing.Point(10, 110);
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.Size = new System.Drawing.Size(200, 150);
            this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayer.TabIndex = 7;
            this.picBoxPlayer.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.labComputerScore);
            this.Controls.Add(this.labPlayerScore);
            this.Controls.Add(this.labComputer);
            this.Controls.Add(this.labPlayer);
            this.Controls.Add(this.labWinner);
            this.Controls.Add(this.butPaper);
            this.Controls.Add(this.butScissors);
            this.Controls.Add(this.butRock);
            this.Controls.Add(this.picBoxComputer);
            this.Controls.Add(this.picBoxPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form2";
            this.Text = "AkmensŠķēresPapirīts";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxComputer;
        private System.Windows.Forms.PictureBox picBoxPlayer;
        private System.Windows.Forms.Button butRock;
        private System.Windows.Forms.Button butScissors;
        private System.Windows.Forms.Button butPaper;
        private System.Windows.Forms.Label labWinner;
        private System.Windows.Forms.Label labComputer;
        private System.Windows.Forms.Label labPlayer;
        private System.Windows.Forms.Label labComputerScore;
        private System.Windows.Forms.Label labPlayerScore;
    }
}