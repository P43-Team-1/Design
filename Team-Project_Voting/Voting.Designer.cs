namespace Team_Project_Voting
{
    partial class Voting
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
            panel1 = new Panel();
            Statistic = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(9, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 258);
            panel1.TabIndex = 0;
            // 
            // Statistic
            // 
            Statistic.AutoSize = true;
            Statistic.Cursor = Cursors.Hand;
            Statistic.Location = new Point(9, 274);
            Statistic.Name = "Statistic";
            Statistic.Size = new Size(174, 20);
            Statistic.TabIndex = 1;
            Statistic.Text = "Переглянути статистику";
            // 
            // Voting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 303);
            Controls.Add(Statistic);
            Controls.Add(panel1);
            Name = "Voting";
            Text = "Voting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Statistic;
    }
}