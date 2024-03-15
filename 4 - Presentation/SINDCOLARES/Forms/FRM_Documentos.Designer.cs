namespace SINDCOLARES.Formularios
{
    partial class FRM_Documentos
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
            groupBox2 = new GroupBox();
            TXB_NomeMae = new TextBox();
            label11 = new Label();
            TXB_NomePai = new TextBox();
            label3 = new Label();
            TXB_OrgaoEmissor = new TextBox();
            label10 = new Label();
            label9 = new Label();
            CB_EstadoEmissao = new ComboBox();
            DTP_DataEmissao = new DateTimePicker();
            label8 = new Label();
            TXB_RG = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            TXB_PIS = new TextBox();
            label2 = new Label();
            TXB_CPF = new TextBox();
            label1 = new Label();
            BTN_Cancelar = new Button();
            BTN_Salvar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TXB_NomeMae);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(TXB_NomePai);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TXB_OrgaoEmissor);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(CB_EstadoEmissao);
            groupBox2.Controls.Add(DTP_DataEmissao);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(TXB_RG);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 170);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // TXB_NomeMae
            // 
            TXB_NomeMae.Location = new Point(6, 127);
            TXB_NomeMae.Name = "TXB_NomeMae";
            TXB_NomeMae.Size = new Size(440, 23);
            TXB_NomeMae.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 109);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 15;
            label11.Text = "Nome da Mãe";
            // 
            // TXB_NomePai
            // 
            TXB_NomePai.Location = new Point(6, 83);
            TXB_NomePai.Name = "TXB_NomePai";
            TXB_NomePai.Size = new Size(440, 23);
            TXB_NomePai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 65);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome do Pai";
            // 
            // TXB_OrgaoEmissor
            // 
            TXB_OrgaoEmissor.Location = new Point(353, 39);
            TXB_OrgaoEmissor.Name = "TXB_OrgaoEmissor";
            TXB_OrgaoEmissor.Size = new Size(93, 23);
            TXB_OrgaoEmissor.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(353, 21);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 13;
            label10.Text = "Órgão Emissor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(259, 21);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 11;
            label9.Text = "Estado Emissão";
            // 
            // CB_EstadoEmissao
            // 
            CB_EstadoEmissao.FormattingEnabled = true;
            CB_EstadoEmissao.Location = new Point(259, 39);
            CB_EstadoEmissao.Name = "CB_EstadoEmissao";
            CB_EstadoEmissao.Size = new Size(88, 23);
            CB_EstadoEmissao.TabIndex = 10;
            // 
            // DTP_DataEmissao
            // 
            DTP_DataEmissao.CustomFormat = "dd/MM/yyyy";
            DTP_DataEmissao.Format = DateTimePickerFormat.Custom;
            DTP_DataEmissao.Location = new Point(139, 39);
            DTP_DataEmissao.Name = "DTP_DataEmissao";
            DTP_DataEmissao.Size = new Size(114, 23);
            DTP_DataEmissao.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(139, 21);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 4;
            label8.Text = "Data de Emissão";
            // 
            // TXB_RG
            // 
            TXB_RG.Location = new Point(6, 39);
            TXB_RG.Name = "TXB_RG";
            TXB_RG.Size = new Size(127, 23);
            TXB_RG.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 21);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 0;
            label7.Text = "RG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TXB_PIS);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TXB_CPF);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 73);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // TXB_PIS
            // 
            TXB_PIS.Location = new Point(256, 33);
            TXB_PIS.Name = "TXB_PIS";
            TXB_PIS.Size = new Size(171, 23);
            TXB_PIS.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(253, 15);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "PIS/NIS";
            // 
            // TXB_CPF
            // 
            TXB_CPF.Location = new Point(27, 35);
            TXB_CPF.Name = "TXB_CPF";
            TXB_CPF.Size = new Size(171, 23);
            TXB_CPF.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Location = new Point(375, 267);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(91, 38);
            BTN_Cancelar.TabIndex = 20;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = true;
            BTN_Cancelar.Click += BTN_Cancelar_Click;
            // 
            // BTN_Salvar
            // 
            BTN_Salvar.Location = new Point(271, 267);
            BTN_Salvar.Name = "BTN_Salvar";
            BTN_Salvar.Size = new Size(91, 38);
            BTN_Salvar.TabIndex = 19;
            BTN_Salvar.Text = "Salvar";
            BTN_Salvar.UseVisualStyleBackColor = true;
            BTN_Salvar.Click += BTN_Salvar_Click;
            // 
            // FRM_Documentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 311);
            ControlBox = false;
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Salvar);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FRM_Documentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Documentos";
            Load += FRM_Documentos_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox TXB_NomeMae;
        private Label label11;
        private TextBox TXB_NomePai;
        private Label label3;
        private TextBox TXB_OrgaoEmissor;
        private Label label10;
        private Label label9;
        private ComboBox CB_EstadoEmissao;
        private DateTimePicker DTP_DataEmissao;
        private Label label8;
        private TextBox TXB_RG;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox TXB_PIS;
        private Label label2;
        private TextBox TXB_CPF;
        private Label label1;
        private Button BTN_Cancelar;
        private Button BTN_Salvar;
    }
}