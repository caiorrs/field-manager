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

        iUIExposed metodosUI;
        public TESTEUI(iUIExposed metodosUI)
        {
            this.metodosUI = metodosUI;
            InitializeComponent();            
        }

        private void BtnConfigurar_Click(object sender, EventArgs e)
        {
            new WindowsFormVersion.Configuracoes().Show();
        }

        private void Btn_CortarAgora_Click(object sender, EventArgs e)
        {

        }
    }
}
