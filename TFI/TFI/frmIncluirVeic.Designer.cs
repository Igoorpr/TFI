namespace TFI {
    partial class frmIncluirVeic {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirVeic));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnIncluirVeic = new System.Windows.Forms.Button();
            this.dtgMotoristas = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfProprietario = new System.Windows.Forms.MaskedTextBox();
            this.btnGerarPlaca = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motoristas cadastrados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ano:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "CPF do proprietário:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(132, 123);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(116, 160);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(53, 20);
            this.txtAno.TabIndex = 3;
            // 
            // btnIncluirVeic
            // 
            this.btnIncluirVeic.Location = new System.Drawing.Point(237, 185);
            this.btnIncluirVeic.Name = "btnIncluirVeic";
            this.btnIncluirVeic.Size = new System.Drawing.Size(103, 23);
            this.btnIncluirVeic.TabIndex = 5;
            this.btnIncluirVeic.Text = "Cadastrar veiculo";
            this.btnIncluirVeic.UseVisualStyleBackColor = true;
            this.btnIncluirVeic.Click += new System.EventHandler(this.btnIncluirVeic_Click);
            // 
            // dtgMotoristas
            // 
            this.dtgMotoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMotoristas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.cpf,
            this.numCNH,
            this.pontuacao,
            this.dataNasc,
            this.carteira});
            this.dtgMotoristas.Location = new System.Drawing.Point(12, 244);
            this.dtgMotoristas.Name = "dtgMotoristas";
            this.dtgMotoristas.Size = new System.Drawing.Size(584, 280);
            this.dtgMotoristas.TabIndex = 13;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // numCNH
            // 
            this.numCNH.HeaderText = "Número da CNH";
            this.numCNH.Name = "numCNH";
            this.numCNH.ReadOnly = true;
            // 
            // pontuacao
            // 
            this.pontuacao.HeaderText = "Pontuação";
            this.pontuacao.Name = "pontuacao";
            this.pontuacao.ReadOnly = true;
            // 
            // dataNasc
            // 
            this.dataNasc.HeaderText = "Data de nascimento";
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.ReadOnly = true;
            // 
            // carteira
            // 
            this.carteira.HeaderText = "Carteira";
            this.carteira.Name = "carteira";
            this.carteira.ReadOnly = true;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(128, 91);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(100, 20);
            this.txtChassi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chassi:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(124, 62);
            this.txtPlaca.Mask = "AAA-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(60, 20);
            this.txtPlaca.TabIndex = 0;
            this.txtPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPlaca_MaskInputRejected);
            // 
            // txtCpfProprietario
            // 
            this.txtCpfProprietario.Location = new System.Drawing.Point(438, 63);
            this.txtCpfProprietario.Mask = "000.000.000-00";
            this.txtCpfProprietario.Name = "txtCpfProprietario";
            this.txtCpfProprietario.Size = new System.Drawing.Size(100, 20);
            this.txtCpfProprietario.TabIndex = 4;
            // 
            // btnGerarPlaca
            // 
            this.btnGerarPlaca.Location = new System.Drawing.Point(200, 60);
            this.btnGerarPlaca.Name = "btnGerarPlaca";
            this.btnGerarPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnGerarPlaca.TabIndex = 15;
            this.btnGerarPlaca.Text = "Gerar placa";
            this.btnGerarPlaca.UseVisualStyleBackColor = true;
            this.btnGerarPlaca.Click += new System.EventHandler(this.btnGerarPlaca_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(421, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Insira os dados para incluir um novo veículo";
            // 
            // frmIncluirVeic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 536);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGerarPlaca);
            this.Controls.Add(this.txtCpfProprietario);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgMotoristas);
            this.Controls.Add(this.btnIncluirVeic);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIncluirVeic";
            this.Text = "Incluir novo veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotoristas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnIncluirVeic;
        private System.Windows.Forms.DataGridView dtgMotoristas;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.MaskedTextBox txtCpfProprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontuacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteira;
        private System.Windows.Forms.Button btnGerarPlaca;
        private System.Windows.Forms.Label label7;
    }
}