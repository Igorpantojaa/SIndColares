namespace SINDCOLARES.Formularios
{
    partial class FRM_GestaoPeriodos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            DGV_Periodos = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoVigenciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GetDataPublicacao = new DataGridViewTextBoxColumn();
            getInicioVigencia1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getFimVigencia1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getInicioVigencia2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getFimVigencia2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            periodoBindingSource = new BindingSource(components);
            BTN_Novo = new Button();
            BTN_Alterar = new Button();
            BTN_Excluir = new Button();
            BTN_Fechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Periodos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)periodoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DGV_Periodos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 298);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Períodos Cadastrados";
            // 
            // DGV_Periodos
            // 
            DGV_Periodos.AllowUserToAddRows = false;
            DGV_Periodos.AllowUserToDeleteRows = false;
            DGV_Periodos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGV_Periodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Periodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Periodos.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, anoVigenciaDataGridViewTextBoxColumn, GetDataPublicacao, getInicioVigencia1DataGridViewTextBoxColumn, getFimVigencia1DataGridViewTextBoxColumn, getInicioVigencia2DataGridViewTextBoxColumn, getFimVigencia2DataGridViewTextBoxColumn });
            DGV_Periodos.DataSource = periodoBindingSource;
            DGV_Periodos.Dock = DockStyle.Fill;
            DGV_Periodos.Location = new Point(3, 19);
            DGV_Periodos.Name = "DGV_Periodos";
            DGV_Periodos.ReadOnly = true;
            DGV_Periodos.RowHeadersVisible = false;
            DGV_Periodos.RowTemplate.Height = 25;
            DGV_Periodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Periodos.Size = new Size(625, 276);
            DGV_Periodos.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // anoVigenciaDataGridViewTextBoxColumn
            // 
            anoVigenciaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            anoVigenciaDataGridViewTextBoxColumn.DataPropertyName = "AnoVigencia";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            anoVigenciaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            anoVigenciaDataGridViewTextBoxColumn.HeaderText = "Vigencia";
            anoVigenciaDataGridViewTextBoxColumn.Name = "anoVigenciaDataGridViewTextBoxColumn";
            anoVigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            anoVigenciaDataGridViewTextBoxColumn.Width = 77;
            // 
            // GetDataPublicacao
            // 
            GetDataPublicacao.DataPropertyName = "GetDataPublicacao";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            GetDataPublicacao.DefaultCellStyle = dataGridViewCellStyle3;
            GetDataPublicacao.HeaderText = "Publicação";
            GetDataPublicacao.Name = "GetDataPublicacao";
            GetDataPublicacao.ReadOnly = true;
            // 
            // getInicioVigencia1DataGridViewTextBoxColumn
            // 
            getInicioVigencia1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            getInicioVigencia1DataGridViewTextBoxColumn.DataPropertyName = "GetInicioVigencia1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            getInicioVigencia1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            getInicioVigencia1DataGridViewTextBoxColumn.HeaderText = "Inicio 1ª Vigencia";
            getInicioVigencia1DataGridViewTextBoxColumn.Name = "getInicioVigencia1DataGridViewTextBoxColumn";
            getInicioVigencia1DataGridViewTextBoxColumn.ReadOnly = true;
            getInicioVigencia1DataGridViewTextBoxColumn.Width = 123;
            // 
            // getFimVigencia1DataGridViewTextBoxColumn
            // 
            getFimVigencia1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            getFimVigencia1DataGridViewTextBoxColumn.DataPropertyName = "GetFimVigencia1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            getFimVigencia1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            getFimVigencia1DataGridViewTextBoxColumn.HeaderText = "Fim 1ª Vigencia";
            getFimVigencia1DataGridViewTextBoxColumn.Name = "getFimVigencia1DataGridViewTextBoxColumn";
            getFimVigencia1DataGridViewTextBoxColumn.ReadOnly = true;
            getFimVigencia1DataGridViewTextBoxColumn.Width = 114;
            // 
            // getInicioVigencia2DataGridViewTextBoxColumn
            // 
            getInicioVigencia2DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            getInicioVigencia2DataGridViewTextBoxColumn.DataPropertyName = "GetInicioVigencia2";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            getInicioVigencia2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            getInicioVigencia2DataGridViewTextBoxColumn.HeaderText = "Início 2ª Vigencia";
            getInicioVigencia2DataGridViewTextBoxColumn.Name = "getInicioVigencia2DataGridViewTextBoxColumn";
            getInicioVigencia2DataGridViewTextBoxColumn.ReadOnly = true;
            getInicioVigencia2DataGridViewTextBoxColumn.Width = 123;
            // 
            // getFimVigencia2DataGridViewTextBoxColumn
            // 
            getFimVigencia2DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            getFimVigencia2DataGridViewTextBoxColumn.DataPropertyName = "GetFimVigencia2";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            getFimVigencia2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            getFimVigencia2DataGridViewTextBoxColumn.HeaderText = "Fim 2ª Vigencia";
            getFimVigencia2DataGridViewTextBoxColumn.Name = "getFimVigencia2DataGridViewTextBoxColumn";
            getFimVigencia2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodoBindingSource
            // 
            periodoBindingSource.DataSource = typeof(Modelos.Periodo);
            // 
            // BTN_Novo
            // 
            BTN_Novo.Location = new Point(649, 31);
            BTN_Novo.Name = "BTN_Novo";
            BTN_Novo.Size = new Size(109, 49);
            BTN_Novo.TabIndex = 1;
            BTN_Novo.Text = "Novo";
            BTN_Novo.UseVisualStyleBackColor = true;
            BTN_Novo.Click += BTN_Novo_Click;
            // 
            // BTN_Alterar
            // 
            BTN_Alterar.Location = new Point(649, 86);
            BTN_Alterar.Name = "BTN_Alterar";
            BTN_Alterar.Size = new Size(109, 49);
            BTN_Alterar.TabIndex = 2;
            BTN_Alterar.Text = "Alterar";
            BTN_Alterar.UseVisualStyleBackColor = true;
            BTN_Alterar.Click += BTN_Alterar_Click;
            // 
            // BTN_Excluir
            // 
            BTN_Excluir.Location = new Point(649, 141);
            BTN_Excluir.Name = "BTN_Excluir";
            BTN_Excluir.Size = new Size(109, 49);
            BTN_Excluir.TabIndex = 3;
            BTN_Excluir.Text = "Excluir";
            BTN_Excluir.UseVisualStyleBackColor = true;
            BTN_Excluir.Click += BTN_Excluir_Click;
            // 
            // BTN_Fechar
            // 
            BTN_Fechar.Location = new Point(649, 254);
            BTN_Fechar.Name = "BTN_Fechar";
            BTN_Fechar.Size = new Size(109, 49);
            BTN_Fechar.TabIndex = 4;
            BTN_Fechar.Text = "Fechar";
            BTN_Fechar.UseVisualStyleBackColor = true;
            BTN_Fechar.Click += BTN_Fechar_Click;
            // 
            // FRM_GestaoPeriodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 320);
            ControlBox = false;
            Controls.Add(BTN_Fechar);
            Controls.Add(BTN_Excluir);
            Controls.Add(BTN_Alterar);
            Controls.Add(BTN_Novo);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_GestaoPeriodos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_GestaoPeriodos";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Periodos).EndInit();
            ((System.ComponentModel.ISupportInitialize)periodoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DGV_Periodos;
        private Button BTN_Novo;
        private Button BTN_Alterar;
        private Button BTN_Excluir;
        private Button BTN_Fechar;
        private BindingSource periodoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoVigenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn GetDataPublicacao;
        private DataGridViewTextBoxColumn getInicioVigencia1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn getFimVigencia1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn getInicioVigencia2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn getFimVigencia2DataGridViewTextBoxColumn;
    }
}