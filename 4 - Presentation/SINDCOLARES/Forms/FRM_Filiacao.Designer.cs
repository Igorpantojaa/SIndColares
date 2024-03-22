namespace SINDCOLARES.Formularios
{
    partial class FRM_Filiacao
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
            GP_Filiacao = new GroupBox();
            label4 = new Label();
            CB_UF = new ComboBox();
            label3 = new Label();
            TXB_CNPJ = new TextBox();
            label2 = new Label();
            TXB_NomeEntidade = new TextBox();
            label1 = new Label();
            CB_TipoEntidade = new ComboBox();
            CHB_Filiacao = new CheckBox();
            BTN_Cancelar = new Button();
            BTN_Salvar = new Button();
            GP_Filiacao.SuspendLayout();
            SuspendLayout();
            // 
            // GP_Filiacao
            // 
            GP_Filiacao.Controls.Add(label4);
            GP_Filiacao.Controls.Add(CB_UF);
            GP_Filiacao.Controls.Add(label3);
            GP_Filiacao.Controls.Add(TXB_CNPJ);
            GP_Filiacao.Controls.Add(label2);
            GP_Filiacao.Controls.Add(TXB_NomeEntidade);
            GP_Filiacao.Controls.Add(label1);
            GP_Filiacao.Controls.Add(CB_TipoEntidade);
            GP_Filiacao.Controls.Add(CHB_Filiacao);
            GP_Filiacao.Location = new Point(12, 12);
            GP_Filiacao.Name = "GP_Filiacao";
            GP_Filiacao.Size = new Size(279, 159);
            GP_Filiacao.TabIndex = 0;
            GP_Filiacao.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(142, 107);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "UF Entidade";
            // 
            // CB_UF
            // 
            CB_UF.FormattingEnabled = true;
            CB_UF.Location = new Point(142, 125);
            CB_UF.Name = "CB_UF";
            CB_UF.Size = new Size(126, 23);
            CB_UF.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "CNPJ Entidade";
            // 
            // TXB_CNPJ
            // 
            TXB_CNPJ.Location = new Point(6, 125);
            TXB_CNPJ.Name = "TXB_CNPJ";
            TXB_CNPJ.Size = new Size(130, 23);
            TXB_CNPJ.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome da entidade";
            // 
            // TXB_NomeEntidade
            // 
            TXB_NomeEntidade.Location = new Point(6, 81);
            TXB_NomeEntidade.Name = "TXB_NomeEntidade";
            TXB_NomeEntidade.Size = new Size(262, 23);
            TXB_NomeEntidade.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(78, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Entidade";
            // 
            // CB_TipoEntidade
            // 
            CB_TipoEntidade.FormattingEnabled = true;
            CB_TipoEntidade.Location = new Point(78, 37);
            CB_TipoEntidade.Name = "CB_TipoEntidade";
            CB_TipoEntidade.Size = new Size(190, 23);
            CB_TipoEntidade.TabIndex = 1;
            // 
            // CHB_Filiacao
            // 
            CHB_Filiacao.AutoSize = true;
            CHB_Filiacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CHB_Filiacao.Location = new Point(6, 37);
            CHB_Filiacao.Name = "CHB_Filiacao";
            CHB_Filiacao.Size = new Size(66, 19);
            CHB_Filiacao.TabIndex = 0;
            CHB_Filiacao.Text = "Filiação";
            CHB_Filiacao.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Location = new Point(198, 177);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(91, 38);
            BTN_Cancelar.TabIndex = 6;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = true;
            BTN_Cancelar.Click += BTN_Cancelar_Click;
            // 
            // BTN_Salvar
            // 
            BTN_Salvar.Location = new Point(94, 177);
            BTN_Salvar.Name = "BTN_Salvar";
            BTN_Salvar.Size = new Size(91, 38);
            BTN_Salvar.TabIndex = 5;
            BTN_Salvar.Text = "Salvar";
            BTN_Salvar.UseVisualStyleBackColor = true;
            BTN_Salvar.Click += BTN_Salvar_Click;
            // 
            // FRM_Filiacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 224);
            ControlBox = false;
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Salvar);
            Controls.Add(GP_Filiacao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FRM_Filiacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Filiacao";
            Load += FRM_Filiacao_Load;
            GP_Filiacao.ResumeLayout(false);
            GP_Filiacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GP_Filiacao;
        private Label label1;
        private ComboBox CB_TipoEntidade;
        private CheckBox CHB_Filiacao;
        private Label label4;
        private ComboBox CB_UF;
        private Label label3;
        private TextBox TXB_CNPJ;
        private Label label2;
        private TextBox TXB_NomeEntidade;
        private Button BTN_Cancelar;
        private Button BTN_Salvar;
    }
}