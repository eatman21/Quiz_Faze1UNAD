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
    public partial class Final_Part : Form
    {

        int puntosTraidos;
        
        public Final_Part(int puntosTraidos)
        {
            InitializeComponent();

            this.puntosTraidos = puntosTraidos;
            Point_Result.Text = puntosTraidos.ToString();
        }

        private void Final_Part_Load(object sender, EventArgs e)
        {
            //No necesito este metodo
        }
    }
}
