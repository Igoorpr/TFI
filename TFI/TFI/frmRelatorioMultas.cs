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
    public partial class frmRelatorioMultas : Form {
        public frmRelatorioMultas() {
            InitializeComponent();
            rbtnTodas.Checked = true;
            
        }

        public void CarregarMultas() {
            string paga = "", transferida = "", justificada = "", gravidade = "";

            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    foreach (Multa m in v.ListaMultas1) {
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
                            dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, "Nenhuma");
                        } else {
                            dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, m.Justificacao);
                        }
                    }
                }
            }
        }

        public void CarregarMultasPagas() {
            string transferida = "", justificada = "", gravidade = "";

            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    foreach (Multa m in v.ListaMultas1) {
                        if (m.Quitada == true) {                            

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
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, "Sim", gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, "Nenhuma");
                            } else {
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, "Sim", gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, m.Justificacao);
                            }
                        }                        
                    }
                }
            }
        }

        public void CarregarMultasNaoPagas() {
            string transferida = "", justificada = "", gravidade = "";

            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    foreach (Multa m in v.ListaMultas1) {
                        if (m.Quitada == false) {

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
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, "Não", gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, "Nenhuma");
                            } else {
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, "Não", gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, m.Justificacao);
                            }
                        }
                    }
                }
            }
        }

        public void CarregarMultasTransferidas() {
            string paga = "", justificada = "", gravidade = "";

            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    foreach (Multa m in v.ListaMultas1) {
                        if (m.Transferida == true) {

                            if (m.Quitada == true) paga = "Sim";
                            else paga = "Não";                            

                            if (m.Justificada == true) justificada = "Sim";
                            else justificada = "Não";

                            if (m.Gravidade == 0) gravidade = "Leve"; // leve
                            else if (m.Gravidade == 1) gravidade = "Média"; // media
                            else if (m.Gravidade == 2) gravidade = "Grave"; // grave
                            else if (m.Gravidade == 3) gravidade = "Gravíssima"; // gravissima
                            else gravidade = "";

                            if (m.Justificada == false) {
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, "Sim", justificada, "Nenhuma");
                            } else {
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, "Sim", justificada, m.Justificacao);
                            }
                        }
                    }
                }
            }
        }

        public void CarregarMultasJustificadas() {
            string paga = "", transferida = "", gravidade = "";

            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    foreach (Multa m in v.ListaMultas1) {
                        if (m.Justificada == true) {

                            if (m.Quitada == true) paga = "Sim";
                            else paga = "Não";

                            if (m.Transferida == true) transferida = "Sim";
                            else transferida = "Não";

                            if (m.Gravidade == 0) gravidade = "Leve"; // leve
                            else if (m.Gravidade == 1) gravidade = "Média"; // media
                            else if (m.Gravidade == 2) gravidade = "Grave"; // grave
                            else if (m.Gravidade == 3) gravidade = "Gravíssima"; // gravissima
                            else gravidade = "";

                            dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, "Sim", m.Justificacao);
                        }                        
                    }
                }
            }
        }

        public bool PesquisaPorCPF(string cpf) {
            string paga = "", transferida = "", justificada = "", gravidade = "";
            dtgMultas.Rows.Clear();
            bool achou = false;            
            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    foreach (Multa m in v.ListaMultas1) {
                        if(m.CpfMultado == cpf) {
                            achou = true;
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
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, "Nenhuma");
                            } else {
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, m.Justificacao);
                            }
                        }                        
                    }
                }
            }
            return achou;
        }

        public bool PesquisaPorPlaca(string placa) {
            string paga = "", transferida = "", justificada = "", gravidade = "";
            dtgMultas.Rows.Clear();
            bool achou = false;
            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    if (v.Placa == placa) {
                        achou = true;
                        foreach (Multa m in v.ListaMultas1) {
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
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, "Nenhuma");
                            } else {
                                dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, m.Justificacao);
                            }
                        }
                    }                    
                }
            }
            return achou;
        }

        public bool PesquisaPorPlacaCPF(string placa, string cpf) {
            string paga = "", transferida = "", justificada = "", gravidade = "";
            dtgMultas.Rows.Clear();
            bool achou = false;
            foreach (Motorista mot in Controle.ListaMotoristas) {
                foreach (Veiculo v in mot.ListaVeiculos1) {
                    if (v.Placa == placa) {
                        achou = true;                        
                        foreach (Multa m in v.ListaMultas1) {
                            if (m.CpfMultado == cpf) {
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
                                    dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, "Nenhuma");
                                } else {
                                    dtgMultas.Rows.Add(v.Placa, m.Motivo, paga, gravidade, m.DataMulta, m.Valor, m.Penalidade, m.CpfMultado, transferida, justificada, m.Justificacao);
                                }
                            }                            
                        }
                    }
                }
            }
            return achou;
        }

        private void rbtnTodas_CheckedChanged(object sender, EventArgs e) {
            dtgMultas.Rows.Clear();
            CarregarMultas();
        }

        private void rbtnPagas_CheckedChanged(object sender, EventArgs e) {
            dtgMultas.Rows.Clear();
            CarregarMultasPagas();
        }

        private void rbtnNaoPagas_CheckedChanged(object sender, EventArgs e) {
            dtgMultas.Rows.Clear();
            CarregarMultasNaoPagas();
        }

        private void rbtnTransferidas_CheckedChanged(object sender, EventArgs e) {
            dtgMultas.Rows.Clear();
            CarregarMultasTransferidas();
        }

        private void rbtnJustificadas_CheckedChanged(object sender, EventArgs e) {
            dtgMultas.Rows.Clear();
            CarregarMultasJustificadas();
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            string placa, cpf;

            rbtnTodas.Checked = false;

            if (!txtPlacas.MaskCompleted) placa = "";
            else placa = txtPlacas.Text;

            if (!txtCPF.MaskCompleted) cpf = "";
            else cpf = txtCPF.Text;

            if (placa == "" && cpf == "") { //Caso nenhum dos campos seja preenchido.
                MessageBox.Show("O(s) campo(s) precisa(m) ser preenchido(s) corretamente para a filtragem.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (placa == "") { //Filtrar apenas por CPF caso o campo de placa esteja vazio.

                if (!PesquisaPorCPF(cpf)) {
                    rbtnTodas.Checked = true;
                    MessageBox.Show("Nenhum registro de multa foi encontrado para essa pesquisa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else if (cpf == "") { //Filtrar apenas por placa caso o campo de CPF esteja vazio.

                if (!PesquisaPorPlaca(placa)) {
                    rbtnTodas.Checked = true;
                    MessageBox.Show("Nenhum registro de multa foi encontrado para essa pesquisa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else { //Filtrar por CPF e por placa caso ambos estejam preenchidos.

                if (!PesquisaPorPlacaCPF(placa, cpf)) {
                    rbtnTodas.Checked = true;
                    MessageBox.Show("Nenhum registro de multa foi encontrado para essa pesquisa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            

        }
    }
}
