namespace pinnponn
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
            this.components = new System.ComponentModel.Container();
            this.titleButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.PR = new System.Windows.Forms.Label();
            this.Tama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleButton
            // 
            this.titleButton.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleButton.Location = new System.Drawing.Point(291, 257);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(210, 134);
            this.titleButton.TabIndex = 9;
            this.titleButton.Text = "タイトルへ";
            this.titleButton.UseVisualStyleBackColor = true;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(319, 414);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(169, 15);
            this.copyrightLabel.TabIndex = 10;
            this.copyrightLabel.Text = "Copyright@ ２０２２　高橋涼";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Yu Gothic UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearLabel.ForeColor = System.Drawing.Color.Red;
            this.clearLabel.Location = new System.Drawing.Point(237, 131);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(319, 106);
            this.clearLabel.TabIndex = 11;
            this.clearLabel.Text = "CLEAR!!";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gameOverLabel.Location = new System.Drawing.Point(222, 148);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(352, 89);
            this.gameOverLabel.TabIndex = 12;
            this.gameOverLabel.Text = "GameOver";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(197, 72);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(392, 76);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "ピンポン2022";
            // 
            // PR
            // 
            this.PR.AutoSize = true;
            this.PR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PR.Location = new System.Drawing.Point(12, 159);
            this.PR.Name = "PR";
            this.PR.Size = new System.Drawing.Size(19, 120);
            this.PR.TabIndex = 14;
            this.PR.Text = "  \r\n  \r\n   \r\n  \r\n    \r\n  \r\n\r\n\r\n";
            this.PR.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tama
            // 
            this.Tama.AutoSize = true;
            this.Tama.BackColor = System.Drawing.Color.Gold;
            this.Tama.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tama.Location = new System.Drawing.Point(139, 177);
            this.Tama.Name = "Tama";
            this.Tama.Size = new System.Drawing.Size(38, 37);
            this.Tama.TabIndex = 15;
            this.Tama.Text = "   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(769, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 120);
            this.label1.TabIndex = 16;
            this.label1.Text = "  \r\n  \r\n   \r\n  \r\n    \r\n  \r\n\r\n\r\n";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkRed;
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(291, 257);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(210, 134);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "スタート！";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tama);
            this.Controls.Add(this.PR);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.titleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button titleButton;
        private Label copyrightLabel;
        private Label clearLabel;
        private Label gameOverLabel;
        private Label titleLabel;
        private Label PR;
        private Label Tama;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button startButton;
    }
}