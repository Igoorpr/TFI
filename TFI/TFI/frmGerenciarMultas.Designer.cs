namespace TFI {
    partial class frmGerenciarMultas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarMultas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblCPFMultado = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnQuitarMulta = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dtgMultas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtIDT = new System.Windows.Forms.TextBox();
            this.btnTransferirMulta = new System.Windows.Forms.Button();
            this.lblPlacaT = new System.Windows.Forms.Label();
            this.lblCPFMultadoJ = new System.Windows.Forms.Label();
            this.txtIDJ = new System.Windows.Forms.TextBox();
            this.btnJustificarMulta = new System.Windows.Forms.Button();
            this.lblPlacaJ = new System.Windows.Forms.Label();
            this.lblTransferirCPF = new System.Windows.Forms.Label();
            this.lblIDT = new System.Windows.Forms.Label();
            this.lblIDJ = new System.Windows.Forms.Label();
            this.txtJustificacao = new System.Windows.Forms.TextBox();
            this.lblJustificacaoJ = new System.Windows.Forms.Label();
            this.rbtnQuitar = new System.Windows.Forms.RadioButton();
            this.rbtnTransferir = new System.Windows.Forms.RadioButton();
            this.rbtnJustificar = new System.Windows.Forms.RadioButton();
            this.dtgVeiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtPlacaQuitar = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFMultado = new System.Windows.Forms.MaskedTextBox();
            this.txtPlacaT = new System.Windows.Forms.MaskedTextBox();
            this.txtNovoCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtPlacaJ = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFMultadoJ = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa para verificar multas:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(386, 235);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(112, 35);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblCPFMultado
            // 
            this.lblCPFMultado.AutoSize = true;
            this.lblCPFMultado.Location = new System.Drawing.Point(1072, 286);
            this.lblCPFMultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPFMultado.Name = "lblCPFMultado";
            this.lblCPFMultado.Size = new System.Drawing.Size(127, 20);
            this.lblCPFMultado.TabIndex = 41;
            this.lblCPFMultado.Text = "CPF do Multado:";
            this.lblCPFMultado.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(1173, 182);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(82, 26);
            this.txtID.TabIndex = 35;
            this.txtID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1072, 186);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(95, 20);
            this.lblID.TabIndex = 39;
            this.lblID.Text = "ID da multa:";
            this.lblID.Visible = false;
            // 
            // btnQuitarMulta
            // 
            this.btnQuitarMulta.Location = new System.Drawing.Point(1155, 337);
            this.btnQuitarMulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitarMulta.Name = "btnQuitarMulta";
            this.btnQuitarMulta.Size = new System.Drawing.Size(124, 54);
            this.btnQuitarMulta.TabIndex = 36;
            this.btnQuitarMulta.Text = "Quitar (pagar) multa";
            this.btnQuitarMulta.UseVisualStyleBackColor = true;
            this.btnQuitarMulta.Visible = false;
            this.btnQuitarMulta.Click += new System.EventHandler(this.btnQuitarMulta_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(1072, 235);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(52, 20);
            this.lblPlaca.TabIndex = 38;
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.Visible = false;
            // 
            // dtgMultas
            // 
            this.dtgMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
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
            this.dtgMultas.Location = new System.Drawing.Point(844, 440);
            this.dtgMultas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgMultas.Name = "dtgMultas";
            this.dtgMultas.RowHeadersWidth = 62;
            this.dtgMultas.Size = new System.Drawing.Size(813, 520);
            this.dtgMultas.TabIndex = 37;
            this.dtgMultas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgMultas_CellFormatting);
            // 
            // id
            // 
            this.id.HeaderText = "ID da multa";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.MinimumWidth = 8;
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            this.placa.Width = 150;
            // 
            // motivo
            // 
            this.motivo.HeaderText = "Motivo";
            this.motivo.MinimumWidth = 8;
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            this.motivo.Width = 150;
            // 
            // quitada
            // 
            this.quitada.HeaderText = "Paga";
            this.quitada.MinimumWidth = 8;
            this.quitada.Name = "quitada";
            this.quitada.ReadOnly = true;
            this.quitada.Width = 150;
            // 
            // gravidade
            // 
            this.gravidade.HeaderText = "Gravidade";
            this.gravidade.MinimumWidth = 8;
            this.gravidade.Name = "gravidade";
            this.gravidade.ReadOnly = true;
            this.gravidade.Width = 150;
            // 
            // dataMulta
            // 
            this.dataMulta.HeaderText = "Data da multa";
            this.dataMulta.MinimumWidth = 8;
            this.dataMulta.Name = "dataMulta";
            this.dataMulta.ReadOnly = true;
            this.dataMulta.Width = 150;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 8;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 150;
            // 
            // penalidade
            // 
            this.penalidade.HeaderText = "Penalidade";
            this.penalidade.MinimumWidth = 8;
            this.penalidade.Name = "penalidade";
            this.penalidade.ReadOnly = true;
            this.penalidade.Width = 150;
            // 
            // cpfDoMultado
            // 
            this.cpfDoMultado.HeaderText = "CPF do multado";
            this.cpfDoMultado.MinimumWidth = 8;
            this.cpfDoMultado.Name = "cpfDoMultado";
            this.cpfDoMultado.ReadOnly = true;
            this.cpfDoMultado.Width = 150;
            // 
            // transferida
            // 
            this.transferida.HeaderText = "Transferida";
            this.transferida.MinimumWidth = 8;
            this.transferida.Name = "transferida";
            this.transferida.ReadOnly = true;
            this.transferida.Width = 150;
            // 
            // justificada
            // 
            this.justificada.HeaderText = "Justificada";
            this.justificada.MinimumWidth = 8;
            this.justificada.Name = "justificada";
            this.justificada.ReadOnly = true;
            this.justificada.Width = 150;
            // 
            // justificacao
            // 
            this.justificacao.HeaderText = "Justificativa";
            this.justificacao.MinimumWidth = 8;
            this.justificacao.Name = "justificacao";
            this.justificacao.ReadOnly = true;
            this.justificacao.Width = 150;
            // 
            // txtIDT
            // 
            this.txtIDT.Location = new System.Drawing.Point(1173, 182);
            this.txtIDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDT.Name = "txtIDT";
            this.txtIDT.Size = new System.Drawing.Size(82, 26);
            this.txtIDT.TabIndex = 43;
            this.txtIDT.Visible = false;
            // 
            // btnTransferirMulta
            // 
            this.btnTransferirMulta.Location = new System.Drawing.Point(1155, 337);
            this.btnTransferirMulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransferirMulta.Name = "btnTransferirMulta";
            this.btnTransferirMulta.Size = new System.Drawing.Size(124, 54);
            this.btnTransferirMulta.TabIndex = 44;
            this.btnTransferirMulta.Text = "Transferir multa";
            this.btnTransferirMulta.UseVisualStyleBackColor = true;
            this.btnTransferirMulta.Visible = false;
            this.btnTransferirMulta.Click += new System.EventHandler(this.btnTransferirMulta_Click);
            // 
            // lblPlacaT
            // 
            this.lblPlacaT.AutoSize = true;
            this.lblPlacaT.Location = new System.Drawing.Point(1072, 235);
            this.lblPlacaT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacaT.Name = "lblPlacaT";
            this.lblPlacaT.Size = new System.Drawing.Size(52, 20);
            this.lblPlacaT.TabIndex = 45;
            this.lblPlacaT.Text = "Placa:";
            this.lblPlacaT.Visible = false;
            // 
            // lblCPFMultadoJ
            // 
            this.lblCPFMultadoJ.AutoSize = true;
            this.lblCPFMultadoJ.Location = new System.Drawing.Point(1072, 288);
            this.lblCPFMultadoJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPFMultadoJ.Name = "lblCPFMultadoJ";
            this.lblCPFMultadoJ.Size = new System.Drawing.Size(127, 20);
            this.lblCPFMultadoJ.TabIndex = 55;
            this.lblCPFMultadoJ.Text = "CPF do Multado:";
            this.lblCPFMultadoJ.Visible = false;
            // 
            // txtIDJ
            // 
            this.txtIDJ.Location = new System.Drawing.Point(1173, 182);
            this.txtIDJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDJ.Name = "txtIDJ";
            this.txtIDJ.Size = new System.Drawing.Size(104, 26);
            this.txtIDJ.TabIndex = 50;
            this.txtIDJ.Visible = false;
            // 
            // btnJustificarMulta
            // 
            this.btnJustificarMulta.Location = new System.Drawing.Point(1155, 377);
            this.btnJustificarMulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJustificarMulta.Name = "btnJustificarMulta";
            this.btnJustificarMulta.Size = new System.Drawing.Size(124, 54);
            this.btnJustificarMulta.TabIndex = 51;
            this.btnJustificarMulta.Text = "Justificar multa";
            this.btnJustificarMulta.UseVisualStyleBackColor = true;
            this.btnJustificarMulta.Visible = false;
            this.btnJustificarMulta.Click += new System.EventHandler(this.btnJustificarMulta_Click);
            // 
            // lblPlacaJ
            // 
            this.lblPlacaJ.AutoSize = true;
            this.lblPlacaJ.Location = new System.Drawing.Point(1072, 235);
            this.lblPlacaJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacaJ.Name = "lblPlacaJ";
            this.lblPlacaJ.Size = new System.Drawing.Size(52, 20);
            this.lblPlacaJ.TabIndex = 52;
            this.lblPlacaJ.Text = "Placa:";
            this.lblPlacaJ.Visible = false;
            // 
            // lblTransferirCPF
            // 
            this.lblTransferirCPF.AutoSize = true;
            this.lblTransferirCPF.Location = new System.Drawing.Point(1072, 285);
            this.lblTransferirCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransferirCPF.Name = "lblTransferirCPF";
            this.lblTransferirCPF.Size = new System.Drawing.Size(161, 20);
            this.lblTransferirCPF.TabIndex = 57;
            this.lblTransferirCPF.Text = "Transferir para (CPF):";
            this.lblTransferirCPF.Visible = false;
            // 
            // lblIDT
            // 
            this.lblIDT.AutoSize = true;
            this.lblIDT.Location = new System.Drawing.Point(1072, 186);
            this.lblIDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDT.Name = "lblIDT";
            this.lblIDT.Size = new System.Drawing.Size(95, 20);
            this.lblIDT.TabIndex = 58;
            this.lblIDT.Text = "ID da multa:";
            this.lblIDT.Visible = false;
            // 
            // lblIDJ
            // 
            this.lblIDJ.AutoSize = true;
            this.lblIDJ.Location = new System.Drawing.Point(1072, 186);
            this.lblIDJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDJ.Name = "lblIDJ";
            this.lblIDJ.Size = new System.Drawing.Size(95, 20);
            this.lblIDJ.TabIndex = 59;
            this.lblIDJ.Text = "ID da multa:";
            this.lblIDJ.Visible = false;
            // 
            // txtJustificacao
            // 
            this.txtJustificacao.Location = new System.Drawing.Point(1173, 332);
            this.txtJustificacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJustificacao.Name = "txtJustificacao";
            this.txtJustificacao.Size = new System.Drawing.Size(148, 26);
            this.txtJustificacao.TabIndex = 60;
            this.txtJustificacao.Visible = false;
            // 
            // lblJustificacaoJ
            // 
            this.lblJustificacaoJ.AutoSize = true;
            this.lblJustificacaoJ.Location = new System.Drawing.Point(1072, 337);
            this.lblJustificacaoJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJustificacaoJ.Name = "lblJustificacaoJ";
            this.lblJustificacaoJ.Size = new System.Drawing.Size(97, 20);
            this.lblJustificacaoJ.TabIndex = 61;
            this.lblJustificacaoJ.Text = "Justificação:";
            this.lblJustificacaoJ.Visible = false;
            // 
            // rbtnQuitar
            // 
            this.rbtnQuitar.AutoSize = true;
            this.rbtnQuitar.Location = new System.Drawing.Point(916, 120);
            this.rbtnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnQuitar.Name = "rbtnQuitar";
            this.rbtnQuitar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnQuitar.Size = new System.Drawing.Size(155, 24);
            this.rbtnQuitar.TabIndex = 62;
            this.rbtnQuitar.TabStop = true;
            this.rbtnQuitar.Text = "Quitar uma multa";
            this.rbtnQuitar.UseVisualStyleBackColor = true;
            this.rbtnQuitar.CheckedChanged += new System.EventHandler(this.rbtnQuitar_CheckedChanged);
            // 
            // rbtnTransferir
            // 
            this.rbtnTransferir.AutoSize = true;
            this.rbtnTransferir.Location = new System.Drawing.Point(1100, 120);
            this.rbtnTransferir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnTransferir.Name = "rbtnTransferir";
            this.rbtnTransferir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnTransferir.Size = new System.Drawing.Size(179, 24);
            this.rbtnTransferir.TabIndex = 63;
            this.rbtnTransferir.TabStop = true;
            this.rbtnTransferir.Text = "Transferir uma multa";
            this.rbtnTransferir.UseVisualStyleBackColor = true;
            this.rbtnTransferir.CheckedChanged += new System.EventHandler(this.rbtnTransferir_CheckedChanged);
            // 
            // rbtnJustificar
            // 
            this.rbtnJustificar.AutoSize = true;
            this.rbtnJustificar.Location = new System.Drawing.Point(1311, 120);
            this.rbtnJustificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnJustificar.Name = "rbtnJustificar";
            this.rbtnJustificar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnJustificar.Size = new System.Drawing.Size(175, 24);
            this.rbtnJustificar.TabIndex = 64;
            this.rbtnJustificar.TabStop = true;
            this.rbtnJustificar.Text = "Justificar uma multa";
            this.rbtnJustificar.UseVisualStyleBackColor = true;
            this.rbtnJustificar.CheckedChanged += new System.EventHandler(this.rbtnJustificar_CheckedChanged);
            // 
            // dtgVeiculos
            // 
            this.dtgVeiculos.AllowUserToDeleteRows = false;
            this.dtgVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.chassi,
            this.modelo,
            this.ano,
            this.nomeProp,
            this.cpfProp,
            this.excluido});
            this.dtgVeiculos.Location = new System.Drawing.Point(20, 440);
            this.dtgVeiculos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgVeiculos.Name = "dtgVeiculos";
            this.dtgVeiculos.ReadOnly = true;
            this.dtgVeiculos.RowHeadersWidth = 62;
            this.dtgVeiculos.Size = new System.Drawing.Size(816, 520);
            this.dtgVeiculos.TabIndex = 65;
            this.dtgVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVeiculos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // chassi
            // 
            this.chassi.HeaderText = "Chassi";
            this.chassi.MinimumWidth = 8;
            this.chassi.Name = "chassi";
            this.chassi.ReadOnly = true;
            this.chassi.Width = 150;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.MinimumWidth = 8;
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 150;
            // 
            // ano
            // 
            this.ano.HeaderText = "Ano";
            this.ano.MinimumWidth = 8;
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            this.ano.Width = 150;
            // 
            // nomeProp
            // 
            this.nomeProp.HeaderText = "Nome proprietário";
            this.nomeProp.MinimumWidth = 8;
            this.nomeProp.Name = "nomeProp";
            this.nomeProp.ReadOnly = true;
            this.nomeProp.Width = 150;
            // 
            // cpfProp
            // 
            this.cpfProp.HeaderText = "CPF Proprietário";
            this.cpfProp.MinimumWidth = 8;
            this.cpfProp.Name = "cpfProp";
            this.cpfProp.ReadOnly = true;
            this.cpfProp.Width = 150;
            // 
            // excluido
            // 
            this.excluido.HeaderText = "Excluido";
            this.excluido.MinimumWidth = 8;
            this.excluido.Name = "excluido";
            this.excluido.ReadOnly = true;
            this.excluido.Width = 150;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(450, 169);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlaca.Mask = "AAA-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(97, 26);
            this.txtPlaca.TabIndex = 0;
            this.txtPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPlaca_MaskInputRejected);
            // 
            // txtPlacaQuitar
            // 
            this.txtPlacaQuitar.Location = new System.Drawing.Point(1137, 231);
            this.txtPlacaQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlacaQuitar.Mask = "AAA-0000";
            this.txtPlacaQuitar.Name = "txtPlacaQuitar";
            this.txtPlacaQuitar.Size = new System.Drawing.Size(84, 26);
            this.txtPlacaQuitar.TabIndex = 67;
            this.txtPlacaQuitar.Visible = false;
            // 
            // txtCPFMultado
            // 
            this.txtCPFMultado.Location = new System.Drawing.Point(1210, 280);
            this.txtCPFMultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPFMultado.Mask = "000.000.000-00";
            this.txtCPFMultado.Name = "txtCPFMultado";
            this.txtCPFMultado.Size = new System.Drawing.Size(148, 26);
            this.txtCPFMultado.TabIndex = 68;
            this.txtCPFMultado.Visible = false;
            // 
            // txtPlacaT
            // 
            this.txtPlacaT.Location = new System.Drawing.Point(1137, 231);
            this.txtPlacaT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlacaT.Mask = "AAA-0000";
            this.txtPlacaT.Name = "txtPlacaT";
            this.txtPlacaT.Size = new System.Drawing.Size(84, 26);
            this.txtPlacaT.TabIndex = 69;
            this.txtPlacaT.Visible = false;
            // 
            // txtNovoCPF
            // 
            this.txtNovoCPF.Location = new System.Drawing.Point(1232, 280);
            this.txtNovoCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNovoCPF.Mask = "000.000.000-00";
            this.txtNovoCPF.Name = "txtNovoCPF";
            this.txtNovoCPF.Size = new System.Drawing.Size(148, 26);
            this.txtNovoCPF.TabIndex = 70;
            this.txtNovoCPF.Visible = false;
            // 
            // txtPlacaJ
            // 
            this.txtPlacaJ.Location = new System.Drawing.Point(1130, 231);
            this.txtPlacaJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlacaJ.Mask = "AAA-0000";
            this.txtPlacaJ.Name = "txtPlacaJ";
            this.txtPlacaJ.Size = new System.Drawing.Size(91, 26);
            this.txtPlacaJ.TabIndex = 71;
            this.txtPlacaJ.Visible = false;
            // 
            // txtCPFMultadoJ
            // 
            this.txtCPFMultadoJ.Location = new System.Drawing.Point(1210, 280);
            this.txtCPFMultadoJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPFMultadoJ.Mask = "000.000.000-00";
            this.txtCPFMultadoJ.Name = "txtCPFMultadoJ";
            this.txtCPFMultadoJ.Size = new System.Drawing.Size(148, 26);
            this.txtCPFMultadoJ.TabIndex = 72;
            this.txtCPFMultadoJ.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 43);
            this.label2.TabIndex = 73;
            this.label2.Text = "Veículos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1122, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 43);
            this.label3.TabIndex = 74;
            this.label3.Text = "Multas";
            // 
            // frmGerenciarMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 972);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCPFMultadoJ);
            this.Controls.Add(this.txtPlacaJ);
            this.Controls.Add(this.txtNovoCPF);
            this.Controls.Add(this.txtPlacaT);
            this.Controls.Add(this.txtCPFMultado);
            this.Controls.Add(this.txtPlacaQuitar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.dtgVeiculos);
            this.Controls.Add(this.rbtnJustificar);
            this.Controls.Add(this.rbtnTransferir);
            this.Controls.Add(this.rbtnQuitar);
            this.Controls.Add(this.txtJustificacao);
            this.Controls.Add(this.lblJustificacaoJ);
            this.Controls.Add(this.lblIDJ);
            this.Controls.Add(this.lblIDT);
            this.Controls.Add(this.lblTransferirCPF);
            this.Controls.Add(this.lblCPFMultadoJ);
            this.Controls.Add(this.txtIDJ);
            this.Controls.Add(this.btnJustificarMulta);
            this.Controls.Add(this.lblPlacaJ);
            this.Controls.Add(this.txtIDT);
            this.Controls.Add(this.btnTransferirMulta);
            this.Controls.Add(this.lblPlacaT);
            this.Controls.Add(this.lblCPFMultado);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnQuitarMulta);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.dtgMultas);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGerenciarMultas";
            this.Text = "Gerenciar multas";
            this.Load += new System.EventHandler(this.frmQuitarMulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblCPFMultado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnQuitarMulta;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.DataGridView dtgMultas;
        private System.Windows.Forms.TextBox txtIDT;
        private System.Windows.Forms.Button btnTransferirMulta;
        private System.Windows.Forms.Label lblPlacaT;
        private System.Windows.Forms.Label lblCPFMultadoJ;
        private System.Windows.Forms.TextBox txtIDJ;
        private System.Windows.Forms.Button btnJustificarMulta;
        private System.Windows.Forms.Label lblPlacaJ;
        private System.Windows.Forms.Label lblTransferirCPF;
        private System.Windows.Forms.Label lblIDT;
        private System.Windows.Forms.Label lblIDJ;
        private System.Windows.Forms.TextBox txtJustificacao;
        private System.Windows.Forms.Label lblJustificacaoJ;
        private System.Windows.Forms.RadioButton rbtnQuitar;
        private System.Windows.Forms.RadioButton rbtnTransferir;
        private System.Windows.Forms.RadioButton rbtnJustificar;
        private System.Windows.Forms.DataGridView dtgVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn excluido;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.MaskedTextBox txtPlacaQuitar;
        private System.Windows.Forms.MaskedTextBox txtCPFMultado;
        private System.Windows.Forms.MaskedTextBox txtPlacaT;
        private System.Windows.Forms.MaskedTextBox txtNovoCPF;
        private System.Windows.Forms.MaskedTextBox txtPlacaJ;
        private System.Windows.Forms.MaskedTextBox txtCPFMultadoJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
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