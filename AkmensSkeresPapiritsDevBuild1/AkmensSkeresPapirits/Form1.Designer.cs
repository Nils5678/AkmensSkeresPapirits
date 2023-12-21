namespace AkmensSkeresPapirits
{
    partial class Form1
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
            this.butStart = new System.Windows.Forms.Button();
            this.labPlayer = new System.Windows.Forms.Label();
            this.labComputer = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.butInfo = new System.Windows.Forms.Button();
            this.picboxComputer = new System.Windows.Forms.PictureBox();
            this.picboxPlayer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butStart.Location = new System.Drawing.Point(390, 500);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(100, 50);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Sākt";
            this.butStart.UseVisualStyleBackColor = true;
            // 
            // labPlayer
            // 
            this.labPlayer.AutoSize = true;
            this.labPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPlayer.Location = new System.Drawing.Point(60, 80);
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Size = new System.Drawing.Size(95, 24);
            this.labPlayer.TabIndex = 3;
            this.labPlayer.Text = "Spēlētājs";
            // 
            // labComputer
            // 
            this.labComputer.AutoSize = true;
            this.labComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labComputer.Location = new System.Drawing.Point(730, 80);
            this.labComputer.Name = "labComputer";
            this.labComputer.Size = new System.Drawing.Size(81, 25);
            this.labComputer.TabIndex = 4;
            this.labComputer.Text = "Dators";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labScore.Location = new System.Drawing.Point(380, 150);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(125, 73);
            this.labScore.TabIndex = 5;
            this.labScore.Text = "0:0";
            // 
            // butInfo
            // 
            this.butInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butInfo.Location = new System.Drawing.Point(755, 500);
            this.butInfo.Name = "butInfo";
            this.butInfo.Size = new System.Drawing.Size(120, 50);
            this.butInfo.TabIndex = 6;
            this.butInfo.Text = "Spēles Noteikumi";
            this.butInfo.UseVisualStyleBackColor = true;
            // 
            // picboxComputer
            // 
            this.picboxComputer.Image = global::AkmensSkeresPapirits.Properties.Resources.Custom_Question_mark2;
            this.picboxComputer.Location = new System.Drawing.Point(675, 110);
            this.picboxComputer.Name = "picboxComputer";
            this.picboxComputer.Size = new System.Drawing.Size(200, 150);
            this.picboxComputer.TabIndex = 2;
            this.picboxComputer.TabStop = false;
            // 
            // picboxPlayer
            // 
            this.picboxPlayer.Image = global::AkmensSkeresPapirits.Properties.Resources.Custom_Question_mark2;
            this.picboxPlayer.Location = new System.Drawing.Point(10, 110);
            this.picboxPlayer.Name = "picboxPlayer";
            this.picboxPlayer.Size = new System.Drawing.Size(200, 150);
            this.picboxPlayer.TabIndex = 1;
            this.picboxPlayer.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(10, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Autors";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butInfo);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.labComputer);
            this.Controls.Add(this.labPlayer);
            this.Controls.Add(this.picboxComputer);
            this.Controls.Add(this.picboxPlayer);
            this.Controls.Add(this.butStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "AkmensSķēresPapīrīts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.PictureBox picboxPlayer;
        private System.Windows.Forms.PictureBox picboxComputer;
        private System.Windows.Forms.Label labPlayer;
        private System.Windows.Forms.Label labComputer;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Button butInfo;
        private System.Windows.Forms.Button button1;
    }
}

