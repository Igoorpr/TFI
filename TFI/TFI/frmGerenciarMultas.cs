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
    public partial class frmGerenciarMultas : Form {
        public frmGerenciarMultas() {
            InitializeComponent();
            CarregarGridVeiculos();            
            rbtnQuitar.Checked = false;
            rbtnTransferir.Checked = false;
            rbtnJustificar.Checked = false;
        }

        private void btnVerificar_Click(object sender, EventArgs e) { //Botao para verificar multas de um veiculo a partir da placa

            dtgMultas.Rows.Clear();

            string placa = txtPlaca.Text;

            if (!txtPlaca.MaskCompleted) {
                MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                Veiculo resultadoVeiculo = null;

                foreach (Motorista mot in Controle.ListaMotoristas) { // para cara motorista o foreach verifica se existe a placa inserida
                    resultadoVeiculo = mot.ListaVeiculos1.Find(x => x.Placa == placa); //Verifica se a placa existe

                    if (resultadoVeiculo != null) { //Caso exista ele carrega as multas daquele veiculo, mas se o veiculo ja tiver sido excluido, ele avisa que os registros continuam.
                        if (resultadoVeiculo.Excluido == true) MessageBox.Show("Esse veiculo já foi excluido do sistema, porem as multas existentes no veiculo continuam normalmente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CarregarMultasVeiculo(resultadoVeiculo); //Carrega as multas de um veiculo especifico
                        return;
                    }
                }

                if (resultadoVeiculo == null) {
                    MessageBox.Show("Registro de veiculo não encontrado, verifique a placa inserida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CarregarGridVeiculos() {
            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    if (v.Excluido == false) {
                        dtgVeiculos.Rows.Add(v.Placa, v.Chassi, v.Modelo, v.Ano, mot.Nome, v.CpfMotorista, "Não");
                    } else {
                        dtgVeiculos.Rows.Add(v.Placa, v.Chassi, v.Modelo, v.Ano, mot.Nome, v.CpfMotorista, "Sim");
                    }
                }
            }
        }

        private void CarregarMultasVeiculo(Veiculo veic) {
            string paga = "", transferida = "", justificada = "", gravidade = "";
            foreach (Multa m in veic.ListaMultas1) {
                if (m.Quitada == true) paga = "Sim";
                else paga = "Não";

                if (m.Transferida == true) transferida = "Sim";
                else transferida = "Não";

                if (m.Justificada == true) justificada = "Sim";
                else justificada = "Não";

                if (m.Gravidade == 0) gravidade = "Leve"; // leve
                else if (m.Gravidade == 1) gravidade = "Média"; // media
                else if (m.Gravidade == 2) gravidade = "Grave"; // grave
                else if (m.Gravidade == 3) gravidade = "Gravíssima"; // gravissima
                else gravidade = "";


                if (m.Justificada == false) {
                    dtgMultas.Rows.Add(m.Id + 1, veic.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, "Nenhuma");
                } else {
                    dtgMultas.Rows.Add(m.Id + 1, veic.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, m.Justificacao);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            /*this.txtPlacaQuitar.Text = dataGridView2[1, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            this.txtID.Text = dataGridView2[0, dataGridView1.CurrentCellAddress.Y].Value.ToString();*/
        }

        private void frmQuitarMulta_Load(object sender, EventArgs e) {

        }

        private void rbtnQuitar_CheckedChanged(object sender, EventArgs e) {
            if (rbtnQuitar.Checked == true) {
                lblID.Visible = true;
                lblPlaca.Visible = true;
                lblCPFMultado.Visible = true;
                txtID.Visible = true;
                txtPlacaQuitar.Visible = true;
                txtCPFMultado.Visible = true;
                btnQuitarMulta.Visible = true;
            } else {
                lblID.Visible = false;
                lblPlaca.Visible = false;
                lblCPFMultado.Visible = false;
                txtID.Visible = false;
                txtPlacaQuitar.Visible = false;
                txtCPFMultado.Visible = false;
                btnQuitarMulta.Visible = false;
            }
        }

        private void rbtnTransferir_CheckedChanged(object sender, EventArgs e) {
            if (rbtnTransferir.Checked == true) {
                lblIDT.Visible = true;
                lblPlacaT.Visible = true;
                lblTransferirCPF.Visible = true;
                txtIDT.Visible = true;
                txtPlacaT.Visible = true;
                txtNovoCPF.Visible = true;
                btnTransferirMulta.Visible = true;
            } else {
                lblIDT.Visible = false;
                lblPlacaT.Visible = false;
                lblTransferirCPF.Visible = false;
                txtIDT.Visible = false;
                txtPlacaT.Visible = false;
                txtNovoCPF.Visible = false;
                btnTransferirMulta.Visible = false;
            }
        }

        private void rbtnJustificar_CheckedChanged(object sender, EventArgs e) {
            if (rbtnJustificar.Checked == true) {
                lblIDJ.Visible = true;
                lblPlacaJ.Visible = true;
                lblCPFMultadoJ.Visible = true;
                lblJustificacaoJ.Visible = true;
                txtIDJ.Visible = true;
                txtPlacaJ.Visible = true;
                txtCPFMultadoJ.Visible = true;
                txtJustificacao.Visible = true;
                btnJustificarMulta.Visible = true;
            } else {
                lblIDJ.Visible = false;
                lblPlacaJ.Visible = false;
                lblCPFMultadoJ.Visible = false;
                lblJustificacaoJ.Visible = false;
                txtIDJ.Visible = false;
                txtPlacaJ.Visible = false;
                txtCPFMultadoJ.Visible = false;
                txtJustificacao.Visible = false;
                btnJustificarMulta.Visible = false;
            }
        }

        private void btnQuitarMulta_Click(object sender, EventArgs e) { //Botao para quitar (pagar) multas
            int id;
            string placaQuitar, CPFMultado;

            bool achou = false;
            try {

                if (txtID.Text == "" || !txtPlacaQuitar.MaskCompleted || !txtCPFMultado.MaskCompleted) { //Verifica se todos os dados estão sendo preenchidos corretamente
                    MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    placaQuitar = txtPlacaQuitar.Text;
                    id = int.Parse(txtID.Text) - 1;
                    CPFMultado = txtCPFMultado.Text;

                    foreach (Motorista mot in Controle.ListaMotoristas) { //Percorre as listas para verificar se essa multa é valida
                        foreach (Veiculo v in mot.ListaVeiculos1) {
                            if (placaQuitar == v.Placa) { //Verifica a placa do veiculo
                                foreach (Multa m in v.ListaMultas1) {
                                    if (m.Id == id && m.CpfMultado == CPFMultado) { //Verifica o CPF do motorista multado e o id da multa
                                        achou = true;
                                        if (m.Quitada == false && m.Justificada == false) {
                                            m.QuitarMulta(); //Quita a multa
                                            MessageBox.Show("Multa quitada(paga) com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            dtgMultas.Rows.Clear();
                                            CarregarMultasVeiculo(v);
                                        } else {
                                            MessageBox.Show("Essa multa já foi quitada e/ou transferida e/ou justificada, portanto não pode mais ser transferida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (achou == false) MessageBox.Show("Multa não encontrada, verifique os dados novamente (ID, placa, CPF do multado).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                

            } catch (FormatException) { //Caso valores sejam inseridos incorretamente
                MessageBox.Show("Formato inválido, insira os caracteres corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception) { //Caso algum erro inesperado ocorra, o programa não irá interromper
                MessageBox.Show("Ocorreu um erro inesperado, verifique com o administrador do sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransferirMulta_Click(object sender, EventArgs e) { //Botao para transferir uma multa
            int id;
            string placa, CPFTransferido;

            Motorista resultadoMotorista;
            Motorista ressarcido = null;

            bool achou = false;

            try {

                if (txtIDT.Text == "" || !txtPlacaT.MaskCompleted || !txtNovoCPF.MaskCompleted) { //Verifica se todos os campos foram inseridos corretamente
                    MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    placa = txtPlacaT.Text;
                    id = int.Parse(txtIDT.Text) - 1;
                    CPFTransferido = txtNovoCPF.Text;

                    resultadoMotorista = Controle.ListaMotoristas.Find(x => x.Cpf == CPFTransferido); //Verificar se o CPF a ser transferido a multa existe
                    if (resultadoMotorista == null) throw new NullReferenceException();


                    foreach (Motorista mot in Controle.ListaMotoristas) { //Percorre as listas para achar a multa
                        foreach (Veiculo v in mot.ListaVeiculos1) {
                            if (placa == v.Placa) {
                                foreach (Multa m in v.ListaMultas1) {
                                    if (m.Id == id) {
                                        achou = true;
                                        if (m.Quitada == false && m.Transferida == false && m.Justificada == false) {
                                            ressarcido = Controle.ListaMotoristas.Find(x => x.Cpf == m.CpfMultado); // Caso tudo dê certo, o motorista antigo terá os pontos ressarcidos
                                            ressarcido.RessarcirPontos(m.Penalidade); //Motorista com os pontos ressarcidos     

                                            m.TransferirMulta(CPFTransferido); //Setando a multa como transferida

                                            resultadoMotorista.AplicarPenalidade(m.Penalidade); //Penalizando o novo motorista responsavel pela multa                                            

                                            dtgMultas.Rows.Clear();
                                            CarregarMultasVeiculo(v);
                                            MessageBox.Show("Multa transferida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        } else {
                                            MessageBox.Show("Essa multa já foi quitada e/ou transferida e/ou justificada, portanto não pode mais ser transferida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (achou == false) MessageBox.Show("Multa não encontrada, verifique os dados novamente (ID, placa, CPF do multado).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                


            } catch (FormatException) { //Caso algum valor seja inserido incorretamente
                MessageBox.Show("Formato inválido, insira os caracteres corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (NullReferenceException) { //Caso a instancia do motorista não seja encontrado
                MessageBox.Show("Motorista a ser transferido a multa não encontrado, verifique o CPF.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception) { //Caso ocorra um erro inesperado o programa não ira interromper
                MessageBox.Show("Ocorreu um erro inesperado, verifique com o administrador do sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJustificarMulta_Click(object sender, EventArgs e) { //Botão de justificar multa
            int id;
            string placa, CPFMultado, justificacao;
            Motorista motRessarcido;

            bool achou = false;

            try {

                if (txtIDJ.Text == "" || !txtPlacaJ.MaskCompleted || !txtCPFMultadoJ.MaskCompleted || txtJustificacao.Text == "") { //Verifica se todos os campos foram inseridos corretamente
                    MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    placa = txtPlacaJ.Text;
                    id = int.Parse(txtIDJ.Text) - 1;
                    CPFMultado = txtCPFMultadoJ.Text;
                    justificacao = txtJustificacao.Text;

                    foreach (Motorista mot in Controle.ListaMotoristas) { //Percorre as listas para achar a multa
                        foreach (Veiculo v in mot.ListaVeiculos1) {
                            if (placa == v.Placa) {
                                foreach (Multa m in v.ListaMultas1) {
                                    if (m.Id == id && m.CpfMultado == CPFMultado) {
                                        achou = true;
                                        if (m.Quitada == false && m.Transferida == false && m.Justificada == false) {

                                            motRessarcido = Controle.ListaMotoristas.Find(x => x.Cpf == m.CpfMultado); // Caso a multa seja justificada, o motorista terá os pontos ressarcidos
                                            motRessarcido.RessarcirPontos(m.Penalidade); //Ressarcindo os pontos

                                            m.JustificarMulta(justificacao); //Justifica a multa

                                            dtgMultas.Rows.Clear();
                                            CarregarMultasVeiculo(v);
                                            MessageBox.Show("Multa justificada com sucesso, penalidade retirada.\nJustificação: " + justificacao, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        } else {
                                            MessageBox.Show("Essa multa já foi quitada e/ou transferida e/ou justificada, portanto não pode mais ser justificada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (achou == false) MessageBox.Show("Multa não encontrada, verifique os dados novamente (ID, placa, CPF do multado).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                

            } catch (FormatException) { //Caso os valores sejam invalidos
                MessageBox.Show("Formato inválido, insira os caracteres corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (NullReferenceException) { //Caso não encontre a referencia para algum objeto
                MessageBox.Show("Um erro ocorreu, verifique os dados digitados.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception) { //Caso algum erro inesperado ocorra o programa não interrompe
                MessageBox.Show("Ocorreu um erro inesperado, verifique com o administrador do sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            dtgMultas.Rows.Clear();
            txtPlaca.Text = dtgVeiculos[0, dtgVeiculos.CurrentCellAddress.Y].Value.ToString();
            Veiculo resultadoVeiculo = null;

            foreach (Motorista mot in Controle.ListaMotoristas) {
                resultadoVeiculo = mot.ListaVeiculos1.Find(x => x.Placa == txtPlaca.Text);

                if (resultadoVeiculo != null) {
                    if (resultadoVeiculo.Excluido == true) MessageBox.Show("Esse veiculo já foi excluido do sistema, porem as multas existentes no veiculo continuam normalmente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CarregarMultasVeiculo(resultadoVeiculo);
                    return;
                }
            }
        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void dtgMultas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {


        }        
    }
}
