namespace TFI {
    partial class frmOpcoesMulta {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcoesMulta));
            this.btnRelatorioMultas = new System.Windows.Forms.Button();
            this.btnGerenciarMultas = new System.Windows.Forms.Button();
            this.btnIncluirMulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRelatorioMultas
            // 
            this.btnRelatorioMultas.Location = new System.Drawing.Point(71, 166);
            this.btnRelatorioMultas.Name = "btnRelatorioMultas";
            this.btnRelatorioMultas.Size = new System.Drawing.Size(130, 40);
            this.btnRelatorioMultas.TabIndex = 2;
            this.btnRelatorioMultas.Text = "Relatório de multas";
            this.btnRelatorioMultas.UseVisualStyleBackColor = true;
            this.btnRelatorioMultas.Click += new System.EventHandler(this.btnRelatorioMultas_Click);
            // 
            // btnGerenciarMultas
            // 
            this.btnGerenciarMultas.Location = new System.Drawing.Point(71, 106);
            this.btnGerenciarMultas.Name = "btnGerenciarMultas";
            this.btnGerenciarMultas.Size = new System.Drawing.Size(130, 40);
            this.btnGerenciarMultas.TabIndex = 1;
            this.btnGerenciarMultas.Text = "Gerenciar multas";
            this.btnGerenciarMultas.UseVisualStyleBackColor = true;
            this.btnGerenciarMultas.Click += new System.EventHandler(this.btnGerenciarMultas_Click);
            // 
            // btnIncluirMulta
            // 
            this.btnIncluirMulta.Location = new System.Drawing.Point(71, 48);
            this.btnIncluirMulta.Name = "btnIncluirMulta";
            this.btnIncluirMulta.Size = new System.Drawing.Size(130, 40);
            this.btnIncluirMulta.TabIndex = 0;
            this.btnIncluirMulta.Text = "Incluir multa";
            this.btnIncluirMulta.UseVisualStyleBackColor = true;
            this.btnIncluirMulta.Click += new System.EventHandler(this.btnIncluirMulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Multas";
            // 
            // frmOpcoesMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(273, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelatorioMultas);
            this.Controls.Add(this.btnGerenciarMultas);
            this.Controls.Add(this.btnIncluirMulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpcoesMulta";
            this.Text = "Escolha uma opção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRelatorioMultas;
        private System.Windows.Forms.Button btnGerenciarMultas;
        private System.Windows.Forms.Button btnIncluirMulta;
        private System.Windows.Forms.Label label1;
    }
}