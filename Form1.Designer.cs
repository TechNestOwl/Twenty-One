namespace Twenty_One
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rollTwoDice = new Button();
            rollOneDie = new Button();
            hitCount = new Label();
            label2 = new Label();
            ExitBtn = new Button();
            PlayAgainBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // rollTwoDice
            // 
            rollTwoDice.Location = new Point(281, 78);
            rollTwoDice.Name = "rollTwoDice";
            rollTwoDice.Size = new Size(83, 25);
            rollTwoDice.TabIndex = 0;
            rollTwoDice.Text = "Roll 2 Dice";
            rollTwoDice.UseVisualStyleBackColor = true;
            rollTwoDice.Click += rollTwoDice_Click_1;
            // 
            // rollOneDie
            // 
            rollOneDie.Location = new Point(477, 78);
            rollOneDie.Name = "rollOneDie";
            rollOneDie.Size = new Size(83, 25);
            rollOneDie.TabIndex = 1;
            rollOneDie.Text = "Roll One Die";
            rollOneDie.UseVisualStyleBackColor = true;
            rollOneDie.Click += rollOneDie_Click_1;
            // 
            // hitCount
            // 
            hitCount.AutoSize = true;
            hitCount.Location = new Point(412, 26);
            hitCount.Name = "hitCount";
            hitCount.Size = new Size(27, 17);
            hitCount.TabIndex = 2;
            hitCount.Text = "Hit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(463, 26);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 3;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(477, 361);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(83, 25);
            ExitBtn.TabIndex = 6;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // PlayAgainBtn
            // 
            PlayAgainBtn.Location = new Point(281, 361);
            PlayAgainBtn.Name = "PlayAgainBtn";
            PlayAgainBtn.Size = new Size(83, 25);
            PlayAgainBtn.TabIndex = 7;
            PlayAgainBtn.Text = "Play Again";
            PlayAgainBtn.UseVisualStyleBackColor = true;
            PlayAgainBtn.Click += PlayAgainBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(477, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 55);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(281, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 55);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 615);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(PlayAgainBtn);
            Controls.Add(ExitBtn);
            Controls.Add(label2);
            Controls.Add(hitCount);
            Controls.Add(rollOneDie);
            Controls.Add(rollTwoDice);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rollTwoDice;
        private Button rollOneDie;
        private Label hitCount;
        private Label label2;
        private Button ExitBtn;
        private Button PlayAgainBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
