using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormVersion.Servidor_Central
{
    public partial class SistemaUI : Form
    {

        private static SistemaUI _Instance = null;

        public static SistemaUI Instance
        {
            get
            {
                return _Instance;
            }
        }


        iUIExposed metodosUI;
        public SistemaUI(iUIExposed metodosUI)
        {
            this.metodosUI = metodosUI;
            InitializeComponent();
            _Instance = this;
        }

        private void BtnConfigurar_Click(object sender, EventArgs e)
        {
            Configuracoes frm = new WindowsFormVersion.Configuracoes();
            frm.setAlturaCorte(10);
            frm.setUmidadeMinima(25);
            frm.setUmidadeIdeal(50);
            frm.ShowDialog();
            Program.irrigacao.confIdeal = frm.getUmidadeIdeal();
            Program.irrigacao.confMin = frm.getUmidadeMinima();
            Program.corte.UpdateAltura(frm.getAlturaCorte());
        }

        private void Btn_CortarAgora_Click(object sender, EventArgs e)
        {
            Program.corte.Cortar();
        }

        private void TESTEUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Simulador.Instance != null)
            {
                Simulador.Instance.BeginInvoke((MethodInvoker)delegate () { Simulador.Instance.Close(); });
            }
        }

        private void TESTEUI_VisibleChanged(object sender, EventArgs e)
        {
            Left = 600;
            Top = 100;
        }
    }
}
