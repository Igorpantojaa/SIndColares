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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
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
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            GP_Documentos = new GroupBox();
            CHB_DecResidencia = new CheckBox();
            CHB_ReqSeguroDefeso = new CheckBox();
            CHB_RegInicial = new CheckBox();
            CHB_Filiacao = new CheckBox();
            GP_Periodo = new GroupBox();
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
            GP_Associados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Associados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associadoBindingSource).BeginInit();
            GP_FormatoSaida.SuspendLayout();
            GP_Documentos.SuspendLayout();
            GP_Periodo.SuspendLayout();
            GP_Periodo2.SuspendLayout();
            GP_Periodo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)periodoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GP_Associados
            // 
            GP_Associados.Controls.Add(DGV_Associados);
            GP_Associados.Location = new Point(12, 41);
            GP_Associados.Name = "GP_Associados";
            GP_Associados.Size = new Size(511, 223);
            GP_Associados.TabIndex = 0;
            GP_Associados.TabStop = false;
            GP_Associados.Text = "Selecione o Associado";
            // 
            // DGV_Associados
            // 
            DGV_Associados.AllowUserToAddRows = false;
            DGV_Associados.AllowUserToDeleteRows = false;
            DGV_Associados.AutoGenerateColumns = false;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            DGV_Associados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            DGV_Associados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Associados.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, getRGDataGridViewTextBoxColumn, getCPFDataGridViewTextBoxColumn });
            DGV_Associados.DataSource = associadoBindingSource;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = SystemColors.Window;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            DGV_Associados.DefaultCellStyle = dataGridViewCellStyle17;
            DGV_Associados.Dock = DockStyle.Fill;
            DGV_Associados.Location = new Point(3, 19);
            DGV_Associados.MultiSelect = false;
            DGV_Associados.Name = "DGV_Associados";
            DGV_Associados.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            DGV_Associados.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            DGV_Associados.RowHeadersVisible = false;
            DGV_Associados.RowTemplate.Height = 25;
            DGV_Associados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Associados.Size = new Size(505, 201);
            DGV_Associados.TabIndex = 0;
            DGV_Associados.CellContentClick += DGV_Associados_CellContentClick;
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
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            nomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getRGDataGridViewTextBoxColumn
            // 
            getRGDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            getRGDataGridViewTextBoxColumn.DataPropertyName = "GetRG";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            getRGDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            getRGDataGridViewTextBoxColumn.HeaderText = "RG";
            getRGDataGridViewTextBoxColumn.Name = "getRGDataGridViewTextBoxColumn";
            getRGDataGridViewTextBoxColumn.ReadOnly = true;
            getRGDataGridViewTextBoxColumn.Width = 70;
            // 
            // getCPFDataGridViewTextBoxColumn
            // 
            getCPFDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            getCPFDataGridViewTextBoxColumn.DataPropertyName = "GetCPF";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            getCPFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
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
            GP_FormatoSaida.Controls.Add(radioButton2);
            GP_FormatoSaida.Controls.Add(radioButton1);
            GP_FormatoSaida.Location = new Point(529, 41);
            GP_FormatoSaida.Name = "GP_FormatoSaida";
            GP_FormatoSaida.Size = new Size(127, 81);
            GP_FormatoSaida.TabIndex = 4;
            GP_FormatoSaida.TabStop = false;
            GP_FormatoSaida.Text = "Formato de Saída";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Arquivo PDF";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(99, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Arquivo Word";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // GP_Documentos
            // 
            GP_Documentos.Controls.Add(CHB_DecResidencia);
            GP_Documentos.Controls.Add(CHB_ReqSeguroDefeso);
            GP_Documentos.Controls.Add(CHB_RegInicial);
            GP_Documentos.Controls.Add(CHB_Filiacao);
            GP_Documentos.Location = new Point(529, 131);
            GP_Documentos.Name = "GP_Documentos";
            GP_Documentos.Size = new Size(127, 133);
            GP_Documentos.TabIndex = 5;
            GP_Documentos.TabStop = false;
            GP_Documentos.Text = "Documentos";
            // 
            // CHB_DecResidencia
            // 
            CHB_DecResidencia.AutoSize = true;
            CHB_DecResidencia.Location = new Point(9, 97);
            CHB_DecResidencia.Name = "CHB_DecResidencia";
            CHB_DecResidencia.Size = new Size(108, 19);
            CHB_DecResidencia.TabIndex = 3;
            CHB_DecResidencia.Text = "Dec. Residência";
            CHB_DecResidencia.UseVisualStyleBackColor = true;
            // 
            // CHB_ReqSeguroDefeso
            // 
            CHB_ReqSeguroDefeso.AutoSize = true;
            CHB_ReqSeguroDefeso.Location = new Point(9, 75);
            CHB_ReqSeguroDefeso.Name = "CHB_ReqSeguroDefeso";
            CHB_ReqSeguroDefeso.Size = new Size(102, 19);
            CHB_ReqSeguroDefeso.TabIndex = 2;
            CHB_ReqSeguroDefeso.Text = "Seguro Defeso";
            CHB_ReqSeguroDefeso.UseVisualStyleBackColor = true;
            // 
            // CHB_RegInicial
            // 
            CHB_RegInicial.AutoSize = true;
            CHB_RegInicial.Location = new Point(9, 49);
            CHB_RegInicial.Name = "CHB_RegInicial";
            CHB_RegInicial.Size = new Size(103, 19);
            CHB_RegInicial.TabIndex = 1;
            CHB_RegInicial.Text = "Registro Inicial";
            CHB_RegInicial.UseVisualStyleBackColor = true;
            // 
            // CHB_Filiacao
            // 
            CHB_Filiacao.AutoSize = true;
            CHB_Filiacao.Location = new Point(9, 24);
            CHB_Filiacao.Name = "CHB_Filiacao";
            CHB_Filiacao.Size = new Size(66, 19);
            CHB_Filiacao.TabIndex = 0;
            CHB_Filiacao.Text = "Filiação";
            CHB_Filiacao.UseVisualStyleBackColor = true;
            // 
            // GP_Periodo
            // 
            GP_Periodo.Controls.Add(GP_Periodo2);
            GP_Periodo.Controls.Add(LBL_DataPublicacao);
            GP_Periodo.Controls.Add(label1);
            GP_Periodo.Controls.Add(GP_Periodo1);
            GP_Periodo.Controls.Add(CB_Vigencia);
            GP_Periodo.Location = new Point(15, 270);
            GP_Periodo.Name = "GP_Periodo";
            GP_Periodo.Size = new Size(508, 156);
            GP_Periodo.TabIndex = 6;
            GP_Periodo.TabStop = false;
            GP_Periodo.Text = "Selecione a Vigência";
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
            LBL_DataPublicacao.Location = new Point(333, 25);
            LBL_DataPublicacao.Name = "LBL_DataPublicacao";
            LBL_DataPublicacao.Size = new Size(76, 17);
            LBL_DataPublicacao.TabIndex = 4;
            LBL_DataPublicacao.Text = "00/00/0000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 25);
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
            CB_Vigencia.Location = new Point(104, 22);
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
            BTN_GeraDocumentos.Location = new Point(529, 316);
            BTN_GeraDocumentos.Name = "BTN_GeraDocumentos";
            BTN_GeraDocumentos.Size = new Size(122, 40);
            BTN_GeraDocumentos.TabIndex = 7;
            BTN_GeraDocumentos.Text = "Gerar Documentos";
            BTN_GeraDocumentos.UseVisualStyleBackColor = true;
            // 
            // BTN_Fechar
            // 
            BTN_Fechar.Location = new Point(529, 388);
            BTN_Fechar.Name = "BTN_Fechar";
            BTN_Fechar.Size = new Size(122, 40);
            BTN_Fechar.TabIndex = 8;
            BTN_Fechar.Text = "Fechar";
            BTN_Fechar.UseVisualStyleBackColor = true;
            BTN_Fechar.Click += BTN_Fechar_Click;
            // 
            // BTN_VerCadastro
            // 
            BTN_VerCadastro.Location = new Point(529, 270);
            BTN_VerCadastro.Name = "BTN_VerCadastro";
            BTN_VerCadastro.Size = new Size(122, 40);
            BTN_VerCadastro.TabIndex = 9;
            BTN_VerCadastro.Text = "Ver Cadastro";
            BTN_VerCadastro.UseVisualStyleBackColor = true;
            BTN_VerCadastro.Click += BTN_VerCadastro_Click;
            // 
            // FRM_GerarDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 440);
            ControlBox = false;
            Controls.Add(BTN_VerCadastro);
            Controls.Add(BTN_Fechar);
            Controls.Add(BTN_GeraDocumentos);
            Controls.Add(GP_Periodo);
            Controls.Add(GP_Documentos);
            Controls.Add(GP_FormatoSaida);
            Controls.Add(BTN_LimpaPesquisa);
            Controls.Add(TXB_Pesquisa);
            Controls.Add(GP_Associados);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GP_Associados;
        private DataGridView DGV_Associados;
        private TextBox TXB_Pesquisa;
        private Button BTN_LimpaPesquisa;
        private GroupBox GP_FormatoSaida;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
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
    }
}