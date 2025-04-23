using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/* 
 Trabalho interdisciplinar de programação orientada a objetos (Prática e Teorica).
 Professor: Paulo Amaral
 Projeto: TFI
 Data: 02/06/2019
 Nome dos alunos: Igor Palhares, Paulo Henrique
 Descricao: Este trabalho é um sistema de motoristas, veiculos e multas, para multar veiculos/motoristas, alterar multas (justificar, pagar, transferir), administrar os pontos
 na carteira de motoristas e seus veiculos, apresenta tambem uma parte somente para relatórios, para obter relatório mais especificos (usando filtros) ou mais gerais.

*/

namespace TFI {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();            
            Controle.VerificarArquivos(); //Verifica os arquivos para que realize a leitura corretamente
            Controle.leArquivos(); //Le os arquivos na propria inicialização do sistema
        }        

        private void frmPrincipal_Load(object sender, EventArgs e) {
            
        }

        private void btnSair_Click(object sender, EventArgs e) {
            Controle.gravarArquivos(); //Grava as informações nos arquivos antes de sair
            this.Close(); //Fecha o programa
        }

        private void frmPrincipal_FormClosing(Object sender, FormClosingEventArgs e) { //Evento formClosing para gravar no arquivo
            Controle.gravarArquivos();
        }

        private void btnMotoristas_Click(object sender, EventArgs e) {
            frmOpcoesMotorista opMotorista = new frmOpcoesMotorista();
            opMotorista.ShowDialog();
        }

        private void btnVeiculos_Click(object sender, EventArgs e) {
            frmOpcoesVeiculo opVeiculo = new frmOpcoesVeiculo();
            opVeiculo.ShowDialog();
        }

        private void btnMultas_Click(object sender, EventArgs e) {
            frmOpcoesMulta opMulta = new frmOpcoesMulta();
            opMulta.ShowDialog();
        }
    }
}
