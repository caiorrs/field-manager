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
    public partial class Configuracoes : Form
    {
        private int umidadeMinima = 0;
        private int alturaCorte = 0;
        private int umidadeIdeal = 0;

        public void setUmidadeIdeal(int valor)
        {
            umidadeIdeal = valor;
        }

        public int getUmidadeIdeal()
        {
            return umidadeIdeal;
        }
        
        public void setUmidadeMinima(int valor)
        {
            umidadeMinima = valor;
        }
        public int getUmidadeMinima()
        {
            return umidadeMinima;
        }
        public void setAlturaCorte(int valor)
        {
            alturaCorte = valor;
        }
        public int getAlturaCorte()
        {
            return alturaCorte;
        }

        public Configuracoes()
        {
            InitializeComponent();
        }

        private void ValorUmidadeMin_Click(object sender, EventArgs e)
        {

        }

        private void UmidadeMinConf_Scroll(object sender, EventArgs e)
        {
            float value = umidadeMinConf.Value;
            valorUmidadeMin.Text = value.ToString();
        }

        private void ValorAlturaCorte_Click(object sender, EventArgs e)
        {
        }

        private void AlturaCorteConf_Scroll(object sender, EventArgs e)
        {
            float value = alturaCorteConf.Value;
            valorAlturaCorte.Text = value.ToString();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            alturaCorte = alturaCorteConf.Value;
            umidadeMinima =  umidadeMinConf.Value;
            umidadeIdeal = trackBar1.Value;
            Close();
        }

        private void Configuracoes_Load(object sender, EventArgs e)
        {

        }

        private void Configuracoes_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Configuracoes_Shown(object sender, EventArgs e)
        {
            alturaCorteConf.Value = alturaCorte;
            umidadeMinConf.Value = umidadeMinima;
            trackBar1.Value = umidadeIdeal;
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
