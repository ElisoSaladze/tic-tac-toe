namespace tic_tac_toe
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
            play = new Button();
            gamePanel = new Panel();
            finishPanel = new Panel();
            finishLabel = new TextBox();
            playAgain = new Button();
            label1 = new Label();
            button10 = new Button();
            table = new TableLayoutPanel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            gamePanel.SuspendLayout();
            finishPanel.SuspendLayout();
            table.SuspendLayout();
            SuspendLayout();
            // 
            // play
            // 
            play.BackColor = Color.FromArgb(75, 73, 95);
            play.FlatStyle = FlatStyle.Flat;
            play.Font = new Font("Segoe UI", 15F);
            play.ForeColor = Color.FromArgb(233, 157, 143);
            play.Location = new Point(125, 240);
            play.Name = "play";
            play.Size = new Size(156, 49);
            play.TabIndex = 6;
            play.Text = "Play";
            play.UseVisualStyleBackColor = false;
            play.Click += play_Click;
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(finishPanel);
            gamePanel.Controls.Add(button10);
            gamePanel.Controls.Add(table);
            gamePanel.Location = new Point(3, 0);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(392, 456);
            gamePanel.TabIndex = 7;
            gamePanel.Visible = false;
            // 
            // finishPanel
            // 
            finishPanel.Controls.Add(finishLabel);
            finishPanel.Controls.Add(playAgain);
            finishPanel.Controls.Add(label1);
            finishPanel.Location = new Point(62, 104);
            finishPanel.Name = "finishPanel";
            finishPanel.Size = new Size(249, 204);
            finishPanel.TabIndex = 2;
            finishPanel.Visible = false;
            finishPanel.Paint += finishPanel_Paint;
            // 
            // finishLabel
            // 
            finishLabel.BackColor = Color.FromArgb(31, 31, 47);
            finishLabel.BorderStyle = BorderStyle.None;
            finishLabel.Font = new Font("Segoe UI", 12F);
            finishLabel.ForeColor = Color.FromArgb(222, 126, 159);
            finishLabel.Location = new Point(42, 44);
            finishLabel.Name = "finishLabel";
            finishLabel.ReadOnly = true;
            finishLabel.Size = new Size(167, 27);
            finishLabel.TabIndex = 3;
            finishLabel.TextAlign = HorizontalAlignment.Center;
            // 
            // playAgain
            // 
            playAgain.BackColor = Color.FromArgb(222, 126, 159);
            playAgain.FlatStyle = FlatStyle.Popup;
            playAgain.ForeColor = Color.White;
            playAgain.Location = new Point(66, 128);
            playAgain.Name = "playAgain";
            playAgain.Size = new Size(111, 41);
            playAgain.TabIndex = 2;
            playAgain.Text = "play again";
            playAgain.UseVisualStyleBackColor = false;
            playAgain.Click += playAgain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(101, 74);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(222, 126, 159);
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Segoe UI", 9F);
            button10.ForeColor = Color.White;
            button10.Location = new Point(151, 372);
            button10.Name = "button10";
            button10.Size = new Size(84, 36);
            button10.TabIndex = 1;
            button10.Text = "Reset";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // table
            // 
            table.ColumnCount = 3;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table.Controls.Add(button9, 2, 2);
            table.Controls.Add(button8, 1, 2);
            table.Controls.Add(button7, 0, 2);
            table.Controls.Add(button6, 2, 1);
            table.Controls.Add(button5, 1, 1);
            table.Controls.Add(button3, 2, 0);
            table.Controls.Add(button4, 0, 1);
            table.Controls.Add(button1, 0, 0);
            table.Controls.Add(button2, 1, 0);
            table.Location = new Point(40, 41);
            table.Name = "table";
            table.RowCount = 3;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            table.Size = new Size(305, 286);
            table.TabIndex = 0;
            table.Paint += table_Paint;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(75, 73, 95);
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe UI", 20F);
            button9.ForeColor = Color.White;
            button9.Location = new Point(205, 193);
            button9.Name = "button9";
            button9.Size = new Size(91, 87);
            button9.TabIndex = 8;
            button9.Tag = "2, 2";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(75, 73, 95);
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI", 20F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(104, 193);
            button8.Name = "button8";
            button8.Size = new Size(91, 87);
            button8.TabIndex = 7;
            button8.Tag = "2, 1";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(75, 73, 95);
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 20F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(3, 193);
            button7.Name = "button7";
            button7.Size = new Size(91, 87);
            button7.TabIndex = 6;
            button7.Tag = "2, 0";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(75, 73, 95);
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 20F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(205, 98);
            button6.Name = "button6";
            button6.Size = new Size(91, 87);
            button6.TabIndex = 5;
            button6.Tag = "1, 2";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(75, 73, 95);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 20F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(104, 98);
            button5.Name = "button5";
            button5.Size = new Size(91, 87);
            button5.TabIndex = 4;
            button5.Tag = "1, 1";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(75, 73, 95);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 20F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(205, 3);
            button3.Name = "button3";
            button3.Size = new Size(91, 87);
            button3.TabIndex = 2;
            button3.Tag = "0, 2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(75, 73, 95);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 20F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 98);
            button4.Name = "button4";
            button4.Size = new Size(91, 87);
            button4.TabIndex = 3;
            button4.Tag = "1, 0";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(75, 73, 95);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 20F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(91, 87);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Tag = "0, 0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(75, 73, 95);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 20F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(104, 3);
            button2.Name = "button2";
            button2.Size = new Size(91, 87);
            button2.TabIndex = 1;
            button2.Tag = "0, 1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.FromArgb(239, 146, 127);
            label2.Location = new Point(112, 146);
            label2.Name = "label2";
            label2.Size = new Size(180, 46);
            label2.TabIndex = 9;
            label2.Text = "Tic Tac Toe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 47);
            ClientSize = new Size(392, 453);
            Controls.Add(label2);
            Controls.Add(gamePanel);
            Controls.Add(play);
            MaximumSize = new Size(410, 500);
            MinimumSize = new Size(410, 500);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gamePanel.ResumeLayout(false);
            finishPanel.ResumeLayout(false);
            finishPanel.PerformLayout();
            table.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button play;
        private Panel gamePanel;
        private TableLayoutPanel table;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button10;
        private Panel finishPanel;
        private Button playAgain;
        private Label label1;
        private TextBox finishLabel;
        private Label label2;
    }
}
