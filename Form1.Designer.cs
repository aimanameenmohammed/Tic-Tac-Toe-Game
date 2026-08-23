namespace MyProjectGameH
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
            this.btnResetGame = new System.Windows.Forms.Button();
            this.lbinProgress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnButton9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnButton8 = new System.Windows.Forms.Button();
            this.btnButton2 = new System.Windows.Forms.Button();
            this.btnButton5 = new System.Windows.Forms.Button();
            this.btnButton3 = new System.Windows.Forms.Button();
            this.btnButton1 = new System.Windows.Forms.Button();
            this.btnButton4 = new System.Windows.Forms.Button();
            this.btnButton6 = new System.Windows.Forms.Button();
            this.btnButton7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetGame
            // 
            this.btnResetGame.BackColor = System.Drawing.Color.Black;
            this.btnResetGame.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.ForeColor = System.Drawing.Color.Transparent;
            this.btnResetGame.Location = new System.Drawing.Point(97, 539);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(261, 55);
            this.btnResetGame.TabIndex = 11;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // lbinProgress
            // 
            this.lbinProgress.AutoSize = true;
            this.lbinProgress.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbinProgress.Location = new System.Drawing.Point(102, 442);
            this.lbinProgress.Name = "lbinProgress";
            this.lbinProgress.Size = new System.Drawing.Size(256, 51);
            this.lbinProgress.TabIndex = 10;
            this.lbinProgress.Text = "In Progress";
            this.lbinProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(120, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 51);
            this.label4.TabIndex = 9;
            this.label4.Text = "Winner";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.ForeColor = System.Drawing.Color.White;
            this.lbPlayer.Location = new System.Drawing.Point(120, 269);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(183, 51);
            this.lbPlayer.TabIndex = 8;
            this.lbPlayer.Tag = "x";
            this.lbPlayer.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(134, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Turn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(613, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 77);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // btnButton9
            // 
            this.btnButton9.BackColor = System.Drawing.Color.Black;
            this.btnButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton9.ForeColor = System.Drawing.Color.Black;
            this.btnButton9.Image = global::MyProjectGameH.Properties.Resources.question_mark_96;
            this.btnButton9.Location = new System.Drawing.Point(1144, 591);
            this.btnButton9.Name = "btnButton9";
            this.btnButton9.Size = new System.Drawing.Size(141, 124);
            this.btnButton9.TabIndex = 13;
            this.btnButton9.Tag = "?";
            this.btnButton9.UseVisualStyleBackColor = false;
            this.btnButton9.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyProjectGameH.Properties.Resources.IMG_20260228_WA0089;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(95, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 77);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnButton8
            // 
            this.btnButton8.BackColor = System.Drawing.Color.Black;
            this.btnButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton8.ForeColor = System.Drawing.Color.Black;
            this.btnButton8.Image = global::MyProjectGameH.Properties.Resources.question_mark_96;
            this.btnButton8.Location = new System.Drawing.Point(876, 591);
            this.btnButton8.Name = "btnButton8";
            this.btnButton8.Size = new System.Drawing.Size(130, 122);
            this.btnButton8.TabIndex = 14;
            this.btnButton8.Tag = "?";
            this.btnButton8.UseVisualStyleBackColor = false;
            this.btnButton8.Click += new System.EventHandler(this.button_Click);
            // 
            // btnButton2
            // 
            this.btnButton2.BackColor = System.Drawing.Color.Black;
            this.btnButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton2.ForeColor = System.Drawing.Color.Black;
            this.btnButton2.Image = global::MyProjectGameH.Properties.Resources.question_mark_96;
            this.btnButton2.Location = new System.Drawing.Point(885, 208);
            this.btnButton2.Name = "btnButton2";
            this.btnButton2.Size = new System.Drawing.Size(128, 125);
            this.btnButton2.TabIndex = 15;
            this.btnButton2.Tag = "?";
            this.btnButton2.UseVisualStyleBackColor = false;
            this.btnButton2.Click += new System.EventHandler(this.button_Click);
            // 
            // btnButton5
            // 
            this.btnButton5.BackColor = System.Drawing.Color.Black;
            this.btnButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton5.ForeColor = System.Drawing.Color.Black;
            this.btnButton5.Image = global::MyProjectGameH.Properties.Resources.question_mark_96;
            this.btnButton5.Location = new System.Drawing.Point(885, 386);
            this.btnButton5.Name = "btnButton5";
            this.btnButton5.Size = new System.Drawing.Size(121, 127);
            this.btnButton5.TabIndex = 16;
            this.btnButton5.Tag = "?";
            this.btnButton5.UseVisualStyleBackColor = false;
            this.btnButton5.Click += new System.EventHandler(this.button_Click);
            // 
            // btnButton3
            // 
            this.btnButton3.BackColor = System.Drawing.Color.Black;
            this.btnButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton3.ForeColor = System.Drawing.Color.Black;
            this.btnButton3.Image = global::MyProjectGameH.Properties.Resources.question_mark_96;
            this.btnButton3.Location = new System.Drawing.Point(1157, 208);
            this.btnButton3.Name = "btnButton3";
            this.btnButton3.Size = new System.Drawing.Size(128, 112);
            this.btnButton3.TabIndex = 17;
            this.btnButton3.Tag = "?";
            this.btnButton3.UseVisualStyleBackColor = false;
            this.btnButton3.Click += new System.EventHandler(this.button_Click);
            // 
            // btnButton1
            // 
            this.btnButton1.BackColor = System.Drawing.Color.Black;
            this.btnButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton1.ForeColor = System.Drawing.Color.Black;
            this.btnButton1.Image = global::MyProjectGameH.Properties.Resources.question_mark_96;
            this.btnButton1.Location = new System.Drawing.Point(564, 208);
            this.btnButton1.Name = "btnButton1";
            this.btnButton1.Size = new System.Drawing.Size(135, 125);
            this.btnButton1.TabIndex = 18;
            this.btnButton1.Tag = "?";
            this.btnButton1.UseVisualStyleBackColor = false;
            this.btnButton1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnButton4
            // 
            this.btnButton4.BackColor = System.Drawing.Color.Black;
            this.btnButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton4.ForeColor = System.Drawing.Color.Black;
            this.btnButton4.Image = global::MyProjectGameH.Properties.Resources.question_mark_96;
            this.btnButton4.Location = new System.Drawing.Point(578, 386);
            this.btnButton4.Name = "btnButton4";
            this.btnButton4.Size = new System.Drawing.Size(121, 127);
            this.btnButton4.TabIndex = 19;
            this.btnButton4.Tag = "?";
            this.btnButton4.UseVisualStyleBackColor = false;
            this.btnButton4.Click += new System.EventHandler(this.button_Click);
            // 
            // btnButton6
            // 
            this.btnButton6.BackColor = System.Drawing.Color.Black;
            this.btnButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton6.ForeColor = System.Drawing.Color.Black;
            this.btnButton6.Image = global::MyProjectGameH.Properties.Resources.question_mark_96;
            this.btnButton6.Location = new System.Drawing.Point(1160, 401);
            this.btnButton6.Name = "btnButton6";
            this.btnButton6.Size = new System.Drawing.Size(125, 126);
            this.btnButton6.TabIndex = 20;
            this.btnButton6.Tag = "?";
            this.btnButton6.UseVisualStyleBackColor = false;
            this.btnButton6.Click += new System.EventHandler(this.button_Click);
            // 
            // btnButton7
            // 
            this.btnButton7.BackColor = System.Drawing.Color.Black;
            this.btnButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton7.ForeColor = System.Drawing.Color.Black;
            this.btnButton7.Image = global::MyProjectGameH.Properties.Resources.question_mark_96;
            this.btnButton7.Location = new System.Drawing.Point(564, 591);
            this.btnButton7.Name = "btnButton7";
            this.btnButton7.Size = new System.Drawing.Size(135, 124);
            this.btnButton7.TabIndex = 21;
            this.btnButton7.Tag = "?";
            this.btnButton7.UseVisualStyleBackColor = false;
            this.btnButton7.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MyProjectGameH.Properties.Resources.IMG_20260228_WA0090;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(26, 619);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(438, 145);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1504, 766);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnButton7);
            this.Controls.Add(this.btnButton6);
            this.Controls.Add(this.btnButton4);
            this.Controls.Add(this.btnButton1);
            this.Controls.Add(this.btnButton3);
            this.Controls.Add(this.btnButton5);
            this.Controls.Add(this.btnButton2);
            this.Controls.Add(this.btnButton8);
            this.Controls.Add(this.btnButton9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.lbinProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Label lbinProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnButton9;
        private System.Windows.Forms.Button btnButton8;
        private System.Windows.Forms.Button btnButton2;
        private System.Windows.Forms.Button btnButton5;
        private System.Windows.Forms.Button btnButton3;
        private System.Windows.Forms.Button btnButton1;
        private System.Windows.Forms.Button btnButton4;
        private System.Windows.Forms.Button btnButton6;
        private System.Windows.Forms.Button btnButton7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

