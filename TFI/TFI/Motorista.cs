using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFI {
    class Motorista {
        //Atributos
        private string nome;
        private string numCarteira;
        private int pontuacaoCarteira;
        private string cpf;
        private string dataNasc;
        private bool podeDirigir;
        private List<Veiculo> ListaVeiculos = new List<Veiculo>();

        public Motorista(string nome, string num, int pontuacao, string cpf, string dataN, bool podeDirigir) { //Construtor
            Nome = nome;
            NumCarteira = num;
            PontuacaoCarteira = pontuacao;
            Cpf = cpf;
            DataNasc = dataN;
            PodeDirigir = podeDirigir;
        }

        //Métodos de instancia

        public void AplicarPenalidade(int penalidade) {
            PontuacaoCarteira += penalidade;

            if (PontuacaoCarteira >= 20) {
                PodeDirigir = false;
            } else {
                PodeDirigir = true;
            }
        }

        public void RessarcirPontos(int penalidade) {
            PontuacaoCarteira -= penalidade;

            if (PontuacaoCarteira >= 20) {
                PodeDirigir = false;
            } else {
                PodeDirigir = true;
            }
        }

        //Getters e setters

        public string Nome {
            get {
                return nome;
            }

            set {
                nome = value;
            }
        }

        public string NumCarteira {
            get {
                return numCarteira;
            }

            set {
                numCarteira = value;
            }
        }

        public int PontuacaoCarteira {
            get {
                return pontuacaoCarteira;
            }

            set {
                pontuacaoCarteira = value;
            }
        }

        public string Cpf {
            get {
                return cpf;
            }

            set {
                cpf = value;
            }
        }

        public string DataNasc {
            get {
                return dataNasc;
            }

            set {
                dataNasc = value;
            }
        }

        public bool PodeDirigir {
            get {
                return podeDirigir;
            }

            set {
                podeDirigir = value;
            }
        }

        internal List<Veiculo> ListaVeiculos1 {
            get {
                return ListaVeiculos;
            }

            set {
                ListaVeiculos = value;
            }
        }            
    }
}
