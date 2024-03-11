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
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            BTN_Cancelar = new Button();
            BTN_Salvar = new Button();
            GP_Filiacao.SuspendLayout();
            SuspendLayout();
            // 
            // GP_Filiacao
            // 
            GP_Filiacao.Controls.Add(label4);
            GP_Filiacao.Controls.Add(comboBox2);
            GP_Filiacao.Controls.Add(label3);
            GP_Filiacao.Controls.Add(textBox2);
            GP_Filiacao.Controls.Add(label2);
            GP_Filiacao.Controls.Add(textBox1);
            GP_Filiacao.Controls.Add(label1);
            GP_Filiacao.Controls.Add(comboBox1);
            GP_Filiacao.Controls.Add(checkBox1);
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(142, 125);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(126, 23);
            comboBox2.TabIndex = 7;
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
            // textBox2
            // 
            textBox2.Location = new Point(6, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 5;
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
            // textBox1
            // 
            textBox1.Location = new Point(6, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 3;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(6, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Filiação";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Location = new Point(198, 177);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(91, 38);
            BTN_Cancelar.TabIndex = 12;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = true;
            // 
            // BTN_Salvar
            // 
            BTN_Salvar.Location = new Point(94, 177);
            BTN_Salvar.Name = "BTN_Salvar";
            BTN_Salvar.Size = new Size(91, 38);
            BTN_Salvar.TabIndex = 11;
            BTN_Salvar.Text = "Salvar";
            BTN_Salvar.UseVisualStyleBackColor = true;
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
            Name = "FRM_Filiacao";
            Text = "FRM_Filiacao";
            GP_Filiacao.ResumeLayout(false);
            GP_Filiacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GP_Filiacao;
        private Label label1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button BTN_Cancelar;
        private Button BTN_Salvar;
    }
}