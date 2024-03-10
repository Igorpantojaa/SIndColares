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
            SuspendLayout();
            // 
            // BTN_NovoCadastro
            // 
            BTN_NovoCadastro.BackgroundImage = (Image)resources.GetObject("BTN_NovoCadastro.BackgroundImage");
            BTN_NovoCadastro.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_NovoCadastro.Location = new Point(121, 120);
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
            BTN_PesquisarCadastro.Location = new Point(277, 120);
            BTN_PesquisarCadastro.Name = "BTN_PesquisarCadastro";
            BTN_PesquisarCadastro.Size = new Size(90, 96);
            BTN_PesquisarCadastro.TabIndex = 1;
            BTN_PesquisarCadastro.UseVisualStyleBackColor = true;
            // 
            // LBL_NovoCadastro
            // 
            LBL_NovoCadastro.AutoSize = true;
            LBL_NovoCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_NovoCadastro.Location = new Point(122, 102);
            LBL_NovoCadastro.Name = "LBL_NovoCadastro";
            LBL_NovoCadastro.Size = new Size(88, 15);
            LBL_NovoCadastro.TabIndex = 2;
            LBL_NovoCadastro.Text = "Novo Cadastro";
            // 
            // LBL_ProcurarCadastro
            // 
            LBL_ProcurarCadastro.AutoSize = true;
            LBL_ProcurarCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_ProcurarCadastro.Location = new Point(269, 102);
            LBL_ProcurarCadastro.Name = "LBL_ProcurarCadastro";
            LBL_ProcurarCadastro.Size = new Size(106, 15);
            LBL_ProcurarCadastro.TabIndex = 3;
            LBL_ProcurarCadastro.Text = "Procurar Cadastro";
            // 
            // FRM_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 319);
            Controls.Add(LBL_ProcurarCadastro);
            Controls.Add(LBL_NovoCadastro);
            Controls.Add(BTN_PesquisarCadastro);
            Controls.Add(BTN_NovoCadastro);
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
    }
}