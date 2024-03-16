namespace SINDCOLARES
{
    partial class FRM_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Inicio));
            BTN_NovoCadastro = new Button();
            BTN_PesquisarCadastro = new Button();
            LBL_NovoCadastro = new Label();
            LBL_ProcurarCadastro = new Label();
            label1 = new Label();
            BTN_Periodos = new Button();
            label2 = new Label();
            BTN_GeraDocumentos = new Button();
            SuspendLayout();
            // 
            // BTN_NovoCadastro
            // 
            BTN_NovoCadastro.BackgroundImage = (Image)resources.GetObject("BTN_NovoCadastro.BackgroundImage");
            BTN_NovoCadastro.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_NovoCadastro.Location = new Point(121, 48);
            BTN_NovoCadastro.Name = "BTN_NovoCadastro";
            BTN_NovoCadastro.Size = new Size(90, 96);
            BTN_NovoCadastro.TabIndex = 0;
            BTN_NovoCadastro.UseVisualStyleBackColor = true;
            BTN_NovoCadastro.Click += BTN_NovoCadastro_Click;
            // 
            // BTN_PesquisarCadastro
            // 
            BTN_PesquisarCadastro.BackgroundImage = (Image)resources.GetObject("BTN_PesquisarCadastro.BackgroundImage");
            BTN_PesquisarCadastro.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_PesquisarCadastro.Location = new Point(291, 48);
            BTN_PesquisarCadastro.Name = "BTN_PesquisarCadastro";
            BTN_PesquisarCadastro.Size = new Size(90, 96);
            BTN_PesquisarCadastro.TabIndex = 1;
            BTN_PesquisarCadastro.UseVisualStyleBackColor = true;
            BTN_PesquisarCadastro.Click += BTN_PesquisarCadastro_Click;
            // 
            // LBL_NovoCadastro
            // 
            LBL_NovoCadastro.AutoSize = true;
            LBL_NovoCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_NovoCadastro.Location = new Point(122, 30);
            LBL_NovoCadastro.Name = "LBL_NovoCadastro";
            LBL_NovoCadastro.Size = new Size(88, 15);
            LBL_NovoCadastro.TabIndex = 2;
            LBL_NovoCadastro.Text = "Novo Cadastro";
            // 
            // LBL_ProcurarCadastro
            // 
            LBL_ProcurarCadastro.AutoSize = true;
            LBL_ProcurarCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_ProcurarCadastro.Location = new Point(283, 30);
            LBL_ProcurarCadastro.Name = "LBL_ProcurarCadastro";
            LBL_ProcurarCadastro.Size = new Size(106, 15);
            LBL_ProcurarCadastro.TabIndex = 3;
            LBL_ProcurarCadastro.Text = "Procurar Cadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 175);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 5;
            label1.Text = "Períodos Cadastrados";
            // 
            // BTN_Periodos
            // 
            BTN_Periodos.BackgroundImage = (Image)resources.GetObject("BTN_Periodos.BackgroundImage");
            BTN_Periodos.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_Periodos.Location = new Point(121, 193);
            BTN_Periodos.Name = "BTN_Periodos";
            BTN_Periodos.Size = new Size(90, 96);
            BTN_Periodos.TabIndex = 4;
            BTN_Periodos.UseVisualStyleBackColor = true;
            BTN_Periodos.Click += BTN_Periodos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(280, 175);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 7;
            label2.Text = "Gerar Documentos";
            // 
            // BTN_GeraDocumentos
            // 
            BTN_GeraDocumentos.BackgroundImage = (Image)resources.GetObject("BTN_GeraDocumentos.BackgroundImage");
            BTN_GeraDocumentos.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_GeraDocumentos.Location = new Point(291, 193);
            BTN_GeraDocumentos.Name = "BTN_GeraDocumentos";
            BTN_GeraDocumentos.Size = new Size(90, 96);
            BTN_GeraDocumentos.TabIndex = 6;
            BTN_GeraDocumentos.UseVisualStyleBackColor = true;
            BTN_GeraDocumentos.Click += BTN_GeraDocumentos_Click;
            // 
            // FRM_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 319);
            Controls.Add(label2);
            Controls.Add(BTN_GeraDocumentos);
            Controls.Add(label1);
            Controls.Add(BTN_Periodos);
            Controls.Add(LBL_ProcurarCadastro);
            Controls.Add(LBL_NovoCadastro);
            Controls.Add(BTN_PesquisarCadastro);
            Controls.Add(BTN_NovoCadastro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FRM_Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_NovoCadastro;
        private Button BTN_PesquisarCadastro;
        private Label LBL_NovoCadastro;
        private Label LBL_ProcurarCadastro;
        private Label label1;
        private Button BTN_Periodos;
        private Label label2;
        private Button BTN_GeraDocumentos;
    }
}