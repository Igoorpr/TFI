using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFI {
    public partial class frmOpcoesMulta : Form {
        public frmOpcoesMulta() {
            InitializeComponent();
        }

        private void btnIncluirMulta_Click(object sender, EventArgs e) {
            frmIncluirMulta incluirMulta = new frmIncluirMulta();
            incluirMulta.ShowDialog();
        }

        private void btnGerenciarMultas_Click(object sender, EventArgs e) {
            frmGerenciarMultas gerenciarMultas = new frmGerenciarMultas();
            gerenciarMultas.ShowDialog();
        }

        private void btnRelatorioMultas_Click(object sender, EventArgs e) {
            frmRelatorioMultas relatMultas = new frmRelatorioMultas();
            relatMultas.ShowDialog();
        }
    }
}
