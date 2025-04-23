using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TFI
{
    class Controle
    {
        public static List<Motorista> ListaMotoristas = new List<Motorista>();

        public static void VerificarArquivos() { //Verifica se os arquivos existem, caso falta algum ele cria antes do form iniciar

            if (!File.Exists("motoristas.txt") || !File.Exists("veiculos.txt") || !File.Exists("multas.txt")) { //Caso algum arquivo não tenha sido criado, ele cria.
                if (!File.Exists("motoristas.txt")) {
                    FileStream fs = File.Create("motoristas.txt");
                    fs.Close();
                }
                if (!File.Exists("veiculos.txt")) {
                    FileStream fs = File.Create("veiculos.txt");
                    fs.Close();
                }
                if (!File.Exists("multas.txt")) {
                    FileStream fs = File.Create("multas.txt");
                    fs.Close();
                }
                MessageBox.Show("Um ou mais arquivos estão faltando.\nOs arquivos que estão faltando foram criados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void leArqMultas(Veiculo v) {

            StreamReader lerMultas = new StreamReader("multas.txt"); //abrir o arquivo.

            string linhaMultas;
            string[] auxSeparador;  //separar dados de cada linha por strings

            int gravidade, penalidade;
            string dataMulta, placa, cpfM, justificacao, motivo;
            double valor;
            bool transferida, quitada, justificada;
            Multa m;

            linhaMultas = lerMultas.ReadLine(); //faz a primeira leitura (1a linha)

            while (linhaMultas != null) {      //enquanto houver informações..

                auxSeparador = linhaMultas.Split(';'); //separa a string linha em um vetor de varias strings (separadas pelo ';')

                placa = auxSeparador[0];

                if (placa == v.Placa) {
                    //id = int.Parse(auxSeparador[1]);
                    gravidade = int.Parse(auxSeparador[2]);
                    dataMulta = auxSeparador[3];
                    valor = double.Parse(auxSeparador[4]);
                    penalidade = int.Parse(auxSeparador[5]);
                    cpfM = auxSeparador[6];
                    motivo = auxSeparador[7];
                    transferida = bool.Parse(auxSeparador[8]);
                    quitada = bool.Parse(auxSeparador[9]);
                    justificada = bool.Parse(auxSeparador[10]);

                    m = new Multa(v.ListaMultas1.Count, gravidade, dataMulta, valor, penalidade, cpfM, motivo, transferida, quitada, justificada); //Cria a multa

                    if (m.Justificada == true) { //Caso a multa seja justificada
                        justificacao = auxSeparador[11];
                        m.Justificacao = justificacao; //Inserir a justificação
                    }

                    v.ListaMultas1.Add(m); //Insere a multa na lista de multas do veiculo

                }

                linhaMultas = lerMultas.ReadLine();
            }
            lerMultas.Close(); // fecha o arquivo    
        }

        public static void leArqVeiculos(Motorista mot) {

            StreamReader lerVeiculo = new StreamReader("veiculos.txt"); //abrir o arquivo

            string linhaVeiculo;
            string[] auxSeparador;  //separar dados de cada linha por strings

            //dados do veiculo
            string placa, modelo, cpfMot, chassi;
            int ano;
            bool excluido;
            Veiculo v;

            linhaVeiculo = lerVeiculo.ReadLine(); //faz a primeira leitura (1a linha)

            while (linhaVeiculo != null) {      //enquanto houver informações..

                auxSeparador = linhaVeiculo.Split(';'); //separa a string linha em um vetor de varias strings (separadas pelo ';')

                cpfMot = auxSeparador[4];

                if (cpfMot == mot.Cpf) {

                    placa = auxSeparador[0];
                    chassi = auxSeparador[1];
                    modelo = auxSeparador[2];
                    ano = int.Parse(auxSeparador[3]);
                    excluido = bool.Parse(auxSeparador[5]);

                    v = new Veiculo(placa, chassi, modelo, ano, cpfMot, excluido); //Cria o veiculo

                    mot.ListaVeiculos1.Add(v); //Adiciona o veiculo na lista de veiculos do motorista

                    leArqMultas(v); //Le o arquivo de multas para conferir se existe alguma multa relacionada nesse veiculo
                }

                linhaVeiculo = lerVeiculo.ReadLine();
            }
            lerVeiculo.Close(); // fecha o arquivo    
        }

        public static void leArquivos() {

            StreamReader lerMotorista = new StreamReader("motoristas.txt"); //abrir o arquivo                          

            string linhaMot;        //ler e escrever as linhas do arquivo
            string[] auxSeparador;  //separar dados de cada linha por strings

            Motorista mot;

            //dados do motorista
            int pontuacaoCarteira;
            string nome, cpf, dataNasc, numCarteira;
            bool podeDirigir;

            linhaMot = lerMotorista.ReadLine(); //faz a primeira leitura (1a linha)

            while (linhaMot != null) {      //enquanto houver informações..

                auxSeparador = linhaMot.Split(';'); //separa a string linha em um vetor de varias strings (separadas pelo ';')

                nome = auxSeparador[0];
                numCarteira = auxSeparador[1];
                pontuacaoCarteira = int.Parse(auxSeparador[2]);
                cpf = auxSeparador[3];
                dataNasc = auxSeparador[4];
                podeDirigir = bool.Parse(auxSeparador[5]);

                mot = new Motorista(nome, numCarteira, pontuacaoCarteira, cpf, dataNasc, podeDirigir); // Criando um motorista

                Controle.ListaMotoristas.Add(mot); // Adicionando o motorista na lista de motoristas                                              

                leArqVeiculos(mot); //Lê o arquivo de motoristas para verificar se esse motorista possui um veiculo ou não

                linhaMot = lerMotorista.ReadLine();
            }

            lerMotorista.Close(); // fecha o arquivo               
        }

        public static void gravarArquivos() {
            StreamWriter escreverMot = new StreamWriter("motoristas.txt"); //abrir o arquivo
            StreamWriter escreverVeic = new StreamWriter("veiculos.txt"); //abrir o arquivo           
            StreamWriter escreverMultas = new StreamWriter("multas.txt"); //abrir o arquivo

            string linha;

            foreach (Motorista mot in Controle.ListaMotoristas) { //Percorre a lista de motoristas
                linha = mot.Nome + ";" + mot.NumCarteira + ";" + mot.PontuacaoCarteira + ";" + mot.Cpf + ";" + mot.DataNasc + ";" + mot.PodeDirigir;
                escreverMot.WriteLine(linha); //Escreve as informações dos motoristas no arquivo

                foreach (Veiculo v in mot.ListaVeiculos1) { //Percorre a lista de veiculos
                    linha = v.Placa + ";" + v.Chassi + ";" + v.Modelo + ";" + v.Ano + ";" + v.CpfMotorista + ";" + v.Excluido;
                    escreverVeic.WriteLine(linha); //Escreve as informações dos veiculos no arquivo

                    foreach (Multa m in v.ListaMultas1) { //Percorre a lista de multas
                        if (m.Justificada == false) { //Se a multa não for justificada insere normalmente
                            linha = v.Placa + ";" + m.Id + ";" + m.Gravidade + ";" + m.DataMulta + ";" + m.Valor + ";" + m.Penalidade + ";" + m.CpfMultado + ";" + m.Motivo + ";" + m.Transferida + ";" + m.Quitada + ";" + m.Justificada;
                        } else { //Caso a multa seja justificada, insere junto com a justificação da mesma
                            linha = v.Placa + ";" + m.Id + ";" + m.Gravidade + ";" + m.DataMulta + ";" + m.Valor + ";" + m.Penalidade + ";" + m.CpfMultado + ";" + m.Motivo + ";" + m.Transferida + ";" + m.Quitada + ";" + m.Justificada + ";" + m.Justificacao;
                        }
                        escreverMultas.WriteLine(linha); //Escreve as informações das multas no arquivo
                    }
                }
            }

            escreverMot.Close(); //fecha o arquivo
            escreverVeic.Close(); //fecha o arquivo                      
            escreverMultas.Close(); //fecha o arquivo
        }
    }
}
