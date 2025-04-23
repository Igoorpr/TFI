namespace TFI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMotoristas = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnMultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(194, 170);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 31);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair e salvar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu";
            // 
            // btnMotoristas
            // 
            this.btnMotoristas.Location = new System.Drawing.Point(50, 87);
            this.btnMotoristas.Name = "btnMotoristas";
            this.btnMotoristas.Size = new System.Drawing.Size(99, 31);
            this.btnMotoristas.TabIndex = 0;
            this.btnMotoristas.Text = "Motoristas";
            this.btnMotoristas.UseVisualStyleBackColor = true;
            this.btnMotoristas.Click += new System.EventHandler(this.btnMotoristas_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.Location = new System.Drawing.Point(194, 87);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(99, 31);
            this.btnVeiculos.TabIndex = 1;
            this.btnVeiculos.Text = "Veículos";
            this.btnVeiculos.UseVisualStyleBackColor = true;
            this.btnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // btnMultas
            // 
            this.btnMultas.Location = new System.Drawing.Point(50, 170);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Size = new System.Drawing.Size(99, 31);
            this.btnMultas.TabIndex = 2;
            this.btnMultas.Text = "Multas";
            this.btnMultas.UseVisualStyleBackColor = true;
            this.btnMultas.Click += new System.EventHandler(this.btnMultas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(348, 254);
            this.Controls.Add(this.btnMultas);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnMotoristas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMotoristas;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnMultas;
    }
}

