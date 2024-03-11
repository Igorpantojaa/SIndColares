namespace SINDCOLARES.Formularios
{
    partial class FRM_Escolaridade
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
            BTN_Cancelar = new Button();
            BTN_Salvar = new Button();
            groupBox3 = new GroupBox();
            TXB_Declaração = new TextBox();
            label1 = new Label();
            CB_Escolarridade = new ComboBox();
            label14 = new Label();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Location = new Point(255, 220);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(91, 38);
            BTN_Cancelar.TabIndex = 10;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = true;
            BTN_Cancelar.Click += BTN_Cancelar_Click;
            // 
            // BTN_Salvar
            // 
            BTN_Salvar.Location = new Point(151, 220);
            BTN_Salvar.Name = "BTN_Salvar";
            BTN_Salvar.Size = new Size(91, 38);
            BTN_Salvar.TabIndex = 9;
            BTN_Salvar.Text = "Salvar";
            BTN_Salvar.UseVisualStyleBackColor = true;
            BTN_Salvar.Click += BTN_Salvar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TXB_Declaração);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(CB_Escolarridade);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 202);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // TXB_Declaração
            // 
            TXB_Declaração.Location = new Point(8, 85);
            TXB_Declaração.Multiline = true;
            TXB_Declaração.Name = "TXB_Declaração";
            TXB_Declaração.Size = new Size(318, 111);
            TXB_Declaração.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 67);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 13;
            label1.Text = "Declaração";
            // 
            // CB_Escolarridade
            // 
            CB_Escolarridade.FormattingEnabled = true;
            CB_Escolarridade.Location = new Point(8, 33);
            CB_Escolarridade.Name = "CB_Escolarridade";
            CB_Escolarridade.Size = new Size(318, 23);
            CB_Escolarridade.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(8, 15);
            label14.Name = "label14";
            label14.Size = new Size(75, 15);
            label14.TabIndex = 4;
            label14.Text = "Escolaridade";
            // 
            // FRM_Escolaridade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 270);
            ControlBox = false;
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Salvar);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FRM_Escolaridade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Escolaridade";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_Cancelar;
        private Button BTN_Salvar;
        private GroupBox groupBox3;
        private ComboBox CB_Escolarridade;
        private Label label14;
        private Label label1;
        private TextBox TXB_Declaração;
    }
}