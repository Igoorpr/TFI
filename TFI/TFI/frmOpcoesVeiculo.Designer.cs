namespace TFI {
    partial class frmOpcoesVeiculo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcoesVeiculo));
            this.btnExcluirVeiculos = new System.Windows.Forms.Button();
            this.btnIncluirVeiculo = new System.Windows.Forms.Button();
            this.btnRelatorioVeiculos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExcluirVeiculos
            // 
            this.btnExcluirVeiculos.Location = new System.Drawing.Point(70, 106);
            this.btnExcluirVeiculos.Name = "btnExcluirVeiculos";
            this.btnExcluirVeiculos.Size = new System.Drawing.Size(130, 40);
            this.btnExcluirVeiculos.TabIndex = 1;
            this.btnExcluirVeiculos.Text = "Excluir veículos";
            this.btnExcluirVeiculos.UseVisualStyleBackColor = true;
            this.btnExcluirVeiculos.Click += new System.EventHandler(this.btnExcluirVeiculos_Click);
            // 
            // btnIncluirVeiculo
            // 
            this.btnIncluirVeiculo.Location = new System.Drawing.Point(70, 48);
            this.btnIncluirVeiculo.Name = "btnIncluirVeiculo";
            this.btnIncluirVeiculo.Size = new System.Drawing.Size(130, 40);
            this.btnIncluirVeiculo.TabIndex = 0;
            this.btnIncluirVeiculo.Text = "Incluir veículo";
            this.btnIncluirVeiculo.UseVisualStyleBackColor = true;
            this.btnIncluirVeiculo.Click += new System.EventHandler(this.btnIncluirVeiculo_Click);
            // 
            // btnRelatorioVeiculos
            // 
            this.btnRelatorioVeiculos.Location = new System.Drawing.Point(70, 166);
            this.btnRelatorioVeiculos.Name = "btnRelatorioVeiculos";
            this.btnRelatorioVeiculos.Size = new System.Drawing.Size(130, 40);
            this.btnRelatorioVeiculos.TabIndex = 2;
            this.btnRelatorioVeiculos.Text = "Relatório de veículos";
            this.btnRelatorioVeiculos.UseVisualStyleBackColor = true;
            this.btnRelatorioVeiculos.Click += new System.EventHandler(this.btnRelatorioVeiculos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veículos";
            // 
            // frmOpcoesVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelatorioVeiculos);
            this.Controls.Add(this.btnExcluirVeiculos);
            this.Controls.Add(this.btnIncluirVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpcoesVeiculo";
            this.Text = "Escolha uma opção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirVeiculos;
        private System.Windows.Forms.Button btnIncluirVeiculo;
        private System.Windows.Forms.Button btnRelatorioVeiculos;
        private System.Windows.Forms.Label label1;
    }
}