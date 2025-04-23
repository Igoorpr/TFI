using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFI {
    class Multa {
        //Atributos
        private int id;
        private int gravidade; // 1,2,3,4
        private string dataMulta;
        private double valor;
        private int penalidade;
        private string cpfMultado;
        private string motivo;
        private bool justificada;
        private bool transferida;
        private bool quitada;
        private string justificacao;

        public Multa(int id, int gravidade, string dataMulta, double valor, int penalidade, string cpfM, string motivo, bool transferida, bool quitada, bool justificada) { //Construtor para a leitura (apenas carrega dados)
            Id = id;
            Gravidade = gravidade;
            DataMulta = dataMulta;
            Valor = valor;
            Penalidade = penalidade;
            CpfMultado = cpfM;
            Motivo = motivo;
            Transferida = transferida;
            Quitada = quitada;
            Justificada = justificada;
        }

        public Multa(int id, int gravidade, string dataMulta, double valor, string cpfM, string motivo, bool transferida, bool quitada, bool justificada) { //Construtor para a aplicação da multa
            Id = id;
            Gravidade = gravidade;
            DataMulta = dataMulta;
            Valor = valor;
            CpfMultado = cpfM;
            Motivo = motivo;
            Transferida = transferida;
            Quitada = quitada;
            Justificada = justificada;
        }

        //Métodos de instancia

        public void CalcularPenalidade(int gravidade) {
            if (gravidade == 0) Penalidade = 3; // leve
            else if (gravidade == 1) Penalidade = 4; // media
            else if (gravidade == 2) Penalidade = 5; // grave
            else if (gravidade == 3) Penalidade = 7; // gravissima
            else Penalidade = 0;
        }

        public void QuitarMulta() {
            Quitada = true;
        }

        public void TransferirMulta(string novoCPF) {
            CpfMultado = novoCPF;
            Transferida = true;
        }

        public void JustificarMulta(string justificativa) {
            Justificacao = justificativa;
            Justificada = true;
        }

        //Getters e setters

        public int Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public int Gravidade {
            get {
                return gravidade;
            }

            set {
                gravidade = value;
            }
        }

        public string DataMulta {
            get {
                return dataMulta;
            }

            set {
                dataMulta = value;
            }
        }

        public double Valor {
            get {
                return valor;
            }

            set {
                valor = value;
            }
        }

        public int Penalidade {
            get {
                return penalidade;
            }

            set {
                penalidade = value;
            }
        }

        public string CpfMultado {
            get {
                return cpfMultado;
            }

            set {
                cpfMultado = value;
            }
        }

        public bool Justificada {
            get {
                return justificada;
            }

            set {
                justificada = value;
            }
        }

        public bool Transferida {
            get {
                return transferida;
            }

            set {
                transferida = value;
            }
        }

        public bool Quitada {
            get {
                return quitada;
            }

            set {
                quitada = value;
            }
        }

        public string Justificacao {
            get {
                return justificacao;
            }

            set {
                justificacao = value;
            }
        }

        public string Motivo {
            get {
                return motivo;
            }

            set {
                motivo = value;
            }
        }
    }
}
