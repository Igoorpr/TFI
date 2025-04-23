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
    public partial class frmIncluirMulta : Form {
        public frmIncluirMulta() {
            InitializeComponent();
            CarregarGridVeiculos();
            cbxGravidade.SelectedIndex = 0;
        }

        private void LimparCampos() {
            txtPlaca.Clear();
            txtCpfM.Clear();
            txtValorM.Clear();
            txtMotivo.Clear();
            cbxGravidade.SelectedIndex = 0;
        }

        private void btnAplicarMulta_Click(object sender, EventArgs e) { //Botao para aplicar multas
            int gravidade;
            string dataMulta, cpfMotorista, placa, motivo;
            double valor;

            Motorista resultadoMotorista;
            Veiculo resultadoVeiculo = null;

            try {
                if (txtPlaca.Text == "" || txtCpfM.Text == "" || txtValorM.Text == "" || txtMotivo.Text == "" || !txtPlaca.MaskCompleted || !txtCpfM.MaskCompleted) { //Verifica se os campos foram inseridos corretamente
                    MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    placa = txtPlaca.Text;
                    gravidade = cbxGravidade.SelectedIndex;
                    dataMulta = dateTimePicker.Value.ToString("dd/MM/yyyy");
                    cpfMotorista = txtCpfM.Text;
                    valor = double.Parse(txtValorM.Text);
                    motivo = txtMotivo.Text;

                    resultadoMotorista = Controle.ListaMotoristas.Find(x => x.Cpf == cpfMotorista); // verifica se o motorista a ser multado existe

                    if (resultadoMotorista != null) {

                        foreach (Motorista mot in Controle.ListaMotoristas) { // para cara motorista o foreach verifica se existe a placa inserida
                            resultadoVeiculo = mot.ListaVeiculos1.Find(x => x.Placa == placa);
                            if (resultadoVeiculo != null && resultadoVeiculo.Excluido == false) { //Se achar o veiculo e ele nao estiver sido excluido, aplica a multa                                

                                Multa multa = new Multa(resultadoVeiculo.ListaMultas1.Count(), gravidade, dataMulta, valor, cpfMotorista, motivo, false, false, false); //Criando a multa
                                multa.CalcularPenalidade(gravidade); //Calcula o valor em pontos da penalidade dessa multa
                                resultadoVeiculo.ListaMultas1.Add(multa); //Adiciona essa multa na lista de multas do veiculo

                                resultadoMotorista.AplicarPenalidade(multa.Penalidade); //Aplica a penalidade dos pontos no motorista multado
                                LimparCampos();
                                MessageBox.Show("Multa cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return; // termina o loop pois não precisa mais continuar
                            }
                        }
                        if (resultadoVeiculo == null || resultadoVeiculo.Excluido == true) {
                            MessageBox.Show("Veiculo não encontrado ou já excluido, verifique se a placa foi inserida corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else {
                        MessageBox.Show("Motorista não existente ou CPF inválido, insira novamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                

            } catch (FormatException) { //Caso algum valor seja inserido incorretamente
                MessageBox.Show("Formato inválido, insira valores e caracteres válidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) { //Caso algum erro inesperado ocorra o programa não ira interromper
                MessageBox.Show("Ocorreu um erro inesperado.\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGridVeiculos() {
            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    if(v.Excluido == false) dtgVeiculos.Rows.Add(v.Placa, v.Chassi, v.Modelo, v.Ano, mot.Nome, v.CpfMotorista, "Não");
                }
            }
        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void txtCpfM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }
    }
}
