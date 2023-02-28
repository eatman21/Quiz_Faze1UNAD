namespace Quiz_C
{
    partial class Questions_Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions_Quiz));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Quiz_Q1 = new System.Windows.Forms.Panel();
            this.Question_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Answer1 = new System.Windows.Forms.Button();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.Button();
            this.LbPuntosQuiz = new System.Windows.Forms.Label();
            this.Point_Result = new System.Windows.Forms.Label();
            this.Quiz_Q1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(808, 2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(31, 23);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Answer2
            // 
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2.Location = new System.Drawing.Point(249, 385);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(143, 23);
            this.Answer2.TabIndex = 1;
            this.Answer2.Text = "Bandeja Paisa";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.Click += new System.EventHandler(this.Answer2_Click);
            // 
            // Quiz_Q1
            // 
            this.Quiz_Q1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quiz_Q1.BackgroundImage")));
            this.Quiz_Q1.Controls.Add(this.Answer4);
            this.Quiz_Q1.Controls.Add(this.Answer3);
            this.Quiz_Q1.Controls.Add(this.Answer1);
            this.Quiz_Q1.Controls.Add(this.pictureBox1);
            this.Quiz_Q1.Controls.Add(this.Answer2);
            this.Quiz_Q1.Controls.Add(this.Question_1);
            this.Quiz_Q1.Location = new System.Drawing.Point(12, 12);
            this.Quiz_Q1.Name = "Quiz_Q1";
            this.Quiz_Q1.Size = new System.Drawing.Size(778, 429);
            this.Quiz_Q1.TabIndex = 2;
            this.Quiz_Q1.Paint += new System.Windows.Forms.PaintEventHandler(this.Quiz_Q1_Paint);
            // 
            // Question_1
            // 
            this.Question_1.AutoSize = true;
            this.Question_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question_1.Location = new System.Drawing.Point(186, 12);
            this.Question_1.Name = "Question_1";
            this.Question_1.Size = new System.Drawing.Size(389, 24);
            this.Question_1.TabIndex = 0;
            this.Question_1.Text = "¿cual es la comida tipica de san andres?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Answer1
            // 
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1.Location = new System.Drawing.Point(58, 385);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(143, 23);
            this.Answer1.TabIndex = 2;
            this.Answer1.Text = "Pescado Frito";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // Answer3
            // 
            this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer3.Location = new System.Drawing.Point(432, 385);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(143, 23);
            this.Answer3.TabIndex = 3;
            this.Answer3.Text = "El Rondón";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // Answer4
            // 
            this.Answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer4.Location = new System.Drawing.Point(621, 385);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(143, 23);
            this.Answer4.TabIndex = 4;
            this.Answer4.Text = "El Sancocho";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Click += new System.EventHandler(this.Answer4_Click);
            // 
            // LbPuntosQuiz
            // 
            this.LbPuntosQuiz.AutoSize = true;
            this.LbPuntosQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPuntosQuiz.Location = new System.Drawing.Point(168, 453);
            this.LbPuntosQuiz.Name = "LbPuntosQuiz";
            this.LbPuntosQuiz.Size = new System.Drawing.Size(240, 17);
            this.LbPuntosQuiz.TabIndex = 3;
            this.LbPuntosQuiz.Text = "puntos obtenidos por el jugador";
            this.LbPuntosQuiz.Click += new System.EventHandler(this.LbPuntosQuiz_Click);
            // 
            // Point_Result
            // 
            this.Point_Result.AutoSize = true;
            this.Point_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point_Result.Location = new System.Drawing.Point(426, 453);
            this.Point_Result.Name = "Point_Result";
            this.Point_Result.Size = new System.Drawing.Size(17, 17);
            this.Point_Result.TabIndex = 4;
            this.Point_Result.Text = "0";
            this.Point_Result.Click += new System.EventHandler(this.Point_Result_Click);
            // 
            // Questions_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 478);
            this.Controls.Add(this.Point_Result);
            this.Controls.Add(this.LbPuntosQuiz);
            this.Controls.Add(this.Quiz_Q1);
            this.Controls.Add(this.Btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Questions_Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions_Quiz";
            this.Quiz_Q1.ResumeLayout(false);
            this.Quiz_Q1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label Point_Result;
        private System.Windows.Forms.Label LbPuntosQuiz;
        private System.Windows.Forms.Panel Quiz_Q1;
        private System.Windows.Forms.Button Answer4;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Label Question_1;
        private System.Windows.Forms.Button Btn_Close;
    }
}