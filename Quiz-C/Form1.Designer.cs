namespace Quiz_C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Front_Page_Quiz = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Description_lb = new System.Windows.Forms.Label();
            this.Front_Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Front_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Front_Page_Quiz
            // 
            this.Front_Page_Quiz.AutoSize = true;
            this.Front_Page_Quiz.BackColor = System.Drawing.SystemColors.Control;
            this.Front_Page_Quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Front_Page_Quiz.Location = new System.Drawing.Point(297, 9);
            this.Front_Page_Quiz.Name = "Front_Page_Quiz";
            this.Front_Page_Quiz.Size = new System.Drawing.Size(368, 31);
            this.Front_Page_Quiz.TabIndex = 1;
            this.Front_Page_Quiz.Text = "Welcome to the Quiz Game";
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Close.Location = new System.Drawing.Point(937, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(29, 20);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Description_lb
            // 
            this.Description_lb.AutoSize = true;
            this.Description_lb.BackColor = System.Drawing.SystemColors.Control;
            this.Description_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lb.Location = new System.Drawing.Point(352, 87);
            this.Description_lb.Name = "Description_lb";
            this.Description_lb.Size = new System.Drawing.Size(269, 31);
            this.Description_lb.TabIndex = 3;
            this.Description_lb.Text = "Cultural Quiz Game";
            this.Description_lb.Click += new System.EventHandler(this.Description_lb_Click);
            // 
            // Front_Panel
            // 
            this.Front_Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Front_Panel.Controls.Add(this.label2);
            this.Front_Panel.Controls.Add(this.label1);
            this.Front_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Front_Panel.Location = new System.Drawing.Point(0, 463);
            this.Front_Panel.Name = "Front_Panel";
            this.Front_Panel.Size = new System.Drawing.Size(963, 55);
            this.Front_Panel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(673, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Presented to Felipe Ortiz Rojas ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Carol Pusey";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(432, 252);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(151, 62);
            this.Btn_Start.TabIndex = 5;
            this.Btn_Start.Text = "Start Game";
            this.Btn_Start.UseVisualStyleBackColor = false;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(963, 518);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Front_Panel);
            this.Controls.Add(this.Description_lb);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Front_Page_Quiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz-c-Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Front_Panel.ResumeLayout(false);
            this.Front_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Front_Page_Quiz;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Description_lb;
        private System.Windows.Forms.Panel Front_Panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Start;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

