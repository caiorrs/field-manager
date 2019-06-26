using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormVersion
{
    public partial class Simulador : Form
    {
        public Simulador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main_();
        }

        public void main_()
        {
            Natureza.Grama.Instance.altura = 10;
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            float value = this.trackBar1.Value;
            Natureza.Grama.Instance.altura = value;
            this.textBox1.Text = value.ToString();           
        }

        private void UmidadeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Natureza.Grama.Instance.umidade = this.umidadeTrackBar.Value;
        }

    }
}
