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
        }

        private void UpdateTrackBar(TrackBar tb, int value)
        {
            if (tb.InvokeRequired)
            {
                tb.BeginInvoke((MethodInvoker)delegate () { tb.Value = value; });
            }
            else
            {
                tb.Value = value;
            }
        }
        private void UpdateLabel(Label lb, string value)
        {
            if (lb.InvokeRequired)
            {
                lb.BeginInvoke((MethodInvoker)delegate () { lb.Text = value; });
            }
            else
            {
                lb.Text = value;
            }
        }
        private void UpdateTextBox(TextBox tbx, string value)
        {
            if (tbx.InvokeRequired)
            {
                tbx.BeginInvoke((MethodInvoker)delegate () { tbx.Text = value; });
            }
            else
            {
                tbx.Text = value;
            }
        }
        private void UpdateCheckBox(CheckBox cbx, bool value)
        {
            if (cbx.InvokeRequired)
            {
                cbx.BeginInvoke((MethodInvoker)delegate () { cbx.Checked = value; });
            }
            else
            {
                cbx.Checked = value;
            }
        }

        public void UpdateGramaSize(float size)
        {
            UpdateTrackBar(trackBar1, (int)Math.Floor(size));
            UpdateTextBox(textBox1, size.ToString());
        }

        public void UpdateUmidade(float umi)
        {
            UpdateTrackBar(umidadeTrackBar, (int)Math.Floor(umi));
            UpdateTextBox(textBox2, umi.ToString());
        }

        public void SetChovendo(bool value)
        {
            UpdateCheckBox(checkBox1, value);
        }

        public void UpdateTempo(string text)
        {
            UpdateLabel(label3, text);
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Natureza.Clima.Instance.setChovendo(checkBox1.Checked);
        }
    }
}
