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
    public partial class Correct_Answer : Form
    {
        public Correct_Answer()
        {
            InitializeComponent();
            reproducirSonido();
        }

        private void Btn_Close_Corr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string rutaAudio = "C:/Sound_Trivia/correcto.wav";

        private void reproducirSonido()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = rutaAudio;
            player.Play();
        }
    }
}
