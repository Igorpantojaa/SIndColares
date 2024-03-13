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
            groupBox1 = new GroupBox();
            DGV_Periodos = new DataGridView();
            BTN_Salvar = new Button();
            BTN_Alterar = new Button();
            BTN_Excluir = new Button();
            BTN_Fechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Periodos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DGV_Periodos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 294);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Períodos Cadastrados";
            // 
            // DGV_Periodos
            // 
            DGV_Periodos.AllowUserToAddRows = false;
            DGV_Periodos.AllowUserToDeleteRows = false;
            DGV_Periodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Periodos.Dock = DockStyle.Fill;
            DGV_Periodos.Location = new Point(3, 19);
            DGV_Periodos.Name = "DGV_Periodos";
            DGV_Periodos.ReadOnly = true;
            DGV_Periodos.RowTemplate.Height = 25;
            DGV_Periodos.Size = new Size(471, 272);
            DGV_Periodos.TabIndex = 0;
            // 
            // BTN_Salvar
            // 
            BTN_Salvar.Location = new Point(495, 31);
            BTN_Salvar.Name = "BTN_Salvar";
            BTN_Salvar.Size = new Size(109, 49);
            BTN_Salvar.TabIndex = 1;
            BTN_Salvar.Text = "Salvar";
            BTN_Salvar.UseVisualStyleBackColor = true;
            // 
            // BTN_Alterar
            // 
            BTN_Alterar.Location = new Point(495, 86);
            BTN_Alterar.Name = "BTN_Alterar";
            BTN_Alterar.Size = new Size(109, 49);
            BTN_Alterar.TabIndex = 2;
            BTN_Alterar.Text = "Alterar";
            BTN_Alterar.UseVisualStyleBackColor = true;
            // 
            // BTN_Excluir
            // 
            BTN_Excluir.Location = new Point(495, 141);
            BTN_Excluir.Name = "BTN_Excluir";
            BTN_Excluir.Size = new Size(109, 49);
            BTN_Excluir.TabIndex = 3;
            BTN_Excluir.Text = "Excluir";
            BTN_Excluir.UseVisualStyleBackColor = true;
            // 
            // BTN_Fechar
            // 
            BTN_Fechar.Location = new Point(495, 254);
            BTN_Fechar.Name = "BTN_Fechar";
            BTN_Fechar.Size = new Size(109, 49);
            BTN_Fechar.TabIndex = 4;
            BTN_Fechar.Text = "Fechar";
            BTN_Fechar.UseVisualStyleBackColor = true;
            // 
            // FRM_GestaoPeriodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 320);
            ControlBox = false;
            Controls.Add(BTN_Fechar);
            Controls.Add(BTN_Excluir);
            Controls.Add(BTN_Alterar);
            Controls.Add(BTN_Salvar);
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DGV_Periodos;
        private Button BTN_Salvar;
        private Button BTN_Alterar;
        private Button BTN_Excluir;
        private Button BTN_Fechar;
    }
}