using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_C
{
    public partial class Incorrect_Answer : Form
    {
        public Incorrect_Answer()
        {
            InitializeComponent();
            reproducirSonido(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Close_Inco_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string rutaAudio = "C:/Sound_Trivia/incorrecto.wav";

        private void reproducirSonido()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = rutaAudio;
            player.Play();
        }
    }
}
