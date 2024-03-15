namespace SINDCOLARES.Formularios
{
    partial class FRM_CadastraPeriodo
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
            label1 = new Label();
            LBL_Periodo1inicio = new GroupBox();
            CHB_Periodo1 = new CheckBox();
            LBL_Periodo1Fim = new Label();
            DTP_Periodo1Fim = new DateTimePicker();
            DTP_Periodo1Inicio = new DateTimePicker();
            groupBox2 = new GroupBox();
            CHB_Periodo2 = new CheckBox();
            LBL_Periodo2Fim = new Label();
            DTP_Periodo2Fim = new DateTimePicker();
            DTP_Periodo2Inicio = new DateTimePicker();
            LBL_Periodo2inicio = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            TXB_Especies = new TextBox();
            BTN_Salvar = new Button();
            BTN_Cancelar = new Button();
            DTP_DataPublicacao = new DateTimePicker();
            label2 = new Label();
            LBL_Vigencia = new Label();
            LBL_Periodo1inicio.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 44);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "1º Período - Início";
            // 
            // LBL_Periodo1inicio
            // 
            LBL_Periodo1inicio.Controls.Add(CHB_Periodo1);
            LBL_Periodo1inicio.Controls.Add(LBL_Periodo1Fim);
            LBL_Periodo1inicio.Controls.Add(DTP_Periodo1Fim);
            LBL_Periodo1inicio.Controls.Add(DTP_Periodo1Inicio);
            LBL_Periodo1inicio.Controls.Add(label1);
            LBL_Periodo1inicio.Location = new Point(12, 41);
            LBL_Periodo1inicio.Name = "LBL_Periodo1inicio";
            LBL_Periodo1inicio.Size = new Size(321, 118);
            LBL_Periodo1inicio.TabIndex = 1;
            LBL_Periodo1inicio.TabStop = false;
            // 
            // CHB_Periodo1
            // 
            CHB_Periodo1.AutoSize = true;
            CHB_Periodo1.Checked = true;
            CHB_Periodo1.CheckState = CheckState.Checked;
            CHB_Periodo1.Location = new Point(8, 22);
            CHB_Periodo1.Name = "CHB_Periodo1";
            CHB_Periodo1.Size = new Size(81, 19);
            CHB_Periodo1.TabIndex = 6;
            CHB_Periodo1.Text = "1º Período";
            CHB_Periodo1.UseVisualStyleBackColor = true;
            CHB_Periodo1.CheckedChanged += CHB_Periodo1_CheckedChanged;
            CHB_Periodo1.CheckStateChanged += CHB_Periodo1_CheckedChanged;
            // 
            // LBL_Periodo1Fim
            // 
            LBL_Periodo1Fim.AutoSize = true;
            LBL_Periodo1Fim.Location = new Point(8, 82);
            LBL_Periodo1Fim.Name = "LBL_Periodo1Fim";
            LBL_Periodo1Fim.Size = new Size(93, 15);
            LBL_Periodo1Fim.TabIndex = 4;
            LBL_Periodo1Fim.Text = "1º Período - Fim";
            // 
            // DTP_Periodo1Fim
            // 
            DTP_Periodo1Fim.Format = DateTimePickerFormat.Short;
            DTP_Periodo1Fim.Location = new Point(115, 78);
            DTP_Periodo1Fim.Name = "DTP_Periodo1Fim";
            DTP_Periodo1Fim.Size = new Size(200, 23);
            DTP_Periodo1Fim.TabIndex = 3;
            // 
            // DTP_Periodo1Inicio
            // 
            DTP_Periodo1Inicio.Format = DateTimePickerFormat.Short;
            DTP_Periodo1Inicio.Location = new Point(114, 41);
            DTP_Periodo1Inicio.Name = "DTP_Periodo1Inicio";
            DTP_Periodo1Inicio.Size = new Size(200, 23);
            DTP_Periodo1Inicio.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CHB_Periodo2);
            groupBox2.Controls.Add(LBL_Periodo2Fim);
            groupBox2.Controls.Add(DTP_Periodo2Fim);
            groupBox2.Controls.Add(DTP_Periodo2Inicio);
            groupBox2.Controls.Add(LBL_Periodo2inicio);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 121);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // CHB_Periodo2
            // 
            CHB_Periodo2.AutoSize = true;
            CHB_Periodo2.Location = new Point(6, 22);
            CHB_Periodo2.Name = "CHB_Periodo2";
            CHB_Periodo2.Size = new Size(81, 19);
            CHB_Periodo2.TabIndex = 5;
            CHB_Periodo2.Text = "2º Período";
            CHB_Periodo2.UseVisualStyleBackColor = true;
            CHB_Periodo2.CheckedChanged += CHB_Periodo1_CheckedChanged;
            CHB_Periodo2.CheckStateChanged += CHB_Periodo1_CheckedChanged;
            // 
            // LBL_Periodo2Fim
            // 
            LBL_Periodo2Fim.AutoSize = true;
            LBL_Periodo2Fim.Enabled = false;
            LBL_Periodo2Fim.Location = new Point(6, 87);
            LBL_Periodo2Fim.Name = "LBL_Periodo2Fim";
            LBL_Periodo2Fim.Size = new Size(93, 15);
            LBL_Periodo2Fim.TabIndex = 4;
            LBL_Periodo2Fim.Text = "2º Período - Fim";
            // 
            // DTP_Periodo2Fim
            // 
            DTP_Periodo2Fim.Enabled = false;
            DTP_Periodo2Fim.Format = DateTimePickerFormat.Short;
            DTP_Periodo2Fim.Location = new Point(114, 81);
            DTP_Periodo2Fim.Name = "DTP_Periodo2Fim";
            DTP_Periodo2Fim.Size = new Size(200, 23);
            DTP_Periodo2Fim.TabIndex = 3;
            // 
            // DTP_Periodo2Inicio
            // 
            DTP_Periodo2Inicio.Enabled = false;
            DTP_Periodo2Inicio.Format = DateTimePickerFormat.Short;
            DTP_Periodo2Inicio.Location = new Point(114, 46);
            DTP_Periodo2Inicio.Name = "DTP_Periodo2Inicio";
            DTP_Periodo2Inicio.Size = new Size(200, 23);
            DTP_Periodo2Inicio.TabIndex = 1;
            // 
            // LBL_Periodo2inicio
            // 
            LBL_Periodo2inicio.AutoSize = true;
            LBL_Periodo2inicio.Enabled = false;
            LBL_Periodo2inicio.Location = new Point(7, 50);
            LBL_Periodo2inicio.Name = "LBL_Periodo2inicio";
            LBL_Periodo2inicio.Size = new Size(102, 15);
            LBL_Periodo2inicio.TabIndex = 0;
            LBL_Periodo2inicio.Text = "2º Período - Início";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 19);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 5;
            label5.Text = "Vigência:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TXB_Especies);
            groupBox3.Location = new Point(12, 292);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(321, 93);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Espécies";
            // 
            // TXB_Especies
            // 
            TXB_Especies.Location = new Point(8, 22);
            TXB_Especies.Multiline = true;
            TXB_Especies.Name = "TXB_Especies";
            TXB_Especies.Size = new Size(307, 65);
            TXB_Especies.TabIndex = 0;
            // 
            // BTN_Salvar
            // 
            BTN_Salvar.Location = new Point(71, 391);
            BTN_Salvar.Name = "BTN_Salvar";
            BTN_Salvar.Size = new Size(99, 38);
            BTN_Salvar.TabIndex = 8;
            BTN_Salvar.Text = "Salvar";
            BTN_Salvar.UseVisualStyleBackColor = true;
            BTN_Salvar.Click += BTN_Salvar_Click;
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Location = new Point(176, 391);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(99, 38);
            BTN_Cancelar.TabIndex = 9;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = true;
            BTN_Cancelar.Click += BTN_Cancelar_Click;
            // 
            // DTP_DataPublicacao
            // 
            DTP_DataPublicacao.CustomFormat = "";
            DTP_DataPublicacao.Format = DateTimePickerFormat.Short;
            DTP_DataPublicacao.Location = new Point(225, 15);
            DTP_DataPublicacao.MinDate = new DateTime(2019, 1, 1, 0, 0, 0, 0);
            DTP_DataPublicacao.Name = "DTP_DataPublicacao";
            DTP_DataPublicacao.Size = new Size(108, 23);
            DTP_DataPublicacao.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 19);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 10;
            label2.Text = "Data Publicação";
            // 
            // LBL_Vigencia
            // 
            LBL_Vigencia.AutoSize = true;
            LBL_Vigencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_Vigencia.Location = new Point(69, 19);
            LBL_Vigencia.Name = "LBL_Vigencia";
            LBL_Vigencia.Size = new Size(0, 17);
            LBL_Vigencia.TabIndex = 12;
            // 
            // FRM_CadastraPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 439);
            ControlBox = false;
            Controls.Add(LBL_Vigencia);
            Controls.Add(DTP_DataPublicacao);
            Controls.Add(label2);
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Salvar);
            Controls.Add(groupBox3);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(LBL_Periodo1inicio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FRM_CadastraPeriodo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_CadastraPeriodo";
            LBL_Periodo1inicio.ResumeLayout(false);
            LBL_Periodo1inicio.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox LBL_Periodo1inicio;
        private DateTimePicker DTP_Periodo1Fim;
        private DateTimePicker DTP_Periodo1Inicio;
        private Label LBL_Periodo1Fim;
        private GroupBox groupBox2;
        private Label LBL_Periodo2Fim;
        private DateTimePicker DTP_Periodo2Fim;
        private DateTimePicker DTP_Periodo2Inicio;
        private Label LBL_Periodo2inicio;
        private Label label5;
        private GroupBox groupBox3;
        private TextBox TXB_Especies;
        private CheckBox CHB_Periodo1;
        private CheckBox CHB_Periodo2;
        private Button BTN_Salvar;
        private Button BTN_Cancelar;
        private DateTimePicker DTP_DataPublicacao;
        private Label label2;
        private Label LBL_Vigencia;
    }
}