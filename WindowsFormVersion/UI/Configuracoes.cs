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
        private int umidadeMaxima = 0;
        private int alturaCorte = 0;
        private String cidade = "";
        private String tipoGrama = "";

        public void setUmidadeMinima(int valor)
        {
            umidadeMinima = valor;
        }
        public int getUmidadeMinima()
        {
            return umidadeMinima;
        }
        public void setUmidadeMaxima(int valor)
        {
            umidadeMaxima = valor;
        }
        public int getUmidadeMaxima()
        {
            return umidadeMaxima;
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

        private void UmidadeMaxConf_Scroll(object sender, EventArgs e)
        {
            float value = umidadeMaxConf.Value;
            valorUmidadeMax.Text = value.ToString();
        }

        private void BtnFecharConf_Click(object sender, EventArgs e)
        {
            this.Close();
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
            setAlturaCorte(alturaCorteConf.Value);
            setUmidadeMaxima(umidadeMaxConf.Value);
            setUmidadeMinima(umidadeMinConf.Value);
        }

        private void ListaCidades_Click(object sender, EventArgs e)
        {
            listaCidades.Items.Add("Porto Alegre");
            listaCidades.Items.Add("Canoas");
            listaCidades.Items.Add("Novo Hamburgo");
        }

        private void ListaGramas_Click(object sender, EventArgs e)
        {
            listaGramas.Items.Add("Esmeralda");
            listaGramas.Items.Add("Bermudas");
        }

        private void Configuracoes_Load(object sender, EventArgs e)
        {

        }
    }
}
