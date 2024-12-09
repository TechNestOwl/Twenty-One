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
            SuspendLayout();
            // 
            // rollTwoDice
            // 
            rollTwoDice.Location = new Point(477, 79);
            rollTwoDice.Name = "rollTwoDice";
            rollTwoDice.Size = new Size(83, 25);
            rollTwoDice.TabIndex = 0;
            rollTwoDice.Text = "Roll 2 Dice";
            rollTwoDice.UseVisualStyleBackColor = true;
            // 
            // rollOneDie
            // 
            rollOneDie.Location = new Point(281, 79);
            rollOneDie.Name = "rollOneDie";
            rollOneDie.Size = new Size(83, 25);
            rollOneDie.TabIndex = 1;
            rollOneDie.Text = "Roll One Die";
            rollOneDie.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 615);
            Controls.Add(label2);
            Controls.Add(hitCount);
            Controls.Add(rollOneDie);
            Controls.Add(rollTwoDice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rollTwoDice;
        private Button rollOneDie;
        private Label hitCount;
        private Label label2;
    }
}
