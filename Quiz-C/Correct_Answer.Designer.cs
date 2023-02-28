namespace Quiz_C
{
    partial class Correct_Answer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correct_Answer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Btn_Close_Corr = new System.Windows.Forms.Button();
            this.Right_Ans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Btn_Close_Corr
            // 
            this.Btn_Close_Corr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close_Corr.FlatAppearance.BorderSize = 0;
            this.Btn_Close_Corr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close_Corr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close_Corr.Location = new System.Drawing.Point(475, 4);
            this.Btn_Close_Corr.Name = "Btn_Close_Corr";
            this.Btn_Close_Corr.Size = new System.Drawing.Size(19, 21);
            this.Btn_Close_Corr.TabIndex = 1;
            this.Btn_Close_Corr.Text = "X";
            this.Btn_Close_Corr.UseVisualStyleBackColor = false;
            this.Btn_Close_Corr.Click += new System.EventHandler(this.Btn_Close_Corr_Click);
            // 
            // Right_Ans
            // 
            this.Right_Ans.AutoSize = true;
            this.Right_Ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right_Ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right_Ans.Location = new System.Drawing.Point(149, 9);
            this.Right_Ans.Name = "Right_Ans";
            this.Right_Ans.Size = new System.Drawing.Size(188, 31);
            this.Right_Ans.TabIndex = 2;
            this.Right_Ans.Text = "Right Answer";
            // 
            // Correct_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 354);
            this.Controls.Add(this.Right_Ans);
            this.Controls.Add(this.Btn_Close_Corr);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Correct_Answer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correct_Answer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button Btn_Close_Corr;
        private System.Windows.Forms.Label Right_Ans;
    }
}