namespace Sistema
{
    partial class CadastroClientes
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbVegetariano = new System.Windows.Forms.CheckBox();
            this.ckbVegano = new System.Windows.Forms.CheckBox();
            this.ckbLactose = new System.Windows.Forms.CheckBox();
            this.ckbDiabetico = new System.Windows.Forms.CheckBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.gbxEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(259, 189);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 49);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(214, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone:";
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(15, 89);
            this.mtxtTelefone.Mask = "(99)9999-9999";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(86, 20);
            this.mtxtTelefone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Celular:";
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(143, 89);
            this.mtxtCelular.Mask = "(99)9999-9999";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(86, 20);
            this.mtxtCelular.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG"});
            this.cbxEstado.Location = new System.Drawing.Point(143, 148);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(86, 21);
            this.cbxEstado.TabIndex = 10;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstadoCivil.Controls.Add(this.rbtnSolteiro);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(15, 175);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(214, 49);
            this.gbxEstadoCivil.TabIndex = 11;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(3, 16);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbtnSolteiro.TabIndex = 0;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro(a)";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(92, 16);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(73, 17);
            this.rbtnCasado.TabIndex = 1;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado(a)";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(259, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Preferências:";
            // 
            // ckbVegetariano
            // 
            this.ckbVegetariano.AutoSize = true;
            this.ckbVegetariano.Location = new System.Drawing.Point(259, 92);
            this.ckbVegetariano.Name = "ckbVegetariano";
            this.ckbVegetariano.Size = new System.Drawing.Size(83, 17);
            this.ckbVegetariano.TabIndex = 15;
            this.ckbVegetariano.Text = "Vegetariano";
            this.ckbVegetariano.UseVisualStyleBackColor = true;
            // 
            // ckbVegano
            // 
            this.ckbVegano.AutoSize = true;
            this.ckbVegano.Location = new System.Drawing.Point(259, 115);
            this.ckbVegano.Name = "ckbVegano";
            this.ckbVegano.Size = new System.Drawing.Size(63, 17);
            this.ckbVegano.TabIndex = 16;
            this.ckbVegano.Text = "Vegano";
            this.ckbVegano.UseVisualStyleBackColor = true;
            // 
            // ckbLactose
            // 
            this.ckbLactose.AutoSize = true;
            this.ckbLactose.Location = new System.Drawing.Point(259, 138);
            this.ckbLactose.Name = "ckbLactose";
            this.ckbLactose.Size = new System.Drawing.Size(122, 17);
            this.ckbLactose.TabIndex = 17;
            this.ckbLactose.Text = "Intolerante à lactose";
            this.ckbLactose.UseVisualStyleBackColor = true;
            // 
            // ckbDiabetico
            // 
            this.ckbDiabetico.AutoSize = true;
            this.ckbDiabetico.Location = new System.Drawing.Point(259, 161);
            this.ckbDiabetico.Name = "ckbDiabetico";
            this.ckbDiabetico.Size = new System.Drawing.Size(71, 17);
            this.ckbDiabetico.TabIndex = 18;
            this.ckbDiabetico.Text = "Diabético";
            this.ckbDiabetico.UseVisualStyleBackColor = true;
            // 
            // cbxCidade
            // 
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Items.AddRange(new object[] {
            "Rio de Janeiro",
            "São Paulo",
            "Minas Gerais"});
            this.cbxCidade.Location = new System.Drawing.Point(12, 148);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(121, 21);
            this.cbxCidade.TabIndex = 19;
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 250);
            this.Controls.Add(this.cbxCidade);
            this.Controls.Add(this.ckbDiabetico);
            this.Controls.Add(this.ckbLactose);
            this.Controls.Add(this.ckbVegano);
            this.Controls.Add(this.ckbVegetariano);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtCelular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "CadastroClientes";
            this.Text = "CadastroClientes";
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbVegetariano;
        private System.Windows.Forms.CheckBox ckbVegano;
        private System.Windows.Forms.CheckBox ckbLactose;
        private System.Windows.Forms.CheckBox ckbDiabetico;
        private System.Windows.Forms.ComboBox cbxCidade;
    }
}