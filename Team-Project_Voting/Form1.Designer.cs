namespace Team_Project_Voting
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
            Setting = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Voting = new GroupBox();
            label2 = new Label();
            Voting.SuspendLayout();
            SuspendLayout();
            // 
            // Setting
            // 
            Setting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Setting.Location = new Point(472, 330);
            Setting.Name = "Setting";
            Setting.Size = new Size(124, 28);
            Setting.TabIndex = 0;
            Setting.Text = "Налаштування";
            Setting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 70);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 1;
            label1.Text = "Активні голосування";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(50, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(516, 162);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Voting
            // 
            Voting.Controls.Add(label2);
            Voting.Location = new Point(12, 12);
            Voting.Name = "Voting";
            Voting.Size = new Size(584, 46);
            Voting.TabIndex = 3;
            Voting.TabStop = false;
            Voting.Text = "Голосування";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 17);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 0;
            label2.Text = "Ім'я користувача";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 370);
            Controls.Add(Voting);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(Setting);
            Name = "Form1";
            Text = "Form1";
            Voting.ResumeLayout(false);
            Voting.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Setting;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox Voting;
        private Label label2;
    }
}
