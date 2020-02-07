namespace Pong
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
            this.components = new System.ComponentModel.Container();
            this.gameUpdateLoop = new System.Windows.Forms.Timer(this.components);
            this.startLabel = new System.Windows.Forms.Label();
            this.exclamationLabel = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameUpdateLoop
            // 
            this.gameUpdateLoop.Interval = 16;
            this.gameUpdateLoop.Tick += new System.EventHandler(this.gameUpdateLoop_Tick);
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(105, 114);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(410, 93);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Press Space To Start";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exclamationLabel
            // 
            this.exclamationLabel.AutoSize = true;
            this.exclamationLabel.ForeColor = System.Drawing.Color.Red;
            this.exclamationLabel.Location = new System.Drawing.Point(294, 235);
            this.exclamationLabel.Name = "exclamationLabel";
            this.exclamationLabel.Size = new System.Drawing.Size(0, 13);
            this.exclamationLabel.TabIndex = 1;
            // 
            // p2Score
            // 
            this.p2Score.AutoSize = true;
            this.p2Score.BackColor = System.Drawing.Color.Transparent;
            this.p2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Score.ForeColor = System.Drawing.Color.White;
            this.p2Score.Location = new System.Drawing.Point(498, 72);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(39, 42);
            this.p2Score.TabIndex = 2;
            this.p2Score.Text = "0";
            // 
            // p1Score
            // 
            this.p1Score.AutoSize = true;
            this.p1Score.BackColor = System.Drawing.Color.Transparent;
            this.p1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Score.ForeColor = System.Drawing.Color.White;
            this.p1Score.Location = new System.Drawing.Point(75, 67);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(39, 42);
            this.p1Score.TabIndex = 3;
            this.p1Score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.exclamationLabel);
            this.Controls.Add(this.startLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameUpdateLoop;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label exclamationLabel;
        private System.Windows.Forms.Label p2Score;
        private System.Windows.Forms.Label p1Score;
    }
}

