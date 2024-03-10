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
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            CB_UF = new ComboBox();
            label14 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(255, 141);
            button2.Name = "button2";
            button2.Size = new Size(91, 38);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(151, 141);
            button1.Name = "button1";
            button1.Size = new Size(91, 38);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(CB_UF);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 123);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // CB_UF
            // 
            CB_UF.FormattingEnabled = true;
            CB_UF.Location = new Point(8, 33);
            CB_UF.Name = "CB_UF";
            CB_UF.Size = new Size(318, 23);
            CB_UF.TabIndex = 12;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 23);
            comboBox1.TabIndex = 14;
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
            // FRM_Escolaridade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 188);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FRM_Escolaridade";
            Text = "FRM_Escolaridade";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private ComboBox CB_UF;
        private Label label14;
        private ComboBox comboBox1;
        private Label label1;
    }
}