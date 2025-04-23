namespace TFI {
    partial class frmIncluirMotorista {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirMotorista));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtgMotoristas = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncluirMot = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
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
            this.dtgMotoristas.Location = new System.Drawing.Point(12, 233);
            this.dtgMotoristas.Name = "dtgMotoristas";
            this.dtgMotoristas.Size = new System.Drawing.Size(647, 284);
            this.dtgMotoristas.TabIndex = 6;
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
            this.numCNH.HeaderText = "Número CNH";
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
            // btnIncluirMot
            // 
            this.btnIncluirMot.Location = new System.Drawing.Point(273, 189);
            this.btnIncluirMot.Name = "btnIncluirMot";
            this.btnIncluirMot.Size = new System.Drawing.Size(130, 23);
            this.btnIncluirMot.TabIndex = 3;
            this.btnIncluirMot.Text = "Incluir novo motorista";
            this.btnIncluirMot.UseVisualStyleBackColor = true;
            this.btnIncluirMot.Click += new System.EventHandler(this.btnIncluirMot_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(138, 141);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(63, 103);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpf_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(442, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Insira os dados para incluir um novo motorista";
            // 
            // frmIncluirMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 529);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnIncluirMot);
            this.Controls.Add(this.dtgMotoristas);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIncluirMotorista";
            this.Text = "Incluir novo motorista";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotoristas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dtgMotoristas;
        private System.Windows.Forms.Button btnIncluirMot;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontuacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteira;
        private System.Windows.Forms.Label label7;
    }
}