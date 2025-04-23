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
    public partial class frmRelatorioVeiculos : Form {
        public frmRelatorioVeiculos() {
            InitializeComponent();
            rbtnTodos.Checked = true;
        }

        private void rbtnTodos_CheckedChanged(object sender, EventArgs e) {
            dtgVeiculos.Rows.Clear();
            CarregarGridTodosVeiculos();
        }

        private void CarregarGridTodosVeiculos() {            
            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    if(v.Excluido == false) dtgVeiculos.Rows.Add(v.Placa, v.Chassi, v.Modelo, v.Ano, mot.Nome, v.CpfMotorista, "Não");
                }
            }
        }

        private bool PesquisaPorCPF(string CPFProprietario) {
            bool achou = false;
            dtgVeiculos.Rows.Clear();
            foreach (Motorista mot in Controle.ListaMotoristas) {
                if (mot.Cpf == CPFProprietario) { //Caso ache o CPF inserido, irá imprimir todos os carros que o proprietario possui (caso possua)
                    foreach (Veiculo v in mot.ListaVeiculos1) {
                        achou = true;
                        if (v.Excluido == false) dtgVeiculos.Rows.Add(v.Placa, v.Chassi, v.Modelo, v.Ano, mot.Nome, v.CpfMotorista, "Não");
                    }
                }                
            }
            return achou;
        }

        private bool PesquisasPorPlaca(string placa) {
            bool achou = false;
            dtgVeiculos.Rows.Clear();
            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {                    
                    if (v.Placa == placa) {
                        achou = true;
                        if (v.Excluido == false) dtgVeiculos.Rows.Add(v.Placa, v.Chassi, v.Modelo, v.Ano, mot.Nome, v.CpfMotorista, "Não");
                        break;
                    }
                }
                if (achou == true) break;
            }
            return achou;
        }

        private bool PesquisaPorPlacaCPF(string placa, string cpf) {
            bool achou = false;
            dtgVeiculos.Rows.Clear();
            foreach (Motorista mot in Controle.ListaMotoristas) {
                if (mot.Cpf == cpf) {
                    foreach (Veiculo v in mot.ListaVeiculos1) {
                        if (v.Placa == placa) {
                            achou = true;
                            if (v.Excluido == false) dtgVeiculos.Rows.Add(v.Placa, v.Chassi, v.Modelo, v.Ano, mot.Nome, v.CpfMotorista, "Não");
                        }                        
                    }
                }                
            }
            return achou;
        }

        private void btnFiltrarPesquisa_Click(object sender, EventArgs e) {
            string placa, cpf;

            rbtnTodos.Checked = false;

            if (!txtPlaca.MaskCompleted) placa = "";
            else placa = txtPlaca.Text;

            if (!txtCPFProprietario.MaskCompleted) cpf = "";
            else cpf = txtCPFProprietario.Text;

            if (placa == "" && cpf == "") { //Caso nenhum dos campos seja preenchido.
                MessageBox.Show("O(s) campo(s) precisa(m) ser preenchido(s) corretamente para a filtragem.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (placa == "") { //Filtrar apenas por CPF caso o campo de placa esteja vazio.

                if (!PesquisaPorCPF(cpf)) {
                    rbtnTodos.Checked = true;
                    MessageBox.Show("Nenhum registro de veiculo foi encontrado para essa pesquisa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                

            } else if (cpf == "") { //Filtrar apenas por placa caso o campo de CPF esteja vazio.

                if (!PesquisasPorPlaca(placa)) {
                    rbtnTodos.Checked = true;
                    MessageBox.Show("Nenhum registro de veiculo foi encontrado para essa pesquisa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else { //Filtrar por CPF e por placa caso ambos estejam preenchidos.

                if (!PesquisaPorPlacaCPF(placa, cpf)) {
                    rbtnTodos.Checked = true;
                    MessageBox.Show("Nenhum registro de veiculo foi encontrado para essa pesquisa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
