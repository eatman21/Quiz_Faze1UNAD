namespace Quiz_C
{
    partial class Incorrect_Answer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incorrect_Answer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Btn_Close_Inco = new System.Windows.Forms.Button();
            this.Incorrect_Ans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Btn_Close_Inco
            // 
            this.Btn_Close_Inco.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Close_Inco.FlatAppearance.BorderSize = 0;
            this.Btn_Close_Inco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close_Inco.Location = new System.Drawing.Point(484, 3);
            this.Btn_Close_Inco.Name = "Btn_Close_Inco";
            this.Btn_Close_Inco.Size = new System.Drawing.Size(23, 20);
            this.Btn_Close_Inco.TabIndex = 1;
            this.Btn_Close_Inco.Text = "X";
            this.Btn_Close_Inco.UseVisualStyleBackColor = false;
            this.Btn_Close_Inco.Click += new System.EventHandler(this.Btn_Close_Inco_Click);
            // 
            // Incorrect_Ans
            // 
            this.Incorrect_Ans.AutoSize = true;
            this.Incorrect_Ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Incorrect_Ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incorrect_Ans.Location = new System.Drawing.Point(154, 9);
            this.Incorrect_Ans.Name = "Incorrect_Ans";
            this.Incorrect_Ans.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Incorrect_Ans.Size = new System.Drawing.Size(211, 31);
            this.Incorrect_Ans.TabIndex = 2;
            this.Incorrect_Ans.Text = " Wrang Answer";
            this.Incorrect_Ans.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Incorrect_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(519, 387);
            this.Controls.Add(this.Incorrect_Ans);
            this.Controls.Add(this.Btn_Close_Inco);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Incorrect_Answer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incorrect_Answer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button Btn_Close_Inco;
        private System.Windows.Forms.Label Incorrect_Ans;
    }
}