using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_C
{
    public partial class Questions_Quiz : Form
    {
      
        public Questions_Quiz()
        {
            InitializeComponent();
           
        }

        public int pointsQuestions;

        public Questions_Quiz( int puntos)
        {
            this.pointsQuestions = puntos;
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
            this.pointsQuestions = +500;
            Point_Result.Text = pointsQuestions.ToString();
            
            this.Close();
        }

        void RestarPuntos()
        {
            if (pointsQuestions > 500)
            pointsQuestions = pointsQuestions - 100;
            Point_Result.Text = pointsQuestions.ToString();

        }
        #endregion


        #region Funtions

        private void Quiz_Q1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LbPuntosQuiz_Click(object sender, EventArgs e)
        {

        }

        private void Point_Result_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Questions

        private void Answer1_Click(object sender, EventArgs e)
        {
            Incorrect_Answer();
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            Incorrect_Answer();
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            Correct_Answer();
            Questions_Quiz2 pasarDato = new Questions_Quiz2(pointsQuestions);
            pasarDato.Show();
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            Incorrect_Answer();
            
        }

        #endregion
    }
}
