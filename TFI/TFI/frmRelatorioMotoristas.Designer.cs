namespace TFI {
    partial class frmRelatorioMotoristas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioMotoristas));
            this.dtgMotoristas = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.rbtnPossuemCarteira = new System.Windows.Forms.RadioButton();
            this.rbtnNaoPossuemMultas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisarCPF = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotoristas)).BeginInit();
            this.SuspendLayout();
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
            this.dtgMotoristas.Location = new System.Drawing.Point(12, 162);
            this.dtgMotoristas.Name = "dtgMotoristas";
            this.dtgMotoristas.Size = new System.Drawing.Size(637, 276);
            this.dtgMotoristas.TabIndex = 7;
            this.dtgMotoristas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMotoristas_CellContentClick);
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
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Location = new System.Drawing.Point(96, 53);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtnTodos.TabIndex = 8;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            this.rbtnTodos.CheckedChanged += new System.EventHandler(this.rbtnTodos_CheckedChanged);
            // 
            // rbtnPossuemCarteira
            // 
            this.rbtnPossuemCarteira.AutoSize = true;
            this.rbtnPossuemCarteira.Location = new System.Drawing.Point(96, 85);
            this.rbtnPossuemCarteira.Name = "rbtnPossuemCarteira";
            this.rbtnPossuemCarteira.Size = new System.Drawing.Size(132, 17);
            this.rbtnPossuemCarteira.TabIndex = 9;
            this.rbtnPossuemCarteira.TabStop = true;
            this.rbtnPossuemCarteira.Text = "Possuem carteira ativa";
            this.rbtnPossuemCarteira.UseVisualStyleBackColor = true;
            this.rbtnPossuemCarteira.CheckedChanged += new System.EventHandler(this.rbtnPossuemCarteira_CheckedChanged);
            // 
            // rbtnNaoPossuemMultas
            // 
            this.rbtnNaoPossuemMultas.AutoSize = true;
            this.rbtnNaoPossuemMultas.Location = new System.Drawing.Point(96, 117);
            this.rbtnNaoPossuemMultas.Name = "rbtnNaoPossuemMultas";
            this.rbtnNaoPossuemMultas.Size = new System.Drawing.Size(123, 17);
            this.rbtnNaoPossuemMultas.TabIndex = 10;
            this.rbtnNaoPossuemMultas.TabStop = true;
            this.rbtnNaoPossuemMultas.Text = "Não possuem multas";
            this.rbtnNaoPossuemMultas.UseVisualStyleBackColor = true;
            this.rbtnNaoPossuemMultas.CheckedChanged += new System.EventHandler(this.rbtnNaoPossuemMultas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Escolha o filtro para o relatório de motoristas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pesquisar motorista por CPF:";
            // 
            // btnPesquisarCPF
            // 
            this.btnPesquisarCPF.Location = new System.Drawing.Point(414, 98);
            this.btnPesquisarCPF.Name = "btnPesquisarCPF";
            this.btnPesquisarCPF.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCPF.TabIndex = 14;
            this.btnPesquisarCPF.Text = "Pesquisar";
            this.btnPesquisarCPF.UseVisualStyleBackColor = true;
            this.btnPesquisarCPF.Click += new System.EventHandler(this.btnPesquisarCPF_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(461, 52);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 15;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            // 
            // frmRelatorioMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnPesquisarCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnNaoPossuemMultas);
            this.Controls.Add(this.rbtnPossuemCarteira);
            this.Controls.Add(this.rbtnTodos);
            this.Controls.Add(this.dtgMotoristas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioMotoristas";
            this.Text = "Relatório de motoristas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotoristas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMotoristas;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private System.Windows.Forms.RadioButton rbtnPossuemCarteira;
        private System.Windows.Forms.RadioButton rbtnNaoPossuemMultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisarCPF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontuacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteira;
    }
}