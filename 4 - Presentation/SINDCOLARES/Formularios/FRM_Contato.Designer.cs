namespace SINDCOLARES.Formularios
{
    partial class FRM_Contato
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
            TXB_Email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TXB_Telefone = new TextBox();
            BTN_Cancelar = new Button();
            BTN_Salvar = new Button();
            SuspendLayout();
            // 
            // TXB_Email
            // 
            TXB_Email.Location = new Point(12, 30);
            TXB_Email.Name = "TXB_Email";
            TXB_Email.Size = new Size(203, 23);
            TXB_Email.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "E-Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // TXB_Telefone
            // 
            TXB_Telefone.Location = new Point(12, 74);
            TXB_Telefone.Name = "TXB_Telefone";
            TXB_Telefone.Size = new Size(203, 23);
            TXB_Telefone.TabIndex = 2;
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Location = new Point(120, 116);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(91, 38);
            BTN_Cancelar.TabIndex = 9;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = true;
            BTN_Cancelar.Click += BTN_Cancelar_Click;
            // 
            // BTN_Salvar
            // 
            BTN_Salvar.Location = new Point(16, 116);
            BTN_Salvar.Name = "BTN_Salvar";
            BTN_Salvar.Size = new Size(91, 38);
            BTN_Salvar.TabIndex = 8;
            BTN_Salvar.Text = "Salvar";
            BTN_Salvar.UseVisualStyleBackColor = true;
            BTN_Salvar.Click += BTN_Salvar_Click;
            // 
            // FRM_Contato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 171);
            ControlBox = false;
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Salvar);
            Controls.Add(label2);
            Controls.Add(TXB_Telefone);
            Controls.Add(label1);
            Controls.Add(TXB_Email);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FRM_Contato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXB_Email;
        private Label label1;
        private Label label2;
        private TextBox TXB_Telefone;
        private Button BTN_Cancelar;
        private Button BTN_Salvar;
    }
}