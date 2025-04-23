using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFI {
    class Veiculo {
        //Atributos
        private string placa;
        private string chassi;
        private string modelo;
        private int ano;        
        private string cpfMotorista;
        private bool excluido;
        private List<Multa> ListaMultas = new List<Multa>();

        public Veiculo(string placa, string chassi ,string modelo, int ano, string cpfMot, bool excluido) { //Construtor
            Placa = placa;
            Modelo = modelo;
            Ano = ano;            
            CpfMotorista = cpfMot;
            Chassi = chassi;
            Excluido = excluido;
        }

        //Métodos de instancia

        public void ExcluirVeic() {
            Excluido = true;
        }

        //Getters e setters

        public string Placa {
            get {
                return placa;
            }

            set {
                placa = value;
            }
        }

        public string Chassi {
            get {
                return chassi;
            }

            set {
                chassi = value;
            }
        }

        public string Modelo {
            get {
                return modelo;
            }

            set {
                modelo = value;
            }
        }

        public int Ano {
            get {
                return ano;
            }

            set {
                ano = value;
            }
        }

        public string CpfMotorista {
            get {
                return cpfMotorista;
            }

            set {
                cpfMotorista = value;
            }
        }

        public bool Excluido {
            get {
                return excluido;
            }

            set {
                excluido = value;
            }
        }

        internal List<Multa> ListaMultas1 {
            get {
                return ListaMultas;
            }

            set {
                ListaMultas = value;
            }
        }        
    }
}
