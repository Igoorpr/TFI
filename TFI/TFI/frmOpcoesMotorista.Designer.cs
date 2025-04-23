namespace TFI {
    partial class frmOpcoesMotorista {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcoesMotorista));
            this.btnIncluirMotorista = new System.Windows.Forms.Button();
            this.btnRelatorioMotoristas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIncluirMotorista
            // 
            this.btnIncluirMotorista.Location = new System.Drawing.Point(71, 59);
            this.btnIncluirMotorista.Name = "btnIncluirMotorista";
            this.btnIncluirMotorista.Size = new System.Drawing.Size(130, 40);
            this.btnIncluirMotorista.TabIndex = 0;
            this.btnIncluirMotorista.Text = "Incluir motorista";
            this.btnIncluirMotorista.UseVisualStyleBackColor = true;
            this.btnIncluirMotorista.Click += new System.EventHandler(this.btnIncluirMotorista_Click);
            // 
            // btnRelatorioMotoristas
            // 
            this.btnRelatorioMotoristas.Location = new System.Drawing.Point(71, 140);
            this.btnRelatorioMotoristas.Name = "btnRelatorioMotoristas";
            this.btnRelatorioMotoristas.Size = new System.Drawing.Size(130, 40);
            this.btnRelatorioMotoristas.TabIndex = 1;
            this.btnRelatorioMotoristas.Text = "Relatório de motoristas";
            this.btnRelatorioMotoristas.UseVisualStyleBackColor = true;
            this.btnRelatorioMotoristas.Click += new System.EventHandler(this.btnRelatorioMotoristas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Motoristas";
            // 
            // frmOpcoesMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelatorioMotoristas);
            this.Controls.Add(this.btnIncluirMotorista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpcoesMotorista";
            this.Text = "Escolha uma opção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluirMotorista;
        private System.Windows.Forms.Button btnRelatorioMotoristas;
        private System.Windows.Forms.Label label1;
    }
}