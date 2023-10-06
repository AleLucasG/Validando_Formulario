namespace Front_End
{
    partial class F_Formulario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Formulario));
            this.lbl0_TituloCadatroPessoas = new System.Windows.Forms.Label();
            this.txtBox1_CPF = new System.Windows.Forms.TextBox();
            this.lbl1_CPF = new System.Windows.Forms.Label();
            this.lbl2_Nome = new System.Windows.Forms.Label();
            this.lbl3_Sexo = new System.Windows.Forms.Label();
            this.lbl4_Nascimento = new System.Windows.Forms.Label();
            this.lbl6_End = new System.Windows.Forms.Label();
            this.lbl7_Bairro = new System.Windows.Forms.Label();
            this.lbl8_Municipio = new System.Windows.Forms.Label();
            this.lbl9_Estado = new System.Windows.Forms.Label();
            this.txtBox2_Nome = new System.Windows.Forms.TextBox();
            this.txtBox3_Nasc = new System.Windows.Forms.TextBox();
            this.txtBox4_End = new System.Windows.Forms.TextBox();
            this.txtBox5_Bairro = new System.Windows.Forms.TextBox();
            this.txtBox6_Municipio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1_Sexo = new System.Windows.Forms.ComboBox();
            this.lbl5_Idade = new System.Windows.Forms.Label();
            this.txtBox8_Idade = new System.Windows.Forms.TextBox();
            this.comboBox2_Estado = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl10_CEP = new System.Windows.Forms.Label();
            this.lbl11_Email = new System.Windows.Forms.Label();
            this.txtBox9_CEP = new System.Windows.Forms.TextBox();
            this.txtBox10_Email = new System.Windows.Forms.TextBox();
            this.lbl12_Telefone = new System.Windows.Forms.Label();
            this.txtBox11_Telefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl0_TituloCadatroPessoas
            // 
            this.lbl0_TituloCadatroPessoas.AutoSize = true;
            this.lbl0_TituloCadatroPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0_TituloCadatroPessoas.Location = new System.Drawing.Point(255, 50);
            this.lbl0_TituloCadatroPessoas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl0_TituloCadatroPessoas.Name = "lbl0_TituloCadatroPessoas";
            this.lbl0_TituloCadatroPessoas.Size = new System.Drawing.Size(225, 20);
            this.lbl0_TituloCadatroPessoas.TabIndex = 20;
            this.lbl0_TituloCadatroPessoas.Text = "CADASTRO DE PESSOAS";
            // 
            // txtBox1_CPF
            // 
            this.txtBox1_CPF.Location = new System.Drawing.Point(164, 116);
            this.txtBox1_CPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox1_CPF.Name = "txtBox1_CPF";
            this.txtBox1_CPF.Size = new System.Drawing.Size(171, 20);
            this.txtBox1_CPF.TabIndex = 0;
            this.txtBox1_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox1_CPF_KeyPress);
            // 
            // lbl1_CPF
            // 
            this.lbl1_CPF.AutoSize = true;
            this.lbl1_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_CPF.Location = new System.Drawing.Point(126, 119);
            this.lbl1_CPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1_CPF.Name = "lbl1_CPF";
            this.lbl1_CPF.Size = new System.Drawing.Size(30, 13);
            this.lbl1_CPF.TabIndex = 21;
            this.lbl1_CPF.Text = "CPF";
            // 
            // lbl2_Nome
            // 
            this.lbl2_Nome.AutoSize = true;
            this.lbl2_Nome.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.lbl2_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2_Nome.Location = new System.Drawing.Point(43, 161);
            this.lbl2_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2_Nome.Name = "lbl2_Nome";
            this.lbl2_Nome.Size = new System.Drawing.Size(114, 13);
            this.lbl2_Nome.TabIndex = 22;
            this.lbl2_Nome.Text = "NOME COMPLETO";
            // 
            // lbl3_Sexo
            // 
            this.lbl3_Sexo.AutoSize = true;
            this.lbl3_Sexo.Location = new System.Drawing.Point(116, 203);
            this.lbl3_Sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3_Sexo.Name = "lbl3_Sexo";
            this.lbl3_Sexo.Size = new System.Drawing.Size(40, 13);
            this.lbl3_Sexo.TabIndex = 23;
            this.lbl3_Sexo.Text = "SEXO";
            // 
            // lbl4_Nascimento
            // 
            this.lbl4_Nascimento.AutoSize = true;
            this.lbl4_Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4_Nascimento.Location = new System.Drawing.Point(69, 245);
            this.lbl4_Nascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4_Nascimento.Name = "lbl4_Nascimento";
            this.lbl4_Nascimento.Size = new System.Drawing.Size(88, 13);
            this.lbl4_Nascimento.TabIndex = 24;
            this.lbl4_Nascimento.Text = "NASCIMENTO";
            // 
            // lbl6_End
            // 
            this.lbl6_End.AutoSize = true;
            this.lbl6_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6_End.Location = new System.Drawing.Point(78, 329);
            this.lbl6_End.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6_End.Name = "lbl6_End";
            this.lbl6_End.Size = new System.Drawing.Size(75, 13);
            this.lbl6_End.TabIndex = 26;
            this.lbl6_End.Text = "ENDEREÇO";
            // 
            // lbl7_Bairro
            // 
            this.lbl7_Bairro.AutoSize = true;
            this.lbl7_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7_Bairro.Location = new System.Drawing.Point(99, 371);
            this.lbl7_Bairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl7_Bairro.Name = "lbl7_Bairro";
            this.lbl7_Bairro.Size = new System.Drawing.Size(54, 13);
            this.lbl7_Bairro.TabIndex = 27;
            this.lbl7_Bairro.Text = "BAIRRO";
            // 
            // lbl8_Municipio
            // 
            this.lbl8_Municipio.AutoSize = true;
            this.lbl8_Municipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8_Municipio.Location = new System.Drawing.Point(85, 413);
            this.lbl8_Municipio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl8_Municipio.Name = "lbl8_Municipio";
            this.lbl8_Municipio.Size = new System.Drawing.Size(72, 13);
            this.lbl8_Municipio.TabIndex = 28;
            this.lbl8_Municipio.Text = "MUNICIPIO";
            // 
            // lbl9_Estado
            // 
            this.lbl9_Estado.AutoSize = true;
            this.lbl9_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9_Estado.Location = new System.Drawing.Point(99, 455);
            this.lbl9_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl9_Estado.Name = "lbl9_Estado";
            this.lbl9_Estado.Size = new System.Drawing.Size(57, 13);
            this.lbl9_Estado.TabIndex = 29;
            this.lbl9_Estado.Text = "ESTADO";
            // 
            // txtBox2_Nome
            // 
            this.txtBox2_Nome.Location = new System.Drawing.Point(164, 158);
            this.txtBox2_Nome.MaxLength = 100;
            this.txtBox2_Nome.Name = "txtBox2_Nome";
            this.txtBox2_Nome.Size = new System.Drawing.Size(316, 20);
            this.txtBox2_Nome.TabIndex = 1;
            this.txtBox2_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox2_Nome_KeyPress);
            // 
            // txtBox3_Nasc
            // 
            this.txtBox3_Nasc.Location = new System.Drawing.Point(164, 242);
            this.txtBox3_Nasc.MaxLength = 11;
            this.txtBox3_Nasc.Name = "txtBox3_Nasc";
            this.txtBox3_Nasc.Size = new System.Drawing.Size(171, 20);
            this.txtBox3_Nasc.TabIndex = 3;
            this.txtBox3_Nasc.TextChanged += new System.EventHandler(this.txtBox3_Nasc_TextChanged);
            this.txtBox3_Nasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox3_Nasc_KeyPress);
            // 
            // txtBox4_End
            // 
            this.txtBox4_End.Location = new System.Drawing.Point(164, 326);
            this.txtBox4_End.MaxLength = 100;
            this.txtBox4_End.Name = "txtBox4_End";
            this.txtBox4_End.Size = new System.Drawing.Size(442, 20);
            this.txtBox4_End.TabIndex = 4;
            // 
            // txtBox5_Bairro
            // 
            this.txtBox5_Bairro.Location = new System.Drawing.Point(164, 368);
            this.txtBox5_Bairro.MaxLength = 100;
            this.txtBox5_Bairro.Name = "txtBox5_Bairro";
            this.txtBox5_Bairro.Size = new System.Drawing.Size(316, 20);
            this.txtBox5_Bairro.TabIndex = 5;
            // 
            // txtBox6_Municipio
            // 
            this.txtBox6_Municipio.Location = new System.Drawing.Point(164, 410);
            this.txtBox6_Municipio.MaxLength = 100;
            this.txtBox6_Municipio.Name = "txtBox6_Municipio";
            this.txtBox6_Municipio.Size = new System.Drawing.Size(316, 20);
            this.txtBox6_Municipio.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1_Sexo
            // 
            this.comboBox1_Sexo.FormattingEnabled = true;
            this.comboBox1_Sexo.ItemHeight = 13;
            this.comboBox1_Sexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outra",
            ""});
            this.comboBox1_Sexo.Location = new System.Drawing.Point(164, 200);
            this.comboBox1_Sexo.Name = "comboBox1_Sexo";
            this.comboBox1_Sexo.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_Sexo.TabIndex = 2;
            // 
            // lbl5_Idade
            // 
            this.lbl5_Idade.AutoSize = true;
            this.lbl5_Idade.Location = new System.Drawing.Point(111, 289);
            this.lbl5_Idade.Name = "lbl5_Idade";
            this.lbl5_Idade.Size = new System.Drawing.Size(45, 13);
            this.lbl5_Idade.TabIndex = 25;
            this.lbl5_Idade.Text = "IDADE";
            // 
            // txtBox8_Idade
            // 
            this.txtBox8_Idade.Location = new System.Drawing.Point(164, 284);
            this.txtBox8_Idade.MaxLength = 5;
            this.txtBox8_Idade.Name = "txtBox8_Idade";
            this.txtBox8_Idade.Size = new System.Drawing.Size(77, 20);
            this.txtBox8_Idade.TabIndex = 33;
            // 
            // comboBox2_Estado
            // 
            this.comboBox2_Estado.FormattingEnabled = true;
            this.comboBox2_Estado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins",
            ""});
            this.comboBox2_Estado.Location = new System.Drawing.Point(164, 452);
            this.comboBox2_Estado.Name = "comboBox2_Estado";
            this.comboBox2_Estado.Size = new System.Drawing.Size(171, 21);
            this.comboBox2_Estado.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lbl10_CEP
            // 
            this.lbl10_CEP.AutoSize = true;
            this.lbl10_CEP.Location = new System.Drawing.Point(122, 497);
            this.lbl10_CEP.Name = "lbl10_CEP";
            this.lbl10_CEP.Size = new System.Drawing.Size(31, 13);
            this.lbl10_CEP.TabIndex = 30;
            this.lbl10_CEP.Text = "CEP";
            // 
            // lbl11_Email
            // 
            this.lbl11_Email.AutoSize = true;
            this.lbl11_Email.Location = new System.Drawing.Point(109, 539);
            this.lbl11_Email.Name = "lbl11_Email";
            this.lbl11_Email.Size = new System.Drawing.Size(48, 13);
            this.lbl11_Email.TabIndex = 31;
            this.lbl11_Email.Text = "E-MAIL";
            // 
            // txtBox9_CEP
            // 
            this.txtBox9_CEP.Location = new System.Drawing.Point(164, 494);
            this.txtBox9_CEP.MaxLength = 10;
            this.txtBox9_CEP.Name = "txtBox9_CEP";
            this.txtBox9_CEP.Size = new System.Drawing.Size(100, 20);
            this.txtBox9_CEP.TabIndex = 8;
            this.txtBox9_CEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox9_CEP_KeyPress);
            // 
            // txtBox10_Email
            // 
            this.txtBox10_Email.Location = new System.Drawing.Point(164, 536);
            this.txtBox10_Email.MaxLength = 100;
            this.txtBox10_Email.Name = "txtBox10_Email";
            this.txtBox10_Email.Size = new System.Drawing.Size(442, 20);
            this.txtBox10_Email.TabIndex = 9;
            this.txtBox10_Email.Leave += new System.EventHandler(this.txtBox10_Email_Leave);
            // 
            // lbl12_Telefone
            // 
            this.lbl12_Telefone.AutoSize = true;
            this.lbl12_Telefone.Location = new System.Drawing.Point(85, 581);
            this.lbl12_Telefone.Name = "lbl12_Telefone";
            this.lbl12_Telefone.Size = new System.Drawing.Size(71, 13);
            this.lbl12_Telefone.TabIndex = 32;
            this.lbl12_Telefone.Text = "TELEFONE";
            // 
            // txtBox11_Telefone
            // 
            this.txtBox11_Telefone.Location = new System.Drawing.Point(164, 578);
            this.txtBox11_Telefone.Name = "txtBox11_Telefone";
            this.txtBox11_Telefone.Size = new System.Drawing.Size(171, 20);
            this.txtBox11_Telefone.TabIndex = 10;
            this.txtBox11_Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox11_Telefone_KeyPress);
            // 
            // F_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 677);
            this.Controls.Add(this.txtBox11_Telefone);
            this.Controls.Add(this.lbl12_Telefone);
            this.Controls.Add(this.txtBox10_Email);
            this.Controls.Add(this.txtBox9_CEP);
            this.Controls.Add(this.lbl11_Email);
            this.Controls.Add(this.lbl10_CEP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2_Estado);
            this.Controls.Add(this.txtBox8_Idade);
            this.Controls.Add(this.lbl5_Idade);
            this.Controls.Add(this.comboBox1_Sexo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox6_Municipio);
            this.Controls.Add(this.txtBox5_Bairro);
            this.Controls.Add(this.txtBox4_End);
            this.Controls.Add(this.txtBox3_Nasc);
            this.Controls.Add(this.txtBox2_Nome);
            this.Controls.Add(this.lbl9_Estado);
            this.Controls.Add(this.lbl8_Municipio);
            this.Controls.Add(this.lbl7_Bairro);
            this.Controls.Add(this.lbl6_End);
            this.Controls.Add(this.lbl4_Nascimento);
            this.Controls.Add(this.lbl3_Sexo);
            this.Controls.Add(this.lbl2_Nome);
            this.Controls.Add(this.lbl1_CPF);
            this.Controls.Add(this.txtBox1_CPF);
            this.Controls.Add(this.lbl0_TituloCadatroPessoas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "F_Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Formulário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl0_TituloCadatroPessoas;
        private System.Windows.Forms.TextBox txtBox1_CPF;
        private System.Windows.Forms.Label lbl1_CPF;
        private System.Windows.Forms.Label lbl2_Nome;
        private System.Windows.Forms.Label lbl3_Sexo;
        private System.Windows.Forms.Label lbl4_Nascimento;
        private System.Windows.Forms.Label lbl6_End;
        private System.Windows.Forms.Label lbl7_Bairro;
        private System.Windows.Forms.Label lbl8_Municipio;
        private System.Windows.Forms.Label lbl9_Estado;
        private System.Windows.Forms.TextBox txtBox2_Nome;
        private System.Windows.Forms.TextBox txtBox3_Nasc;
        private System.Windows.Forms.TextBox txtBox4_End;
        private System.Windows.Forms.TextBox txtBox5_Bairro;
        private System.Windows.Forms.TextBox txtBox6_Municipio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1_Sexo;
        private System.Windows.Forms.Label lbl5_Idade;
        private System.Windows.Forms.TextBox txtBox8_Idade;
        private System.Windows.Forms.ComboBox comboBox2_Estado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl10_CEP;
        private System.Windows.Forms.Label lbl11_Email;
        private System.Windows.Forms.TextBox txtBox9_CEP;
        private System.Windows.Forms.TextBox txtBox10_Email;
        private System.Windows.Forms.Label lbl12_Telefone;
        private System.Windows.Forms.TextBox txtBox11_Telefone;
    }
}

