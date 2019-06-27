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
        public static Simulador Instance = null;
        public Simulador()
        {
            InitializeComponent();
            UpdateGramaSize(Natureza.Grama.Instance.altura);
            UpdateUmidade(Natureza.Grama.Instance.umidade);
            SetChovendo(Natureza.Clima.Instance.estaChovendo());
            UpdateTempo(Natureza.Tempo.Instance.Now.ToString());
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main_();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        public void main_()
        {
            Natureza.Grama.Instance.altura = 10;
        }

        public void UpdateGramaSize(float size)
        {
            trackBar1.Value = (int)Math.Floor(size);
            textBox1.Text = size.ToString();
        }

        public void UpdateUmidade(float umi)
        {
            umidadeTrackBar.Value = (int)Math.Floor(umi);
            textBox2.Text = umi.ToString();
        }

        public void SetChovendo(bool value)
        {
            checkBox1.Checked = value;
        }

        public void UpdateTempo(string text)
        {
            if (label3.InvokeRequired)
            {
                label3.BeginInvoke((MethodInvoker)delegate () { label3.Text = text; });
            }
            else
            {
                label3.Text = text; ;
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            float value = this.trackBar1.Value;
            if (Natureza.Grama.Instance.altura != value)
            {
                Natureza.Grama.Instance.altura = value;
            }
        }

        private void UmidadeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            float value = this.umidadeTrackBar.Value;
            if (Natureza.Grama.Instance.umidade != value)
            {
                Natureza.Grama.Instance.umidade = value;
            }
        }

        private void BtnConfigurar_Click(object sender, EventArgs e)
        {
            new WindowsFormVersion.Configuracoes().Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
