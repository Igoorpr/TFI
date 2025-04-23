namespace TFI {
    partial class frmIncluirMulta {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirMulta));
            this.btnAplicarMulta = new System.Windows.Forms.Button();
            this.txtValorM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGravidade = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtgVeiculos = new System.Windows.Forms.DataGridView();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfM = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAplicarMulta
            // 
            this.btnAplicarMulta.Location = new System.Drawing.Point(222, 190);
            this.btnAplicarMulta.Name = "btnAplicarMulta";
            this.btnAplicarMulta.Size = new System.Drawing.Size(109, 23);
            this.btnAplicarMulta.TabIndex = 6;
            this.btnAplicarMulta.Text = "Aplicar multa";
            this.btnAplicarMulta.UseVisualStyleBackColor = true;
            this.btnAplicarMulta.Click += new System.EventHandler(this.btnAplicarMulta_Click);
            // 
            // txtValorM
            // 
            this.txtValorM.Location = new System.Drawing.Point(109, 158);
            this.txtValorM.Name = "txtValorM";
            this.txtValorM.Size = new System.Drawing.Size(100, 20);
            this.txtValorM.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "CPF do motorista:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Valor da multa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Gravidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Digite a placa:";
            // 
            // cbxGravidade
            // 
            this.cbxGravidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGravidade.FormattingEnabled = true;
            this.cbxGravidade.Items.AddRange(new object[] {
            "Leve (3 pontos)",
            "Média (4 pontos)",
            "Grave (5 pontos)",
            "Gravíssima (7 pontos)"});
            this.cbxGravidade.Location = new System.Drawing.Point(93, 85);
            this.cbxGravidade.Name = "cbxGravidade";
            this.cbxGravidade.Size = new System.Drawing.Size(98, 21);
            this.cbxGravidade.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(67, 121);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
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
            this.dtgVeiculos.Location = new System.Drawing.Point(12, 234);
            this.dtgVeiculos.Name = "dtgVeiculos";
            this.dtgVeiculos.ReadOnly = true;
            this.dtgVeiculos.Size = new System.Drawing.Size(546, 276);
            this.dtgVeiculos.TabIndex = 48;
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
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(109, 50);
            this.txtPlaca.Mask = "AAA-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(82, 20);
            this.txtPlaca.TabIndex = 0;
            this.txtPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPlaca_MaskInputRejected);
            // 
            // txtCpfM
            // 
            this.txtCpfM.Location = new System.Drawing.Point(392, 81);
            this.txtCpfM.Mask = "000.000.000-00";
            this.txtCpfM.Name = "txtCpfM";
            this.txtCpfM.Size = new System.Drawing.Size(100, 20);
            this.txtCpfM.TabIndex = 5;
            this.txtCpfM.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpfM_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(415, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "Insira os dados para incluir uma nova multa";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(387, 46);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(100, 20);
            this.txtMotivo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Motivo da multa:";
            // 
            // frmIncluirMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 522);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCpfM);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.dtgVeiculos);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbxGravidade);
            this.Controls.Add(this.btnAplicarMulta);
            this.Controls.Add(this.txtValorM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIncluirMulta";
            this.Text = "Incluir uma nova multa";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAplicarMulta;
        private System.Windows.Forms.TextBox txtValorM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGravidade;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dtgVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn excluido;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.MaskedTextBox txtCpfM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label4;
    }
}