using System;
using System.Net.Mail;

namespace Generic_Class
{
    public static class ValidaEmail
    {
        public static bool EmailValido(string email)
        {
            // MailAddress: Representa o endereço de um remetente ou destinatário de email.

            try
            {
                MailAddress enderecoEmail = new MailAddress(email);     //Inicializa uma nova instância da classe MailAddress usando o endereço especificado.
                return enderecoEmail.Address == email;
            }
            catch
            {

                return false;
            }


        }
    }
}
