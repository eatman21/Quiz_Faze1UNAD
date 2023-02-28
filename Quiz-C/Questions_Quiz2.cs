using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_C
{
    public partial class Questions_Quiz2 : Form
    {
        int puntosTraidos;
        public Questions_Quiz2(int puntosTraidos)
        {
            InitializeComponent();
            this.puntosTraidos = puntosTraidos;
            Point_Result.Text = puntosTraidos.ToString();
        }
        #region Funtion Quiz Part 1

        void Correct_Answer()
        {
            Correct_Answer correctAnswer = new Correct_Answer();
            correctAnswer.ShowDialog();
            SumarPuntos();

        }

        void Incorrect_Answer()
        {
            Incorrect_Answer IncorrectAnswer = new Incorrect_Answer();
            IncorrectAnswer.ShowDialog();
            RestarPuntos();


        }

        void SumarPuntos()
        {
            if (puntosTraidos == 1000)
            {
                MessageBox.Show("No puedes seguir sumando los puntos.");
                Point_Result.Text = puntosTraidos.ToString();
            }
            else
            {
                puntosTraidos = puntosTraidos + 500;
                Point_Result.Text = puntosTraidos.ToString();
                Final_Part final = new Final_Part(puntosTraidos);
                final.Show();
                this.Close();

                if (puntosTraidos > 1000)
                {
                    puntosTraidos = -500;
                    MessageBox.Show("No puedes seguir sumando los puntos.");
                }
                
            }
            

        }

        void RestarPuntos()
        {
            if (puntosTraidos >= 200)
                puntosTraidos = puntosTraidos - 100;
            Point_Result.Text = puntosTraidos.ToString();

        }



        #endregion

        #region Question Quiz 2
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Q_Quiz2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Answer1_Click(object sender, EventArgs e)
        {
            Correct_Answer();
            
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            Incorrect_Answer();
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            Incorrect_Answer();
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            Incorrect_Answer();
            
        }


        #endregion

        private void Questions_Quiz2_Load(object sender, EventArgs e)
        {

        }
    }
}
