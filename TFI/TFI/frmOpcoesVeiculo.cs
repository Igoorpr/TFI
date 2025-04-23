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
    public partial class frmOpcoesVeiculo : Form {
        public frmOpcoesVeiculo() {
            InitializeComponent();
        }

        private void btnIncluirVeiculo_Click(object sender, EventArgs e) {
            frmIncluirVeic incluirVeic = new frmIncluirVeic();
            incluirVeic.ShowDialog();
        }

        private void btnExcluirVeiculos_Click(object sender, EventArgs e) {
            frmExcluirVeic excluirVeic = new frmExcluirVeic();
            excluirVeic.ShowDialog();
        }

        private void btnRelatorioVeiculos_Click(object sender, EventArgs e) {
            frmRelatorioVeiculos relatVeic = new frmRelatorioVeiculos();
            relatVeic.ShowDialog();
        }
    }
}
