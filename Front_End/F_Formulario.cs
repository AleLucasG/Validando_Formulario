using System;
using System.Globalization;
using System.Windows.Forms;

namespace Front_End
{
    public partial class F_Formulario : Form
    {
        public F_Formulario()
        {
            InitializeComponent();
        }

        // validações implicitas
        // função que proibido a entrada de textos e caracteres
        private void txtBox1_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            // Verifica se o caractere não é um caractere de controle.
            if (!char.IsControl(e.KeyChar))
            {
                // Aceita apenas números.
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                /* as TextBox: Usamos o operador as para tentar converter o objeto sender em um objeto do tipo TextBox. 
                 * Isso é necessário porque o sender é do tipo object, e queremos tratá-lo como um TextBox para acessar suas 
                 * propriedades e métodos específicos desse tipo */

                TextBox textBox = sender as TextBox;
                string text = textBox.Text;

                // Formata o CPF conforme o usuário digita.
                if (text.Length == 3 || text.Length == 7)
                {
                    textBox.Text = textBox.Text + ".";
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else if (text.Length == 11)
                {
                    textBox.Text = textBox.Text + "-";
                    textBox.SelectionStart = textBox.Text.Length;
                }

                // Limita o comprimento máximo do TextBox para 14 dígitos.
                TextBox textBox1 = sender as TextBox;
                if (textBox1.Text.Length >= 14 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    _ = MessageBox.Show("O CPF deve conter exatamente 14 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        // função que proibido a entrada de dados numericos
        private void txtBox2_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede a entrada de dígitos (números).
            }
        }

        // função que proibido a entrada de textos
        private void txtBox3_Nasc_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verifica se o caractere não é um caractere de controle.
            if (!char.IsControl(e.KeyChar))
            {
                // Aceita apenas números.
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                TextBox textBox = sender as TextBox;
                string text = textBox.Text;

                // Formata o Data Nascimento conforme o usuário digita.
                if (text.Length == 2 || text.Length == 5)
                {
                    textBox.Text = textBox.Text + "/";
                    textBox.SelectionStart = textBox.Text.Length;
                }
                
                // Limita o comprimento máximo do TextBox para 14 dígitos.
                TextBox textBox1 = sender as TextBox;
                if (textBox1.Text.Length >= 10 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    _ = MessageBox.Show("O CPF deve conter exatamente 14 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        // calculao a data de nascimento e insere no TxtBox_Idade
        private void txtBox3_Nasc_TextChanged(object sender, EventArgs e)
        {
            string dataNascimento = txtBox3_Nasc.Text;

            if (DateTime.TryParseExact(dataNascimento, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimentoDate))
            {
                // Calcula a idade com base na data de nascimento.
                DateTime dataAtual = DateTime.Today;
                int idade = dataAtual.Year - dataNascimentoDate.Year;

                if (dataAtual < dataNascimentoDate.AddYears(idade))
                {
                    idade--;
                }

                // Exibe a idade no txtBox8_Idade.
                txtBox8_Idade.Text = idade.ToString();
            }
            else
            {
                // Se a data de nascimento for inválida, limpe o txtBox8_Idade.
                txtBox8_Idade.Text = "";
            }
        }

        private void txtBox9_CEP_KeyPress(object sender, KeyPressEventArgs e)
        {
                // Aceita apenas números.
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                TextBox textBox = sender as TextBox;
                string text = textBox.Text;

                // Formata o CEP conforme o usuário digita.
                if (text.Length == 5)
                {
                    textBox.Text = textBox.Text + "-";
                    textBox.SelectionStart = textBox.Text.Length;
                }

                // Limita o comprimento máximo do TextBox para 14 dígitos.
                TextBox textBox1 = sender as TextBox;
                if (textBox1.Text.Length >= 9 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    _ = MessageBox.Show("O CEP deve conter exatamente 9 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
        }

        private bool EmailEhValido(string email)
        {
            // Verifica se o e-mail contém pelo menos um "@" e pelo menos um ponto após o "@".
            return email.Contains("@") && email.Contains(".") && email.IndexOf("@") < email.LastIndexOf(".");
        }


        private void txtBox10_Email_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string email = textBox.Text.Trim(); // Remove espaços em branco extras no início e no final.

            if (EmailEhValido(email))
            {
                _ = MessageBox.Show("Endereço de e-mail valido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _ = MessageBox.Show("Endereço de e-mail inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = textBox.Focus();
                textBox.SelectAll();
            }
        }

        private void txtBox11_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere não é um caractere de controle.
            if (!char.IsControl(e.KeyChar))
            {
                // Aceita apenas números.
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                /* as TextBox: Usamos o operador as para tentar converter o objeto sender em um objeto do tipo TextBox. 
                 * Isso é necessário porque o sender é do tipo object, e queremos tratá-lo como um TextBox para acessar suas 
                 * propriedades e métodos específicos desse tipo */
                 
                TextBox textBox = sender as TextBox;
                string text = textBox.Text;

                // Formata o número de telefone conforme o usuário digita.
                if (text.Length == 0)
                {
                    textBox.Text = "(";
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else if (text.Length == 3)
                {
                    textBox.Text = textBox.Text + ") ";
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else if (text.Length == 9)
                {
                    textBox.Text = textBox.Text + "-";
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }





    }
}
