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



        // função que proibido a entrada de caracteres não numericos nos TextBox
        private void txtBox1_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limita o comprimento máximo do TextBox para 11 dígitos.
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                _ = MessageBox.Show("O CPF deve conter exatamente 11 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // função que proibido a entrada de valores numericos nos TextBox
        private void txtBox2_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede a entrada de dígitos (números).
            }
        }

        // função que proibido a entrada de caracteres não numericos nos TextBox
        private void txtBox3_Nasc_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verifique se o caractere não é um caractere de controle.
            if (!char.IsControl(e.KeyChar))
            {
                // Aceita apenas números e a barra ("/").
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/')
                {
                    e.Handled = true;
                }

                TextBox textBox = sender as TextBox;
                string text = textBox.Text;

                // Verifique se a barra foi digitada na posição correta.
                if (text.Length == 2 && e.KeyChar != '/')
                {
                    e.Handled = true;
                    _ = MessageBox.Show("Digite a barra (/) após o dia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (text.Length == 5 && e.KeyChar != '/')
                {
                    e.Handled = true;
                    _ = MessageBox.Show("Digite a barra (/) após o mês.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Limita o comprimento máximo para 10 caracteres (incluindo as barras).
                if (text.Length >= 10 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

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
    }
}
