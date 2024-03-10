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
            textBox7 = new TextBox();
            label11 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            TXB_CPF = new TextBox();
            label1 = new Label();
            TXB_PIS = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 170);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 127);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(440, 23);
            textBox7.TabIndex = 16;
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
            // textBox3
            // 
            textBox3.Location = new Point(6, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(440, 23);
            textBox3.TabIndex = 5;
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
            // textBox6
            // 
            textBox6.Location = new Point(353, 39);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(93, 23);
            textBox6.TabIndex = 14;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(259, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(88, 23);
            comboBox2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(139, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 23);
            dateTimePicker1.TabIndex = 10;
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
            // textBox5
            // 
            textBox5.Location = new Point(6, 39);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 23);
            textBox5.TabIndex = 1;
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
            // button2
            // 
            button2.Location = new Point(375, 267);
            button2.Name = "button2";
            button2.Size = new Size(91, 38);
            button2.TabIndex = 20;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(271, 267);
            button1.Name = "button1";
            button1.Size = new Size(91, 38);
            button1.TabIndex = 19;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FRM_Documentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 311);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FRM_Documentos";
            Text = "FRM_Documentos";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox6;
        private Label label10;
        private Label label9;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private TextBox textBox5;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox TXB_PIS;
        private Label label2;
        private TextBox TXB_CPF;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}