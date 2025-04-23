namespace TFI {
    partial class frmRelatorioVeiculos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioVeiculos));
            this.dtgVeiculos = new System.Windows.Forms.DataGridView();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrarPesquisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFProprietario = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVeiculos
            // 
            this.dtgVeiculos.AllowUserToDeleteRows = false;
            this.dtgVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placa,
            this.chassi,
            this.modelo,
            this.ano,
            this.nomeProp,
            this.cpfProp,
            this.excluido});
            this.dtgVeiculos.Location = new System.Drawing.Point(12, 182);
            this.dtgVeiculos.Name = "dtgVeiculos";
            this.dtgVeiculos.ReadOnly = true;
            this.dtgVeiculos.Size = new System.Drawing.Size(644, 301);
            this.dtgVeiculos.TabIndex = 49;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // chassi
            // 
            this.chassi.HeaderText = "Chassi";
            this.chassi.Name = "chassi";
            this.chassi.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // ano
            // 
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            // 
            // nomeProp
            // 
            this.nomeProp.HeaderText = "Nome proprietário";
            this.nomeProp.Name = "nomeProp";
            this.nomeProp.ReadOnly = true;
            // 
            // cpfProp
            // 
            this.cpfProp.HeaderText = "CPF Proprietário";
            this.cpfProp.Name = "cpfProp";
            this.cpfProp.ReadOnly = true;
            // 
            // excluido
            // 
            this.excluido.HeaderText = "Excluido";
            this.excluido.Name = "excluido";
            this.excluido.ReadOnly = true;
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Location = new System.Drawing.Point(77, 53);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtnTodos.TabIndex = 50;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            this.rbtnTodos.CheckedChanged += new System.EventHandler(this.rbtnTodos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Pesquisar por placa:";
            // 
            // btnFiltrarPesquisa
            // 
            this.btnFiltrarPesquisa.Location = new System.Drawing.Point(301, 141);
            this.btnFiltrarPesquisa.Name = "btnFiltrarPesquisa";
            this.btnFiltrarPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarPesquisa.TabIndex = 52;
            this.btnFiltrarPesquisa.Text = "Filtrar";
            this.btnFiltrarPesquisa.UseVisualStyleBackColor = true;
            this.btnFiltrarPesquisa.Click += new System.EventHandler(this.btnFiltrarPesquisa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Pesquisar por CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Escolha o filtro para o relatório de veiculos";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(322, 54);
            this.txtPlaca.Mask = "AAA-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 58;
            // 
            // txtCPFProprietario
            // 
            this.txtCPFProprietario.Location = new System.Drawing.Point(322, 94);
            this.txtCPFProprietario.Mask = "000.000.000-00";
            this.txtCPFProprietario.Name = "txtCPFProprietario";
            this.txtCPFProprietario.Size = new System.Drawing.Size(100, 20);
            this.txtCPFProprietario.TabIndex = 59;
            // 
            // frmRelatorioVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 495);
            this.Controls.Add(this.txtCPFProprietario);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltrarPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnTodos);
            this.Controls.Add(this.dtgVeiculos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioVeiculos";
            this.Text = "Relatório de veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVeiculos;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrarPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.MaskedTextBox txtCPFProprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn excluido;
    }
}