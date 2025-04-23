namespace TFI {
    partial class frmRelatorioMultas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioMultas));
            this.dtgMultas = new System.Windows.Forms.DataGridView();
            this.rbtnPagas = new System.Windows.Forms.RadioButton();
            this.rbtnNaoPagas = new System.Windows.Forms.RadioButton();
            this.rbtnTransferidas = new System.Windows.Forms.RadioButton();
            this.rbtnJustificadas = new System.Windows.Forms.RadioButton();
            this.rbtnTodas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gravidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDoMultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.justificada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.justificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMultas
            // 
            this.dtgMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placa,
            this.motivo,
            this.quitada,
            this.gravidade,
            this.dataMulta,
            this.valor,
            this.penalidade,
            this.cpfDoMultado,
            this.transferida,
            this.justificada,
            this.justificacao});
            this.dtgMultas.Location = new System.Drawing.Point(12, 265);
            this.dtgMultas.Name = "dtgMultas";
            this.dtgMultas.Size = new System.Drawing.Size(1044, 359);
            this.dtgMultas.TabIndex = 38;
            // 
            // rbtnPagas
            // 
            this.rbtnPagas.AutoSize = true;
            this.rbtnPagas.Location = new System.Drawing.Point(161, 97);
            this.rbtnPagas.Name = "rbtnPagas";
            this.rbtnPagas.Size = new System.Drawing.Size(88, 17);
            this.rbtnPagas.TabIndex = 39;
            this.rbtnPagas.TabStop = true;
            this.rbtnPagas.Text = "Multas pagas";
            this.rbtnPagas.UseVisualStyleBackColor = true;
            this.rbtnPagas.CheckedChanged += new System.EventHandler(this.rbtnPagas_CheckedChanged);
            // 
            // rbtnNaoPagas
            // 
            this.rbtnNaoPagas.AutoSize = true;
            this.rbtnNaoPagas.Location = new System.Drawing.Point(161, 129);
            this.rbtnNaoPagas.Name = "rbtnNaoPagas";
            this.rbtnNaoPagas.Size = new System.Drawing.Size(109, 17);
            this.rbtnNaoPagas.TabIndex = 40;
            this.rbtnNaoPagas.TabStop = true;
            this.rbtnNaoPagas.Text = "Multas não pagas";
            this.rbtnNaoPagas.UseVisualStyleBackColor = true;
            this.rbtnNaoPagas.CheckedChanged += new System.EventHandler(this.rbtnNaoPagas_CheckedChanged);
            // 
            // rbtnTransferidas
            // 
            this.rbtnTransferidas.AutoSize = true;
            this.rbtnTransferidas.Location = new System.Drawing.Point(161, 162);
            this.rbtnTransferidas.Name = "rbtnTransferidas";
            this.rbtnTransferidas.Size = new System.Drawing.Size(113, 17);
            this.rbtnTransferidas.TabIndex = 41;
            this.rbtnTransferidas.TabStop = true;
            this.rbtnTransferidas.Text = "Multas transferidas";
            this.rbtnTransferidas.UseVisualStyleBackColor = true;
            this.rbtnTransferidas.CheckedChanged += new System.EventHandler(this.rbtnTransferidas_CheckedChanged);
            // 
            // rbtnJustificadas
            // 
            this.rbtnJustificadas.AutoSize = true;
            this.rbtnJustificadas.Location = new System.Drawing.Point(161, 196);
            this.rbtnJustificadas.Name = "rbtnJustificadas";
            this.rbtnJustificadas.Size = new System.Drawing.Size(111, 17);
            this.rbtnJustificadas.TabIndex = 42;
            this.rbtnJustificadas.TabStop = true;
            this.rbtnJustificadas.Text = "Multas justificadas";
            this.rbtnJustificadas.UseVisualStyleBackColor = true;
            this.rbtnJustificadas.CheckedChanged += new System.EventHandler(this.rbtnJustificadas_CheckedChanged);
            // 
            // rbtnTodas
            // 
            this.rbtnTodas.AutoSize = true;
            this.rbtnTodas.Location = new System.Drawing.Point(161, 65);
            this.rbtnTodas.Name = "rbtnTodas";
            this.rbtnTodas.Size = new System.Drawing.Size(55, 17);
            this.rbtnTodas.TabIndex = 43;
            this.rbtnTodas.TabStop = true;
            this.rbtnTodas.Text = "Todas";
            this.rbtnTodas.UseVisualStyleBackColor = true;
            this.rbtnTodas.CheckedChanged += new System.EventHandler(this.rbtnTodas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Filtrar multas por placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Filtrar multas por CPF:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(693, 193);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 48;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Escolha o filtro para o relatório de multas";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(711, 77);
            this.txtPlacas.Mask = "AAA-0000";
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(100, 20);
            this.txtPlacas.TabIndex = 0;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(711, 126);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 1;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // motivo
            // 
            this.motivo.HeaderText = "Motivo";
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            // 
            // quitada
            // 
            this.quitada.HeaderText = "Paga";
            this.quitada.Name = "quitada";
            this.quitada.ReadOnly = true;
            // 
            // gravidade
            // 
            this.gravidade.HeaderText = "Gravidade";
            this.gravidade.Name = "gravidade";
            this.gravidade.ReadOnly = true;
            // 
            // dataMulta
            // 
            this.dataMulta.HeaderText = "Data da multa";
            this.dataMulta.Name = "dataMulta";
            this.dataMulta.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // penalidade
            // 
            this.penalidade.HeaderText = "Penalidade";
            this.penalidade.Name = "penalidade";
            this.penalidade.ReadOnly = true;
            // 
            // cpfDoMultado
            // 
            this.cpfDoMultado.HeaderText = "CPF do multado";
            this.cpfDoMultado.Name = "cpfDoMultado";
            this.cpfDoMultado.ReadOnly = true;
            // 
            // transferida
            // 
            this.transferida.HeaderText = "Transferida";
            this.transferida.Name = "transferida";
            this.transferida.ReadOnly = true;
            // 
            // justificada
            // 
            this.justificada.HeaderText = "Justificada";
            this.justificada.Name = "justificada";
            this.justificada.ReadOnly = true;
            // 
            // justificacao
            // 
            this.justificacao.HeaderText = "Justificativa";
            this.justificacao.Name = "justificacao";
            this.justificacao.ReadOnly = true;
            // 
            // frmRelatorioMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 636);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnTodas);
            this.Controls.Add(this.rbtnJustificadas);
            this.Controls.Add(this.rbtnTransferidas);
            this.Controls.Add(this.rbtnNaoPagas);
            this.Controls.Add(this.rbtnPagas);
            this.Controls.Add(this.dtgMultas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioMultas";
            this.Text = "Relatório de multas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMultas;
        private System.Windows.Forms.RadioButton rbtnPagas;
        private System.Windows.Forms.RadioButton rbtnNaoPagas;
        private System.Windows.Forms.RadioButton rbtnTransferidas;
        private System.Windows.Forms.RadioButton rbtnJustificadas;
        private System.Windows.Forms.RadioButton rbtnTodas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPlacas;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn penalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDoMultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferida;
        private System.Windows.Forms.DataGridViewTextBoxColumn justificada;
        private System.Windows.Forms.DataGridViewTextBoxColumn justificacao;
    }
}