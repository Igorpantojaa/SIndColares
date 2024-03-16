namespace SINDCOLARES
{
    partial class FRM_GestaoAssociados
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
            groupBox1 = new GroupBox();
            DGV_Associados = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getCPFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getRGDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataNascimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            associadoBindingSource = new BindingSource(components);
            BTN_Novo = new Button();
            BTN_Alterar = new Button();
            BTN_Excluir = new Button();
            groupBox2 = new GroupBox();
            PB_FotoAssociado = new PictureBox();
            BTN_Fechar = new Button();
            TXB_Pesquisa = new TextBox();
            CB_TermoPesquisa = new ComboBox();
            BTN_LimpaPesquisa = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Associados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associadoBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_FotoAssociado).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DGV_Associados);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Associados";
            // 
            // DGV_Associados
            // 
            DGV_Associados.AllowUserToAddRows = false;
            DGV_Associados.AllowUserToDeleteRows = false;
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
            DGV_Associados.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, getCPFDataGridViewTextBoxColumn, getRGDataGridViewTextBoxColumn, dataNascimentoDataGridViewTextBoxColumn });
            DGV_Associados.DataSource = associadoBindingSource;
            DGV_Associados.Dock = DockStyle.Fill;
            DGV_Associados.Location = new Point(3, 19);
            DGV_Associados.MultiSelect = false;
            DGV_Associados.Name = "DGV_Associados";
            DGV_Associados.ReadOnly = true;
            DGV_Associados.RowHeadersVisible = false;
            DGV_Associados.RowTemplate.Height = 25;
            DGV_Associados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Associados.Size = new Size(525, 374);
            DGV_Associados.TabIndex = 0;
            DGV_Associados.CellClick += DGV_Associados_CellClick;
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
            nomeDataGridViewTextBoxColumn.HeaderText = "Associado";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getCPFDataGridViewTextBoxColumn
            // 
            getCPFDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            getCPFDataGridViewTextBoxColumn.DataPropertyName = "GetCPF";
            getCPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            getCPFDataGridViewTextBoxColumn.Name = "getCPFDataGridViewTextBoxColumn";
            getCPFDataGridViewTextBoxColumn.ReadOnly = true;
            getCPFDataGridViewTextBoxColumn.Width = 53;
            // 
            // getRGDataGridViewTextBoxColumn
            // 
            getRGDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            getRGDataGridViewTextBoxColumn.DataPropertyName = "GetRG";
            getRGDataGridViewTextBoxColumn.HeaderText = "RG";
            getRGDataGridViewTextBoxColumn.Name = "getRGDataGridViewTextBoxColumn";
            getRGDataGridViewTextBoxColumn.ReadOnly = true;
            getRGDataGridViewTextBoxColumn.Width = 47;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            dataNascimentoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data Nascimento";
            dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            dataNascimentoDataGridViewTextBoxColumn.Width = 123;
            // 
            // associadoBindingSource
            // 
            associadoBindingSource.DataSource = typeof(Modelos.Associado);
            // 
            // BTN_Novo
            // 
            BTN_Novo.Location = new Point(549, 151);
            BTN_Novo.Name = "BTN_Novo";
            BTN_Novo.Size = new Size(115, 42);
            BTN_Novo.TabIndex = 1;
            BTN_Novo.Text = "Novo";
            BTN_Novo.UseVisualStyleBackColor = true;
            BTN_Novo.Click += BTN_Novo_Click;
            // 
            // BTN_Alterar
            // 
            BTN_Alterar.Location = new Point(549, 199);
            BTN_Alterar.Name = "BTN_Alterar";
            BTN_Alterar.Size = new Size(115, 42);
            BTN_Alterar.TabIndex = 2;
            BTN_Alterar.Text = "Alterar";
            BTN_Alterar.UseVisualStyleBackColor = true;
            BTN_Alterar.Click += BTN_Alterar_Click;
            // 
            // BTN_Excluir
            // 
            BTN_Excluir.Location = new Point(549, 248);
            BTN_Excluir.Name = "BTN_Excluir";
            BTN_Excluir.Size = new Size(115, 42);
            BTN_Excluir.TabIndex = 3;
            BTN_Excluir.Text = "Excluir";
            BTN_Excluir.UseVisualStyleBackColor = true;
            BTN_Excluir.Click += BTN_Excluir_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PB_FotoAssociado);
            groupBox2.Location = new Point(549, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(115, 133);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Foto";
            // 
            // PB_FotoAssociado
            // 
            PB_FotoAssociado.Dock = DockStyle.Fill;
            PB_FotoAssociado.Location = new Point(3, 19);
            PB_FotoAssociado.Name = "PB_FotoAssociado";
            PB_FotoAssociado.Size = new Size(109, 111);
            PB_FotoAssociado.SizeMode = PictureBoxSizeMode.Zoom;
            PB_FotoAssociado.TabIndex = 0;
            PB_FotoAssociado.TabStop = false;
            // 
            // BTN_Fechar
            // 
            BTN_Fechar.Location = new Point(549, 401);
            BTN_Fechar.Name = "BTN_Fechar";
            BTN_Fechar.Size = new Size(115, 42);
            BTN_Fechar.TabIndex = 5;
            BTN_Fechar.Text = "Fechar";
            BTN_Fechar.UseVisualStyleBackColor = true;
            BTN_Fechar.Click += BTN_Fechar_Click;
            // 
            // TXB_Pesquisa
            // 
            TXB_Pesquisa.Location = new Point(139, 12);
            TXB_Pesquisa.Name = "TXB_Pesquisa";
            TXB_Pesquisa.Size = new Size(143, 23);
            TXB_Pesquisa.TabIndex = 6;
            // 
            // CB_TermoPesquisa
            // 
            CB_TermoPesquisa.FormattingEnabled = true;
            CB_TermoPesquisa.Location = new Point(12, 12);
            CB_TermoPesquisa.Name = "CB_TermoPesquisa";
            CB_TermoPesquisa.Size = new Size(121, 23);
            CB_TermoPesquisa.TabIndex = 7;
            // 
            // BTN_LimpaPesquisa
            // 
            BTN_LimpaPesquisa.Location = new Point(288, 12);
            BTN_LimpaPesquisa.Name = "BTN_LimpaPesquisa";
            BTN_LimpaPesquisa.Size = new Size(88, 23);
            BTN_LimpaPesquisa.TabIndex = 8;
            BTN_LimpaPesquisa.Text = "Novo";
            BTN_LimpaPesquisa.UseVisualStyleBackColor = true;
            // 
            // FRM_GestaoAssociados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(BTN_LimpaPesquisa);
            Controls.Add(CB_TermoPesquisa);
            Controls.Add(TXB_Pesquisa);
            Controls.Add(BTN_Fechar);
            Controls.Add(groupBox2);
            Controls.Add(BTN_Excluir);
            Controls.Add(BTN_Alterar);
            Controls.Add(BTN_Novo);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FRM_GestaoAssociados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestaoAssociados";
            Load += GestaoAssociados_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Associados).EndInit();
            ((System.ComponentModel.ISupportInitialize)associadoBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_FotoAssociado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BTN_Novo;
        private Button BTN_Alterar;
        private Button BTN_Excluir;
        private GroupBox groupBox2;
        private Button BTN_Fechar;
        private TextBox TXB_Pesquisa;
        private ComboBox CB_TermoPesquisa;
        private Button BTN_LimpaPesquisa;
        private PictureBox PB_FotoAssociado;
        private DataGridView DGV_Associados;
        private BindingSource associadoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn getCPFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn getRGDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
    }
}