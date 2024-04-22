namespace SINDCOLARES.Forms
{
    partial class FRM_GerarDocumentos
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            GP_Associados = new GroupBox();
            DGV_Associados = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getRGDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getCPFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            associadoBindingSource = new BindingSource(components);
            TXB_Pesquisa = new TextBox();
            BTN_LimpaPesquisa = new Button();
            GP_FormatoSaida = new GroupBox();
            RB_PDF = new RadioButton();
            RB_Word = new RadioButton();
            GP_Documentos = new GroupBox();
            CHB_Procuracao = new CheckBox();
            CHB_DecResidencia = new CheckBox();
            CHB_ReqSeguroDefeso = new CheckBox();
            CHB_RegInicial = new CheckBox();
            CHB_Filiacao = new CheckBox();
            GP_Periodo = new GroupBox();
            LBL_NumPublicacao = new Label();
            label3 = new Label();
            GP_Periodo2 = new GroupBox();
            LBL_FimPeriodo2 = new Label();
            label8 = new Label();
            LBL_InicioPeriodo2 = new Label();
            label10 = new Label();
            LBL_DataPublicacao = new Label();
            label1 = new Label();
            GP_Periodo1 = new GroupBox();
            LBL_FimPeriodo1 = new Label();
            label6 = new Label();
            LBL_InicioPeriodo1 = new Label();
            label4 = new Label();
            CB_Vigencia = new ComboBox();
            periodoBindingSource = new BindingSource(components);
            BTN_GeraDocumentos = new Button();
            BTN_Fechar = new Button();
            BTN_VerCadastro = new Button();
            groupBox1 = new GroupBox();
            CHB_PastaClienteSaida = new CheckBox();
            CHB_AbreDestino = new CheckBox();
            GP_Associados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Associados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associadoBindingSource).BeginInit();
            GP_FormatoSaida.SuspendLayout();
            GP_Documentos.SuspendLayout();
            GP_Periodo.SuspendLayout();
            GP_Periodo2.SuspendLayout();
            GP_Periodo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)periodoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GP_Associados
            // 
            GP_Associados.Controls.Add(DGV_Associados);
            GP_Associados.Location = new Point(12, 41);
            GP_Associados.Name = "GP_Associados";
            GP_Associados.Size = new Size(511, 315);
            GP_Associados.TabIndex = 0;
            GP_Associados.TabStop = false;
            GP_Associados.Text = "Selecione o Associado";
            // 
            // DGV_Associados
            // 
            DGV_Associados.AllowUserToAddRows = false;
            DGV_Associados.AllowUserToDeleteRows = false;
            DGV_Associados.AllowUserToResizeColumns = false;
            DGV_Associados.AllowUserToResizeRows = false;
            DGV_Associados.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGV_Associados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Associados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Associados.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, getRGDataGridViewTextBoxColumn, getCPFDataGridViewTextBoxColumn });
            DGV_Associados.DataSource = associadoBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DGV_Associados.DefaultCellStyle = dataGridViewCellStyle5;
            DGV_Associados.Dock = DockStyle.Fill;
            DGV_Associados.Location = new Point(3, 19);
            DGV_Associados.MultiSelect = false;
            DGV_Associados.Name = "DGV_Associados";
            DGV_Associados.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DGV_Associados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DGV_Associados.RowHeadersVisible = false;
            DGV_Associados.RowTemplate.Height = 25;
            DGV_Associados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Associados.Size = new Size(505, 293);
            DGV_Associados.TabIndex = 0;
            DGV_Associados.CellClick += DGV_Associados_CellContentClick;
            DGV_Associados.CellContentClick += DGV_Associados_CellContentClick;
            DGV_Associados.SelectionChanged += DGV_Associados_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            nomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getRGDataGridViewTextBoxColumn
            // 
            getRGDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            getRGDataGridViewTextBoxColumn.DataPropertyName = "GetRG";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            getRGDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            getRGDataGridViewTextBoxColumn.HeaderText = "RG";
            getRGDataGridViewTextBoxColumn.Name = "getRGDataGridViewTextBoxColumn";
            getRGDataGridViewTextBoxColumn.ReadOnly = true;
            getRGDataGridViewTextBoxColumn.Width = 70;
            // 
            // getCPFDataGridViewTextBoxColumn
            // 
            getCPFDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            getCPFDataGridViewTextBoxColumn.DataPropertyName = "GetCPF";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            getCPFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            getCPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            getCPFDataGridViewTextBoxColumn.Name = "getCPFDataGridViewTextBoxColumn";
            getCPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // associadoBindingSource
            // 
            associadoBindingSource.DataSource = typeof(Modelos.Associado);
            // 
            // TXB_Pesquisa
            // 
            TXB_Pesquisa.Location = new Point(15, 12);
            TXB_Pesquisa.Name = "TXB_Pesquisa";
            TXB_Pesquisa.Size = new Size(307, 23);
            TXB_Pesquisa.TabIndex = 2;
            TXB_Pesquisa.KeyPress += TXB_Pesquisa_KeyPress;
            // 
            // BTN_LimpaPesquisa
            // 
            BTN_LimpaPesquisa.Location = new Point(328, 12);
            BTN_LimpaPesquisa.Name = "BTN_LimpaPesquisa";
            BTN_LimpaPesquisa.Size = new Size(102, 23);
            BTN_LimpaPesquisa.TabIndex = 3;
            BTN_LimpaPesquisa.Text = "Limpar";
            BTN_LimpaPesquisa.UseVisualStyleBackColor = true;
            // 
            // GP_FormatoSaida
            // 
            GP_FormatoSaida.Controls.Add(RB_PDF);
            GP_FormatoSaida.Controls.Add(RB_Word);
            GP_FormatoSaida.Location = new Point(6, 69);
            GP_FormatoSaida.Name = "GP_FormatoSaida";
            GP_FormatoSaida.Size = new Size(158, 83);
            GP_FormatoSaida.TabIndex = 4;
            GP_FormatoSaida.TabStop = false;
            GP_FormatoSaida.Text = "Formato de Saída";
            // 
            // RB_PDF
            // 
            RB_PDF.AutoSize = true;
            RB_PDF.Checked = true;
            RB_PDF.Location = new Point(14, 49);
            RB_PDF.Name = "RB_PDF";
            RB_PDF.Size = new Size(91, 19);
            RB_PDF.TabIndex = 1;
            RB_PDF.TabStop = true;
            RB_PDF.Text = "Arquivo PDF";
            RB_PDF.UseVisualStyleBackColor = true;
            // 
            // RB_Word
            // 
            RB_Word.AutoSize = true;
            RB_Word.Location = new Point(14, 24);
            RB_Word.Name = "RB_Word";
            RB_Word.Size = new Size(99, 19);
            RB_Word.TabIndex = 0;
            RB_Word.Text = "Arquivo Word";
            RB_Word.UseVisualStyleBackColor = true;
            // 
            // GP_Documentos
            // 
            GP_Documentos.Controls.Add(CHB_Procuracao);
            GP_Documentos.Controls.Add(CHB_DecResidencia);
            GP_Documentos.Controls.Add(CHB_ReqSeguroDefeso);
            GP_Documentos.Controls.Add(CHB_RegInicial);
            GP_Documentos.Controls.Add(CHB_Filiacao);
            GP_Documentos.Location = new Point(529, 41);
            GP_Documentos.Name = "GP_Documentos";
            GP_Documentos.Size = new Size(169, 148);
            GP_Documentos.TabIndex = 5;
            GP_Documentos.TabStop = false;
            GP_Documentos.Text = "Documentos";
            // 
            // CHB_Procuracao
            // 
            CHB_Procuracao.AutoSize = true;
            CHB_Procuracao.Location = new Point(11, 47);
            CHB_Procuracao.Name = "CHB_Procuracao";
            CHB_Procuracao.Size = new Size(86, 19);
            CHB_Procuracao.TabIndex = 4;
            CHB_Procuracao.Text = "Procuração";
            CHB_Procuracao.UseVisualStyleBackColor = true;
            // 
            // CHB_DecResidencia
            // 
            CHB_DecResidencia.AutoSize = true;
            CHB_DecResidencia.Enabled = false;
            CHB_DecResidencia.Location = new Point(11, 122);
            CHB_DecResidencia.Name = "CHB_DecResidencia";
            CHB_DecResidencia.Size = new Size(159, 19);
            CHB_DecResidencia.TabIndex = 3;
            CHB_DecResidencia.Text = "Declaração de Residência";
            CHB_DecResidencia.UseVisualStyleBackColor = true;
            // 
            // CHB_ReqSeguroDefeso
            // 
            CHB_ReqSeguroDefeso.AutoSize = true;
            CHB_ReqSeguroDefeso.Location = new Point(11, 97);
            CHB_ReqSeguroDefeso.Name = "CHB_ReqSeguroDefeso";
            CHB_ReqSeguroDefeso.Size = new Size(147, 19);
            CHB_ReqSeguroDefeso.TabIndex = 2;
            CHB_ReqSeguroDefeso.Text = "Req.  de Seguro Defeso";
            CHB_ReqSeguroDefeso.UseVisualStyleBackColor = true;
            // 
            // CHB_RegInicial
            // 
            CHB_RegInicial.AutoSize = true;
            CHB_RegInicial.Location = new Point(11, 72);
            CHB_RegInicial.Name = "CHB_RegInicial";
            CHB_RegInicial.Size = new Size(103, 19);
            CHB_RegInicial.TabIndex = 1;
            CHB_RegInicial.Text = "Registro Inicial";
            CHB_RegInicial.UseVisualStyleBackColor = true;
            // 
            // CHB_Filiacao
            // 
            CHB_Filiacao.AutoSize = true;
            CHB_Filiacao.Location = new Point(11, 22);
            CHB_Filiacao.Name = "CHB_Filiacao";
            CHB_Filiacao.Size = new Size(143, 19);
            CHB_Filiacao.TabIndex = 0;
            CHB_Filiacao.Text = "Declaração de Filiação";
            CHB_Filiacao.UseVisualStyleBackColor = true;
            // 
            // GP_Periodo
            // 
            GP_Periodo.Controls.Add(LBL_NumPublicacao);
            GP_Periodo.Controls.Add(label3);
            GP_Periodo.Controls.Add(GP_Periodo2);
            GP_Periodo.Controls.Add(LBL_DataPublicacao);
            GP_Periodo.Controls.Add(label1);
            GP_Periodo.Controls.Add(GP_Periodo1);
            GP_Periodo.Controls.Add(CB_Vigencia);
            GP_Periodo.Location = new Point(15, 362);
            GP_Periodo.Name = "GP_Periodo";
            GP_Periodo.Size = new Size(508, 156);
            GP_Periodo.TabIndex = 6;
            GP_Periodo.TabStop = false;
            GP_Periodo.Text = "Selecione a Vigência";
            // 
            // LBL_NumPublicacao
            // 
            LBL_NumPublicacao.AutoSize = true;
            LBL_NumPublicacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_NumPublicacao.Location = new Point(437, 27);
            LBL_NumPublicacao.Name = "LBL_NumPublicacao";
            LBL_NumPublicacao.Size = new Size(53, 17);
            LBL_NumPublicacao.TabIndex = 11;
            LBL_NumPublicacao.Text = "AAA 00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 28);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 10;
            label3.Text = "Nº Publicação:";
            // 
            // GP_Periodo2
            // 
            GP_Periodo2.Controls.Add(LBL_FimPeriodo2);
            GP_Periodo2.Controls.Add(label8);
            GP_Periodo2.Controls.Add(LBL_InicioPeriodo2);
            GP_Periodo2.Controls.Add(label10);
            GP_Periodo2.Location = new Point(257, 51);
            GP_Periodo2.Name = "GP_Periodo2";
            GP_Periodo2.Size = new Size(243, 92);
            GP_Periodo2.TabIndex = 9;
            GP_Periodo2.TabStop = false;
            GP_Periodo2.Text = "2º Período";
            // 
            // LBL_FimPeriodo2
            // 
            LBL_FimPeriodo2.AutoSize = true;
            LBL_FimPeriodo2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_FimPeriodo2.Location = new Point(117, 58);
            LBL_FimPeriodo2.Name = "LBL_FimPeriodo2";
            LBL_FimPeriodo2.Size = new Size(76, 17);
            LBL_FimPeriodo2.TabIndex = 8;
            LBL_FimPeriodo2.Text = "00/00/0000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 60);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 7;
            label8.Text = "Fim:";
            // 
            // LBL_InicioPeriodo2
            // 
            LBL_InicioPeriodo2.AutoSize = true;
            LBL_InicioPeriodo2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_InicioPeriodo2.Location = new Point(117, 26);
            LBL_InicioPeriodo2.Name = "LBL_InicioPeriodo2";
            LBL_InicioPeriodo2.Size = new Size(76, 17);
            LBL_InicioPeriodo2.TabIndex = 6;
            LBL_InicioPeriodo2.Text = "00/00/0000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 28);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 5;
            label10.Text = "Início:";
            // 
            // LBL_DataPublicacao
            // 
            LBL_DataPublicacao.AutoSize = true;
            LBL_DataPublicacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_DataPublicacao.Location = new Point(247, 27);
            LBL_DataPublicacao.Name = "LBL_DataPublicacao";
            LBL_DataPublicacao.Size = new Size(76, 17);
            LBL_DataPublicacao.TabIndex = 4;
            LBL_DataPublicacao.Text = "00/00/0000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 28);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 3;
            label1.Text = "Data Publicação:";
            // 
            // GP_Periodo1
            // 
            GP_Periodo1.Controls.Add(LBL_FimPeriodo1);
            GP_Periodo1.Controls.Add(label6);
            GP_Periodo1.Controls.Add(LBL_InicioPeriodo1);
            GP_Periodo1.Controls.Add(label4);
            GP_Periodo1.Location = new Point(8, 51);
            GP_Periodo1.Name = "GP_Periodo1";
            GP_Periodo1.Size = new Size(243, 92);
            GP_Periodo1.TabIndex = 1;
            GP_Periodo1.TabStop = false;
            GP_Periodo1.Text = "!º Período";
            // 
            // LBL_FimPeriodo1
            // 
            LBL_FimPeriodo1.AutoSize = true;
            LBL_FimPeriodo1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_FimPeriodo1.Location = new Point(117, 58);
            LBL_FimPeriodo1.Name = "LBL_FimPeriodo1";
            LBL_FimPeriodo1.Size = new Size(76, 17);
            LBL_FimPeriodo1.TabIndex = 8;
            LBL_FimPeriodo1.Text = "00/00/0000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 60);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 7;
            label6.Text = "Fim:";
            // 
            // LBL_InicioPeriodo1
            // 
            LBL_InicioPeriodo1.AutoSize = true;
            LBL_InicioPeriodo1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_InicioPeriodo1.Location = new Point(117, 26);
            LBL_InicioPeriodo1.Name = "LBL_InicioPeriodo1";
            LBL_InicioPeriodo1.Size = new Size(76, 17);
            LBL_InicioPeriodo1.TabIndex = 6;
            LBL_InicioPeriodo1.Text = "00/00/0000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 28);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Início:";
            // 
            // CB_Vigencia
            // 
            CB_Vigencia.DataSource = periodoBindingSource;
            CB_Vigencia.DisplayMember = "AnoVigencia";
            CB_Vigencia.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Vigencia.FormattingEnabled = true;
            CB_Vigencia.Location = new Point(18, 24);
            CB_Vigencia.Name = "CB_Vigencia";
            CB_Vigencia.Size = new Size(108, 23);
            CB_Vigencia.TabIndex = 0;
            CB_Vigencia.ValueMember = "Id";
            CB_Vigencia.SelectionChangeCommitted += CB_Vigencia_SelectionChangeCommitted;
            // 
            // periodoBindingSource
            // 
            periodoBindingSource.DataSource = typeof(Modelos.Periodo);
            // 
            // BTN_GeraDocumentos
            // 
            BTN_GeraDocumentos.Location = new Point(535, 415);
            BTN_GeraDocumentos.Name = "BTN_GeraDocumentos";
            BTN_GeraDocumentos.Size = new Size(158, 40);
            BTN_GeraDocumentos.TabIndex = 7;
            BTN_GeraDocumentos.Text = "Gerar Documentos";
            BTN_GeraDocumentos.UseVisualStyleBackColor = true;
            BTN_GeraDocumentos.Click += BTN_GeraDocumentos_Click;
            // 
            // BTN_Fechar
            // 
            BTN_Fechar.Location = new Point(535, 478);
            BTN_Fechar.Name = "BTN_Fechar";
            BTN_Fechar.Size = new Size(158, 40);
            BTN_Fechar.TabIndex = 8;
            BTN_Fechar.Text = "Fechar";
            BTN_Fechar.UseVisualStyleBackColor = true;
            BTN_Fechar.Click += BTN_Fechar_Click;
            // 
            // BTN_VerCadastro
            // 
            BTN_VerCadastro.Location = new Point(535, 369);
            BTN_VerCadastro.Name = "BTN_VerCadastro";
            BTN_VerCadastro.Size = new Size(158, 40);
            BTN_VerCadastro.TabIndex = 9;
            BTN_VerCadastro.Text = "Ver Cadastro";
            BTN_VerCadastro.UseVisualStyleBackColor = true;
            BTN_VerCadastro.Click += BTN_VerCadastro_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CHB_PastaClienteSaida);
            groupBox1.Controls.Add(CHB_AbreDestino);
            groupBox1.Controls.Add(GP_FormatoSaida);
            groupBox1.Location = new Point(529, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 161);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opções";
            // 
            // CHB_PastaClienteSaida
            // 
            CHB_PastaClienteSaida.AutoSize = true;
            CHB_PastaClienteSaida.Location = new Point(11, 44);
            CHB_PastaClienteSaida.Name = "CHB_PastaClienteSaida";
            CHB_PastaClienteSaida.Size = new Size(147, 19);
            CHB_PastaClienteSaida.TabIndex = 2;
            CHB_PastaClienteSaida.Text = "Criar pastas individuais";
            CHB_PastaClienteSaida.UseVisualStyleBackColor = true;
            // 
            // CHB_AbreDestino
            // 
            CHB_AbreDestino.AutoSize = true;
            CHB_AbreDestino.Location = new Point(11, 19);
            CHB_AbreDestino.Name = "CHB_AbreDestino";
            CHB_AbreDestino.Size = new Size(158, 19);
            CHB_AbreDestino.TabIndex = 1;
            CHB_AbreDestino.Text = "Abrir destino ao terminar";
            CHB_AbreDestino.UseVisualStyleBackColor = true;
            // 
            // FRM_GerarDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 528);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(BTN_VerCadastro);
            Controls.Add(BTN_Fechar);
            Controls.Add(BTN_GeraDocumentos);
            Controls.Add(GP_Periodo);
            Controls.Add(GP_Documentos);
            Controls.Add(BTN_LimpaPesquisa);
            Controls.Add(TXB_Pesquisa);
            Controls.Add(GP_Associados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FRM_GerarDocumentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_GerarDocumentos";
            GP_Associados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Associados).EndInit();
            ((System.ComponentModel.ISupportInitialize)associadoBindingSource).EndInit();
            GP_FormatoSaida.ResumeLayout(false);
            GP_FormatoSaida.PerformLayout();
            GP_Documentos.ResumeLayout(false);
            GP_Documentos.PerformLayout();
            GP_Periodo.ResumeLayout(false);
            GP_Periodo.PerformLayout();
            GP_Periodo2.ResumeLayout(false);
            GP_Periodo2.PerformLayout();
            GP_Periodo1.ResumeLayout(false);
            GP_Periodo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)periodoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GP_Associados;
        private DataGridView DGV_Associados;
        private TextBox TXB_Pesquisa;
        private Button BTN_LimpaPesquisa;
        private GroupBox GP_FormatoSaida;
        private RadioButton RB_PDF;
        private RadioButton RB_Word;
        private GroupBox GP_Documentos;
        private CheckBox CHB_ReqSeguroDefeso;
        private CheckBox CHB_RegInicial;
        private CheckBox CHB_Filiacao;
        private CheckBox CHB_DecResidencia;
        private GroupBox GP_Periodo;
        private ComboBox CB_Vigencia;
        private Label LBL_DataPublicacao;
        private Label label1;
        private GroupBox GP_Periodo1;
        private GroupBox GP_Periodo2;
        private Label LBL_FimPeriodo2;
        private Label label8;
        private Label LBL_InicioPeriodo2;
        private Label label10;
        private Label LBL_FimPeriodo1;
        private Label label6;
        private Label LBL_InicioPeriodo1;
        private Label label4;
        private Button BTN_GeraDocumentos;
        private Button BTN_Fechar;
        private BindingSource associadoBindingSource;
        private Button BTN_VerCadastro;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn getRGDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn getCPFDataGridViewTextBoxColumn;
        private BindingSource periodoBindingSource;
        private CheckBox CHB_Procuracao;
        private Label LBL_NumPublicacao;
        private Label label3;
        private GroupBox groupBox1;
        private CheckBox CHB_PastaClienteSaida;
        private CheckBox CHB_AbreDestino;
    }
}