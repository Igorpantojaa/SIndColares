namespace SINDCOLARES
{
    partial class FRM_Cadastro
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
            GP_Formularios = new GroupBox();
            BTN_Documentos = new Button();
            BTN_Profissao = new Button();
            BTN_Endereco = new Button();
            BTN_filiacao = new Button();
            BTN_Contato = new Button();
            BTN_Escolaridade = new Button();
            GP_Foto = new GroupBox();
            GP_Info = new GroupBox();
            CB_Sexo = new ComboBox();
            DTP_DataNascimento = new DateTimePicker();
            TXB_Apelido = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            GP_DadosBasicos = new GroupBox();
            TXB_Nome = new TextBox();
            label2 = new Label();
            TXB_CPF = new TextBox();
            label1 = new Label();
            BTN_Cancelar = new Button();
            BTN_Salvar = new Button();
            BTN_Documentacao = new Button();
            GP_Formularios.SuspendLayout();
            GP_Info.SuspendLayout();
            GP_DadosBasicos.SuspendLayout();
            SuspendLayout();
            // 
            // GP_Formularios
            // 
            GP_Formularios.Controls.Add(BTN_Documentos);
            GP_Formularios.Controls.Add(BTN_Profissao);
            GP_Formularios.Controls.Add(BTN_Endereco);
            GP_Formularios.Controls.Add(BTN_filiacao);
            GP_Formularios.Controls.Add(BTN_Contato);
            GP_Formularios.Controls.Add(BTN_Escolaridade);
            GP_Formularios.Location = new Point(12, 226);
            GP_Formularios.Name = "GP_Formularios";
            GP_Formularios.Size = new Size(452, 150);
            GP_Formularios.TabIndex = 19;
            GP_Formularios.TabStop = false;
            GP_Formularios.Text = "Formulários";
            // 
            // BTN_Documentos
            // 
            BTN_Documentos.Location = new Point(14, 22);
            BTN_Documentos.Name = "BTN_Documentos";
            BTN_Documentos.Size = new Size(130, 55);
            BTN_Documentos.TabIndex = 8;
            BTN_Documentos.Text = "Documentos";
            BTN_Documentos.UseVisualStyleBackColor = true;
            BTN_Documentos.Click += BTN_Documentos_Click;
            // 
            // BTN_Profissao
            // 
            BTN_Profissao.Location = new Point(308, 82);
            BTN_Profissao.Name = "BTN_Profissao";
            BTN_Profissao.Size = new Size(130, 55);
            BTN_Profissao.TabIndex = 13;
            BTN_Profissao.Text = "Profissão";
            BTN_Profissao.UseVisualStyleBackColor = true;
            BTN_Profissao.Click += BTN_Profissao_Click;
            // 
            // BTN_Endereco
            // 
            BTN_Endereco.Location = new Point(161, 22);
            BTN_Endereco.Name = "BTN_Endereco";
            BTN_Endereco.Size = new Size(130, 55);
            BTN_Endereco.TabIndex = 9;
            BTN_Endereco.Text = "Endereço";
            BTN_Endereco.UseVisualStyleBackColor = true;
            BTN_Endereco.Click += BTN_Endereco_Click;
            // 
            // BTN_filiacao
            // 
            BTN_filiacao.Location = new Point(161, 82);
            BTN_filiacao.Name = "BTN_filiacao";
            BTN_filiacao.Size = new Size(130, 55);
            BTN_filiacao.TabIndex = 12;
            BTN_filiacao.Text = "Filiação";
            BTN_filiacao.UseVisualStyleBackColor = true;
            BTN_filiacao.Click += BTN_filiacao_Click;
            // 
            // BTN_Contato
            // 
            BTN_Contato.Location = new Point(308, 21);
            BTN_Contato.Name = "BTN_Contato";
            BTN_Contato.Size = new Size(130, 55);
            BTN_Contato.TabIndex = 10;
            BTN_Contato.Text = "Contato";
            BTN_Contato.UseVisualStyleBackColor = true;
            BTN_Contato.Click += BTN_Contato_Click;
            // 
            // BTN_Escolaridade
            // 
            BTN_Escolaridade.Location = new Point(14, 83);
            BTN_Escolaridade.Name = "BTN_Escolaridade";
            BTN_Escolaridade.Size = new Size(130, 55);
            BTN_Escolaridade.TabIndex = 11;
            BTN_Escolaridade.Text = "Escolaridade";
            BTN_Escolaridade.UseVisualStyleBackColor = true;
            BTN_Escolaridade.Click += BTN_Escolaridade_Click;
            // 
            // GP_Foto
            // 
            GP_Foto.Location = new Point(344, 12);
            GP_Foto.Name = "GP_Foto";
            GP_Foto.Size = new Size(120, 122);
            GP_Foto.TabIndex = 18;
            GP_Foto.TabStop = false;
            GP_Foto.Text = "Foto";
            // 
            // GP_Info
            // 
            GP_Info.Controls.Add(CB_Sexo);
            GP_Info.Controls.Add(DTP_DataNascimento);
            GP_Info.Controls.Add(TXB_Apelido);
            GP_Info.Controls.Add(label4);
            GP_Info.Controls.Add(label5);
            GP_Info.Controls.Add(label6);
            GP_Info.Location = new Point(12, 140);
            GP_Info.Name = "GP_Info";
            GP_Info.Size = new Size(452, 80);
            GP_Info.TabIndex = 17;
            GP_Info.TabStop = false;
            // 
            // CB_Sexo
            // 
            CB_Sexo.FormattingEnabled = true;
            CB_Sexo.Location = new Point(6, 37);
            CB_Sexo.Name = "CB_Sexo";
            CB_Sexo.Size = new Size(151, 23);
            CB_Sexo.TabIndex = 9;
            // 
            // DTP_DataNascimento
            // 
            DTP_DataNascimento.CustomFormat = "dd/MM/yyyy";
            DTP_DataNascimento.Format = DateTimePickerFormat.Custom;
            DTP_DataNascimento.Location = new Point(332, 37);
            DTP_DataNascimento.Name = "DTP_DataNascimento";
            DTP_DataNascimento.Size = new Size(114, 23);
            DTP_DataNascimento.TabIndex = 8;
            // 
            // TXB_Apelido
            // 
            TXB_Apelido.Location = new Point(163, 37);
            TXB_Apelido.Name = "TXB_Apelido";
            TXB_Apelido.Size = new Size(163, 23);
            TXB_Apelido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 19);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "Apelido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 19);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 2;
            label5.Text = "Data de Nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 0;
            label6.Text = "Sexo";
            // 
            // GP_DadosBasicos
            // 
            GP_DadosBasicos.Controls.Add(TXB_Nome);
            GP_DadosBasicos.Controls.Add(label2);
            GP_DadosBasicos.Controls.Add(TXB_CPF);
            GP_DadosBasicos.Controls.Add(label1);
            GP_DadosBasicos.Location = new Point(12, 12);
            GP_DadosBasicos.Name = "GP_DadosBasicos";
            GP_DadosBasicos.Size = new Size(326, 122);
            GP_DadosBasicos.TabIndex = 15;
            GP_DadosBasicos.TabStop = false;
            // 
            // TXB_Nome
            // 
            TXB_Nome.Location = new Point(6, 81);
            TXB_Nome.Name = "TXB_Nome";
            TXB_Nome.Size = new Size(308, 23);
            TXB_Nome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // TXB_CPF
            // 
            TXB_CPF.Location = new Point(6, 37);
            TXB_CPF.Name = "TXB_CPF";
            TXB_CPF.Size = new Size(151, 23);
            TXB_CPF.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "CPF";
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Location = new Point(373, 382);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(91, 38);
            BTN_Cancelar.TabIndex = 21;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = true;
            BTN_Cancelar.Click += BTN_Cancelar_Click;
            // 
            // BTN_Salvar
            // 
            BTN_Salvar.Location = new Point(269, 382);
            BTN_Salvar.Name = "BTN_Salvar";
            BTN_Salvar.Size = new Size(91, 38);
            BTN_Salvar.TabIndex = 20;
            BTN_Salvar.Text = "Salvar";
            BTN_Salvar.UseVisualStyleBackColor = true;
            BTN_Salvar.Click += BTN_Salvar_Click;
            // 
            // BTN_Documentacao
            // 
            BTN_Documentacao.Location = new Point(12, 382);
            BTN_Documentacao.Name = "BTN_Documentacao";
            BTN_Documentacao.Size = new Size(121, 38);
            BTN_Documentacao.TabIndex = 22;
            BTN_Documentacao.Text = "Documentação";
            BTN_Documentacao.UseVisualStyleBackColor = true;
            BTN_Documentacao.Click += BTN_Documentacao_Click;
            // 
            // FRM_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 427);
            ControlBox = false;
            Controls.Add(BTN_Documentacao);
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Salvar);
            Controls.Add(GP_Formularios);
            Controls.Add(GP_Foto);
            Controls.Add(GP_Info);
            Controls.Add(GP_DadosBasicos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FRM_Cadastro";
            Text = "FRM_Cadastro";
            GP_Formularios.ResumeLayout(false);
            GP_Info.ResumeLayout(false);
            GP_Info.PerformLayout();
            GP_DadosBasicos.ResumeLayout(false);
            GP_DadosBasicos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GP_Formularios;
        private Button BTN_Documentos;
        private Button BTN_Profissao;
        private Button BTN_Endereco;
        private Button BTN_filiacao;
        private Button BTN_Contato;
        private Button BTN_Escolaridade;
        private GroupBox GP_Foto;
        private GroupBox GP_Info;
        private ComboBox CB_Sexo;
        private DateTimePicker DTP_DataNascimento;
        private TextBox TXB_Apelido;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox GP_DadosBasicos;
        private TextBox TXB_Nome;
        private Label label2;
        private TextBox TXB_CPF;
        private Label label1;
        private Button BTN_Cancelar;
        private Button BTN_Salvar;
        private Button BTN_Documentacao;
    }
}