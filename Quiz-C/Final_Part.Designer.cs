namespace Quiz_C
{
    partial class Final_Part
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbPuntosQuiz = new System.Windows.Forms.Label();
            this.Point_Result = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Point_Result);
            this.panel1.Controls.Add(this.LbPuntosQuiz);
            this.panel1.Location = new System.Drawing.Point(68, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 361);
            this.panel1.TabIndex = 0;
            // 
            // LbPuntosQuiz
            // 
            this.LbPuntosQuiz.AutoSize = true;
            this.LbPuntosQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPuntosQuiz.Location = new System.Drawing.Point(61, 334);
            this.LbPuntosQuiz.Name = "LbPuntosQuiz";
            this.LbPuntosQuiz.Size = new System.Drawing.Size(240, 17);
            this.LbPuntosQuiz.TabIndex = 6;
            this.LbPuntosQuiz.Text = "puntos obtenidos por el jugador";
            // 
            // Point_Result
            // 
            this.Point_Result.AutoSize = true;
            this.Point_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point_Result.Location = new System.Drawing.Point(334, 334);
            this.Point_Result.Name = "Point_Result";
            this.Point_Result.Size = new System.Drawing.Size(17, 17);
            this.Point_Result.TabIndex = 7;
            this.Point_Result.Text = "0";
            // 
            // Final_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Final_Part";
            this.Text = "Final_Part";
            this.Load += new System.EventHandler(this.Final_Part_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbPuntosQuiz;
        private System.Windows.Forms.Label Point_Result;
    }
}