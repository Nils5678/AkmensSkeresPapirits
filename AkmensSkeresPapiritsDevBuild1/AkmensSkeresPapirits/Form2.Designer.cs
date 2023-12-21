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
            this.labScore = new System.Windows.Forms.Label();
            this.labComputer = new System.Windows.Forms.Label();
            this.labPlayer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butRock = new System.Windows.Forms.Button();
            this.butScissors = new System.Windows.Forms.Button();
            this.butPaper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labScore.Location = new System.Drawing.Point(380, 150);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(125, 73);
            this.labScore.TabIndex = 11;
            this.labScore.Text = "0:0";
            // 
            // labComputer
            // 
            this.labComputer.AutoSize = true;
            this.labComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labComputer.Location = new System.Drawing.Point(730, 80);
            this.labComputer.Name = "labComputer";
            this.labComputer.Size = new System.Drawing.Size(81, 25);
            this.labComputer.TabIndex = 10;
            this.labComputer.Text = "Dators";
            // 
            // labPlayer
            // 
            this.labPlayer.AutoSize = true;
            this.labPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPlayer.Location = new System.Drawing.Point(60, 80);
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Size = new System.Drawing.Size(95, 24);
            this.labPlayer.TabIndex = 9;
            this.labPlayer.Text = "Spēlētājs";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(675, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 150);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(385, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Piemērs";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butPaper);
            this.Controls.Add(this.butScissors);
            this.Controls.Add(this.butRock);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.labComputer);
            this.Controls.Add(this.labPlayer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form2";
            this.Text = "AkmensŠķēresPapirīts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labComputer;
        private System.Windows.Forms.Label labPlayer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butRock;
        private System.Windows.Forms.Button butScissors;
        private System.Windows.Forms.Button butPaper;
        private System.Windows.Forms.Label label1;
    }
}