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
    public partial class frmOpcoesMotorista : Form {
        public frmOpcoesMotorista() {
            InitializeComponent();
        }

        private void btnIncluirMotorista_Click(object sender, EventArgs e) {
            frmIncluirMotorista incluirMotorista = new frmIncluirMotorista();
            incluirMotorista.ShowDialog();
        }

        private void btnRelatorioMotoristas_Click(object sender, EventArgs e) {
            frmRelatorioMotoristas relatMot = new frmRelatorioMotoristas();
            relatMot.ShowDialog();
        }
    }
}
