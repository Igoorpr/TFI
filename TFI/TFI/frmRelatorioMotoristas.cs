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
    public partial class frmRelatorioMotoristas : Form {
        public frmRelatorioMotoristas() {
            InitializeComponent();
            rbtnTodos.Checked = true;
        }

        private void CarregarGridMotoristas() {
            foreach (Motorista mot in Controle.ListaMotoristas) {
                if (mot.PodeDirigir == true) {
                    dtgMotoristas.Rows.Add(mot.Nome, mot.Cpf, mot.NumCarteira, mot.PontuacaoCarteira, mot.DataNasc, "Ativa");
                } else {
                    dtgMotoristas.Rows.Add(mot.Nome, mot.Cpf, mot.NumCarteira, mot.PontuacaoCarteira, mot.DataNasc, "Suspensa");
                }
            }
        }

        private void CarregarGridPossuemCarteira() {
            foreach (Motorista mot in Controle.ListaMotoristas) {
                if (mot.PodeDirigir == true) {
                    dtgMotoristas.Rows.Add(mot.Nome, mot.Cpf, mot.NumCarteira, mot.PontuacaoCarteira, mot.DataNasc, "Ativa");
                }
            }
        }

        private void CarregarGridNaoMultados() {
            foreach (Motorista mot in Controle.ListaMotoristas) {
                if (mot.PontuacaoCarteira == 0) {
                    dtgMotoristas.Rows.Add(mot.Nome, mot.Cpf, mot.NumCarteira, mot.PontuacaoCarteira, mot.DataNasc, "Ativa");
                }
            }
        }

        private bool CarregarGridCPF(string cpf) {
            bool achou = false;
            dtgMotoristas.Rows.Clear();
            foreach (Motorista mot in Controle.ListaMotoristas) {
                if (mot.Cpf == cpf) {
                    achou = true;
                    dtgMotoristas.Rows.Add(mot.Nome, mot.Cpf, mot.NumCarteira, mot.PontuacaoCarteira, mot.DataNasc, "Ativa");
                }
            }
            return achou;
        }

        private void rbtnTodos_CheckedChanged(object sender, EventArgs e) {
            dtgMotoristas.Rows.Clear();
            CarregarGridMotoristas();
        }

        private void rbtnPossuemCarteira_CheckedChanged(object sender, EventArgs e) {
            dtgMotoristas.Rows.Clear();
            CarregarGridPossuemCarteira();
        }

        private void rbtnNaoPossuemMultas_CheckedChanged(object sender, EventArgs e) {
            dtgMotoristas.Rows.Clear();
            CarregarGridNaoMultados();
        }

        private void btnPesquisarCPF_Click(object sender, EventArgs e) {
            string cpf;
            rbtnTodos.Checked = false;

            cpf = txtCPF.Text;

            if (cpf == "" || !txtCPF.MaskCompleted) {                
                MessageBox.Show("Para filtrar por CPF, digite o CPF desejado corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtnTodos.Checked = true;
            } else {
                if (!CarregarGridCPF(cpf)) {                    
                    MessageBox.Show("CPF incorreto ou não existente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rbtnTodos.Checked = true;
                }                
            }
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dtgMotoristas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
