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
    public partial class TESTEUI : Form
    {

        private static TESTEUI _Instance = null;

        public static TESTEUI Instance
        {
            get
            {
                return _Instance;
            }
        }


        iUIExposed metodosUI;
        public TESTEUI(iUIExposed metodosUI)
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
            frm.ShowDialog();
        }

        private void Btn_CortarAgora_Click(object sender, EventArgs e)
        {
            
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
            Left = 690;
            Top = 100;
        }
    }
}
