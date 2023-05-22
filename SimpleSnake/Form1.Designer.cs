namespace SimpleSnake
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
            components = new System.ComponentModel.Container();
            pbCanvas = new PictureBox();
            label1 = new Label();
            lblScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            lblGameOver = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCanvas).BeginInit();
            SuspendLayout();
            // 
            // pbCanvas
            // 
            pbCanvas.Location = new Point(28, 28);
            pbCanvas.Name = "pbCanvas";
            pbCanvas.Size = new Size(549, 443);
            pbCanvas.TabIndex = 0;
            pbCanvas.TabStop = false;
            pbCanvas.Paint += pbCanvas_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(689, 28);
            label1.Name = "label1";
            label1.Size = new Size(106, 45);
            label1.TabIndex = 1;
            label1.Text = "Score:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(857, 28);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 45);
            lblScore.TabIndex = 2;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameOver.Location = new Point(96, 68);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(105, 45);
            lblGameOver.TabIndex = 3;
            lblGameOver.Text = "label2";
            lblGameOver.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 664);
            Controls.Add(lblGameOver);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Controls.Add(pbCanvas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pbCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCanvas;
        private Label label1;
        private Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private Label lblGameOver;
    }
}