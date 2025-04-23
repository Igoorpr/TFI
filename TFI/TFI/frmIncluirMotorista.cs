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
    public partial class frmIncluirMotorista : Form {
        public frmIncluirMotorista() {
            InitializeComponent();
            CarregarGridMotoristas();
        }

        private void LimparCampos() {
            txtNome.Clear();
            txtCpf.Clear();
        }

        private void btnIncluirMot_Click(object sender, EventArgs e) { //Botao para incluir motoristas

            string nome, cpf, dataN, numCarteira;            
            Motorista resultadoMotorista = null;

            if (txtNome.Text == "" || txtCpf.Text == "" || dateTimePicker.Value.ToString("dd/MM/yyyy") == "" || !txtCpf.MaskCompleted) { //Verifica se os campos foram inseridos corretamente
                MessageBox.Show("Insira todos os dados necessários corretamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                try {
                    nome = txtNome.Text;
                    cpf = txtCpf.Text;
                    dataN = dateTimePicker.Value.ToString("dd/MM/yyyy");

                    resultadoMotorista = Controle.ListaMotoristas.Find(x => x.Cpf == cpf); // Verifica se o CPF já existe

                    if (resultadoMotorista == null) {
                        numCarteira = GerarNumCNH(); //Gera um numero aleatório para a CNH
                        Motorista m = new Motorista(nome, numCarteira, 0, cpf, dataN, true); // Cadastrar novo motorista começa com 0 pontos inicialmente
                        Controle.ListaMotoristas.Add(m); //Adiciona o motorista na lista
                        dtgMotoristas.Rows.Clear();
                        CarregarGridMotoristas();
                        LimparCampos();
                        MessageBox.Show("Motorista criado com sucesso.\n\n|----------------Dados----------------|\nNome: " + nome + "\nCPF: " + cpf + "\nData de nascimento: " + dataN + "\nNúmero da CNH: " + numCarteira, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        MessageBox.Show("CPF já cadastrado no sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                } catch (FormatException) { //Caso algum valor seja inserido incorretamente
                    MessageBox.Show("Insira apenas valores válidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex) { //Caso algum erro inesperado ocorra o programa não irá interromper
                    MessageBox.Show("Ocorreu um erro inesperado.\n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private string GerarNumCNH() { //Gerar numero para a CNH do novo motorista
            string numCNH = "";
            bool existe = false;
            Random randNum = new Random();

            do {

                existe = false;
                for (int i = 0; i < 11; i++) {
                    numCNH += randNum.Next(0, 9);
                }

                foreach (Motorista mot in Controle.ListaMotoristas) {
                    if (mot.NumCarteira == numCNH) existe = true;
                }

            } while (existe == true);                

            return numCNH;
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

        private void dtgMotoristas_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }
    }
}
