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
    public partial class frmExcluirVeic : Form {
        public frmExcluirVeic() {
            InitializeComponent();
            CarregarGridVeiculos(); //Carregar o grid de veiculos
        }

        private void LimparCampos() { //Limpar os campos
            txtPlacaEx.Clear();            
        }

        private void btnExcluirVeic_Click(object sender, EventArgs e) { //Botao para excluir um veiculo
            string placa;
            Veiculo resultVeiculo;

            bool achou = false;

            try {
                if (txtPlacaEx.Text == "" || !txtPlacaEx.MaskCompleted) { //Verifica se os campos estão inseridos corretamente
                    MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {

                    placa = txtPlacaEx.Text;

                    foreach (Motorista mot in Controle.ListaMotoristas) { //Percorre a lista de motoristas para percorrer os veiculos existentes
                        resultVeiculo = mot.ListaVeiculos1.Find(x => x.Placa == placa); //Procura se o veiculo existe pela placa
                        if (resultVeiculo != null) { //Caso ache
                            achou = true;
                        }
                    }
                    if (achou == false) MessageBox.Show("Registro de veiculo não encontrado, verifique a placa inserida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                

            } catch (NullReferenceException) { //Exceção para caso não ache o veiculo
                MessageBox.Show("Registro de veiculo não encontrado, verifique a placa inserida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception) { //Exceção geral para caso um erro inesperado ocorra
                MessageBox.Show("Ocorreu um erro inesperado, verifique com o administrador do sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGridVeiculos() {
            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    if (v.Excluido == false) {
                        dtgVeiculos.Rows.Add(v.Placa, v.Chassi, v.Modelo, v.Ano, mot.Nome, v.CpfMotorista, "Não");
                    }                    
                }
            }
        }        

        private void dtgVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            txtPlacaEx.Text = dtgVeiculos[0, dtgVeiculos.CurrentCellAddress.Y].Value.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }
    }
}
