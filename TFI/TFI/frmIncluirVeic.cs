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
    public partial class frmIncluirVeic : Form {
        public frmIncluirVeic() {
            InitializeComponent();
            CarregarGridMotoristas();
        }

        private void LimparCampos() {
            txtPlaca.Clear();
            txtChassi.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtCpfProprietario.Clear();
        }

        private void btnIncluirVeic_Click(object sender, EventArgs e) { //Botao para incluir um veiculo
            string placa, modelo, cpfProprietario, chassi;
            int ano;

            Veiculo resultadoVeiculo = null, resultadoChassi = null;
            Motorista resultadoMotorista;

            try {
                if (txtPlaca.Text == "" || txtChassi.Text == "" || txtModelo.Text == "" || txtAno.Text == "" || txtCpfProprietario.Text == "" || !txtPlaca.MaskCompleted || !txtCpfProprietario.MaskCompleted) { //Verifica se os campos foram inseridos corretamente
                    MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    placa = txtPlaca.Text;
                    chassi = txtChassi.Text;
                    modelo = txtModelo.Text;
                    ano = int.Parse(txtAno.Text);
                    cpfProprietario = txtCpfProprietario.Text;

                    foreach (Motorista mot in Controle.ListaMotoristas) { // para cara motorista o foreach verifica se já existe a placa
                        resultadoVeiculo = mot.ListaVeiculos1.Find(x => x.Placa == placa);
                        resultadoChassi = mot.ListaVeiculos1.Find(x => x.Chassi == chassi);
                        if (resultadoVeiculo != null) {
                            MessageBox.Show("Veiculo já existente, insira outra placa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // cancela a operação caso encontre um veiculo com a mesma placa
                        }

                        if (resultadoChassi != null) {
                            MessageBox.Show("Chassi já existente, insira outro.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // cancela a operação caso encontre um veiculo com a mesma placa
                        }
                    }

                    resultadoMotorista = Controle.ListaMotoristas.Find(x => x.Cpf == cpfProprietario); // verifica se o motorista que será proprietario existe

                    if (resultadoMotorista != null) {

                        Veiculo NovoVeic = new Veiculo(placa, chassi, modelo, ano, cpfProprietario, false);

                        resultadoMotorista.ListaVeiculos1.Add(NovoVeic); //Adiciona o veiculo na lista
                        LimparCampos();
                        MessageBox.Show("Veiculo com a placa: " + placa + " cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } else {
                        MessageBox.Show("Motorista não existente ou CPF inválido, insira novamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                

            } catch (FormatException) { //Caso algum valor seja sido inserido com valores invalidos
                MessageBox.Show("Formato inválido, insira os caracteres corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception) { //Caso algum erro inesperado ocorra o programa não irá interromper
                MessageBox.Show("Ocorreu um erro inesperado, verifique com o administrador do sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                dtgMotoristas.Rows.Clear();                
                CarregarGridMotoristas();
            }
        }

        private void CarregarGridMotoristas() {
            foreach (Motorista mot in Controle.ListaMotoristas) {
                if (mot.PodeDirigir == true) {
                    dtgMotoristas.Rows.Add(mot.Nome, mot.Cpf, mot.NumCarteira, mot.PontuacaoCarteira, mot.DataNasc, "Possui");
                } else {
                    dtgMotoristas.Rows.Add(mot.Nome, mot.Cpf, mot.NumCarteira, mot.PontuacaoCarteira, mot.DataNasc, "Suspensa");
                }
            }
        }

        private void GerarPlacaRandom() { //Gerar uma placa random disponivel
            Random randNum = new Random();
            Veiculo veic;
            string placa = "";
            char letra;

            do {

                veic = null;
                placa = "";

                for (int i = 0; i < 3; i++) {
                    letra = (char)randNum.Next(65, 90);
                    placa += letra;
                }

                for (int i = 0; i < 4; i++) {
                    placa += randNum.Next(0, 9);
                }

                foreach (Motorista mot in Controle.ListaMotoristas) {
                    veic = mot.ListaVeiculos1.Find(x => x.Placa == placa);
                }

            } while (veic != null);

            txtPlaca.Text = placa;
        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void btnGerarPlaca_Click(object sender, EventArgs e) { //Botao para gerar uma placa random disponivel
            GerarPlacaRandom();
        }
    }
}
