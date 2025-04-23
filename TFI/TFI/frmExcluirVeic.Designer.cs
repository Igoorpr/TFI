namespace TFI {
    partial class frmExcluirVeic {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcluirVeic));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirVeic = new System.Windows.Forms.Button();
            this.dtgVeiculos = new System.Windows.Forms.DataGridView();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPlacaEx = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Digite a placa do veiculo a ser excluido:";
            // 
            // btnExcluirVeic
            // 
            this.btnExcluirVeic.Location = new System.Drawing.Point(279, 85);
            this.btnExcluirVeic.Name = "btnExcluirVeic";
            this.btnExcluirVeic.Size = new System.Drawing.Size(88, 30);
            this.btnExcluirVeic.TabIndex = 19;
            this.btnExcluirVeic.Text = "Excluir veiculo";
            this.btnExcluirVeic.UseVisualStyleBackColor = true;
            this.btnExcluirVeic.Click += new System.EventHandler(this.btnExcluirVeic_Click);
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
            this.dtgVeiculos.Location = new System.Drawing.Point(12, 139);
            this.dtgVeiculos.Name = "dtgVeiculos";
            this.dtgVeiculos.ReadOnly = true;
            this.dtgVeiculos.Size = new System.Drawing.Size(641, 292);
            this.dtgVeiculos.TabIndex = 41;
            this.dtgVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVeiculos_CellContentClick);
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
            // txtPlacaEx
            // 
            this.txtPlacaEx.Location = new System.Drawing.Point(338, 32);
            this.txtPlacaEx.Mask = "AAA-0000";
            this.txtPlacaEx.Name = "txtPlacaEx";
            this.txtPlacaEx.Size = new System.Drawing.Size(63, 20);
            this.txtPlacaEx.TabIndex = 0;
            this.txtPlacaEx.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // frmExcluirVeic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 443);
            this.Controls.Add(this.txtPlacaEx);
            this.Controls.Add(this.dtgVeiculos);
            this.Controls.Add(this.btnExcluirVeic);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExcluirVeic";
            this.Text = "Excluir um veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirVeic;
        private System.Windows.Forms.DataGridView dtgVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn excluido;
        private System.Windows.Forms.MaskedTextBox txtPlacaEx;
    }
}