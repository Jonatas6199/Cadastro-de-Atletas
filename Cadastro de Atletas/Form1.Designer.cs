namespace Cadastro_de_Atletas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtNacionalidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbxGenero = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtModalidade = new TextBox();
            dtpNascimento = new DateTimePicker();
            label5 = new Label();
            cbxTipoSanguineo = new ComboBox();
            label6 = new Label();
            txtAlergia = new TextBox();
            label7 = new Label();
            txtPeso = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            txtAltura = new MaskedTextBox();
            panel1 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            btnCadastrar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location = new Point(139, 73);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(100, 23);
            txtNacionalidade.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 44);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Nacionalidade";
            // 
            // cbxGenero
            // 
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Location = new Point(295, 73);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(121, 23);
            cbxGenero.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 44);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Gênero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 44);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "Modalidade";
            // 
            // txtModalidade
            // 
            txtModalidade.Location = new Point(445, 73);
            txtModalidade.Name = "txtModalidade";
            txtModalidade.Size = new Size(100, 23);
            txtModalidade.TabIndex = 7;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(140, 126);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(276, 23);
            dtpNascimento.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 132);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 10;
            label5.Text = "Data de Nascimento";
            // 
            // cbxTipoSanguineo
            // 
            cbxTipoSanguineo.FormattingEnabled = true;
            cbxTipoSanguineo.Location = new Point(39, 45);
            cbxTipoSanguineo.Name = "cbxTipoSanguineo";
            cbxTipoSanguineo.Size = new Size(121, 23);
            cbxTipoSanguineo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 16);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 12;
            label6.Text = "Tipo Sanguíneo";
            // 
            // txtAlergia
            // 
            txtAlergia.Location = new Point(39, 110);
            txtAlergia.Multiline = true;
            txtAlergia.Name = "txtAlergia";
            txtAlergia.Size = new Size(444, 96);
            txtAlergia.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 92);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 14;
            label7.Text = "Alergias";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(267, 45);
            txtPeso.Mask = "000.00";
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(267, 27);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 16;
            label8.Text = "Peso";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 27);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 18;
            label9.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(383, 45);
            txtAltura.Mask = "0.00";
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtAlergia);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(cbxTipoSanguineo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(30, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 281);
            panel1.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(30, 296);
            label10.Name = "label10";
            label10.Size = new Size(196, 28);
            label10.TabIndex = 20;
            label10.Text = "Informações Médicas";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtNacionalidade);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtpNascimento);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cbxGenero);
            panel2.Controls.Add(txtModalidade);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(30, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 223);
            panel2.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(30, 15);
            label11.Name = "label11";
            label11.Size = new Size(144, 28);
            label11.TabIndex = 22;
            label11.Text = "Dados Pessoais";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(265, 658);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 23;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 718);
            Controls.Add(btnCadastrar);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Cadastrar Atleta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtNacionalidade;
        private Label label1;
        private Label label2;
        private ComboBox cbxGenero;
        private Label label3;
        private Label label4;
        private TextBox txtModalidade;
        private DateTimePicker dtpNascimento;
        private Label label5;
        private ComboBox cbxTipoSanguineo;
        private Label label6;
        private TextBox txtAlergia;
        private Label label7;
        private MaskedTextBox txtPeso;
        private Label label8;
        private Label label9;
        private MaskedTextBox txtAltura;
        private Panel panel1;
        private Label label10;
        private Panel panel2;
        private Label label11;
        private Button btnCadastrar;
    }
}
