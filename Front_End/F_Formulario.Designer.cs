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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox1_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBox2_Nome = new System.Windows.Forms.TextBox();
            this.txtBox3_Nasc = new System.Windows.Forms.TextBox();
            this.txtBox4_End = new System.Windows.Forms.TextBox();
            this.txtBox5_Bairro = new System.Windows.Forms.TextBox();
            this.txtBox6_Municipio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1_Sexo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox8_Idade = new System.Windows.Forms.TextBox();
            this.comboBox2_Estado = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "CADASTRO DE PESSOAS";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "NOME COMPLETO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "SEXO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "NASCIMENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ENDEREÇO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 371);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "BAIRRO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 413);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "MUNICIPIO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(99, 455);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ESTADO";
            // 
            // txtBox2_Nome
            // 
            this.txtBox2_Nome.Location = new System.Drawing.Point(164, 158);
            this.txtBox2_Nome.Name = "txtBox2_Nome";
            this.txtBox2_Nome.Size = new System.Drawing.Size(316, 20);
            this.txtBox2_Nome.TabIndex = 1;
            this.txtBox2_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox2_Nome_KeyPress);
            // 
            // txtBox3_Nasc
            // 
            this.txtBox3_Nasc.Location = new System.Drawing.Point(164, 242);
            this.txtBox3_Nasc.Name = "txtBox3_Nasc";
            this.txtBox3_Nasc.Size = new System.Drawing.Size(171, 20);
            this.txtBox3_Nasc.TabIndex = 4;
            this.txtBox3_Nasc.TextChanged += new System.EventHandler(this.txtBox3_Nasc_TextChanged);
            this.txtBox3_Nasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox3_Nasc_KeyPress);
            // 
            // txtBox4_End
            // 
            this.txtBox4_End.Location = new System.Drawing.Point(164, 326);
            this.txtBox4_End.Name = "txtBox4_End";
            this.txtBox4_End.Size = new System.Drawing.Size(316, 20);
            this.txtBox4_End.TabIndex = 5;
            // 
            // txtBox5_Bairro
            // 
            this.txtBox5_Bairro.Location = new System.Drawing.Point(164, 368);
            this.txtBox5_Bairro.Name = "txtBox5_Bairro";
            this.txtBox5_Bairro.Size = new System.Drawing.Size(316, 20);
            this.txtBox5_Bairro.TabIndex = 6;
            // 
            // txtBox6_Municipio
            // 
            this.txtBox6_Municipio.Location = new System.Drawing.Point(164, 410);
            this.txtBox6_Municipio.Name = "txtBox6_Municipio";
            this.txtBox6_Municipio.Size = new System.Drawing.Size(316, 20);
            this.txtBox6_Municipio.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 9;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "IDADE";
            // 
            // txtBox8_Idade
            // 
            this.txtBox8_Idade.Location = new System.Drawing.Point(164, 284);
            this.txtBox8_Idade.Name = "txtBox8_Idade";
            this.txtBox8_Idade.Size = new System.Drawing.Size(77, 20);
            this.txtBox8_Idade.TabIndex = 3;
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
            this.comboBox2_Estado.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // F_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2_Estado);
            this.Controls.Add(this.txtBox8_Idade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1_Sexo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox6_Municipio);
            this.Controls.Add(this.txtBox5_Bairro);
            this.Controls.Add(this.txtBox4_End);
            this.Controls.Add(this.txtBox3_Nasc);
            this.Controls.Add(this.txtBox2_Nome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox1_CPF);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox1_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBox2_Nome;
        private System.Windows.Forms.TextBox txtBox3_Nasc;
        private System.Windows.Forms.TextBox txtBox4_End;
        private System.Windows.Forms.TextBox txtBox5_Bairro;
        private System.Windows.Forms.TextBox txtBox6_Municipio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1_Sexo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox8_Idade;
        private System.Windows.Forms.ComboBox comboBox2_Estado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

