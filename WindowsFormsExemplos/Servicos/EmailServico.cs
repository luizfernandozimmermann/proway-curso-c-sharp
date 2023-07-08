using MailKit.Net.Smtp;
using MimeKit;

namespace WindowsFormsExemplos.Servicos
{
    internal class EmailServico
    {
        public void EnviarEmail(string destinatario, string nomeDestinatario, string corpo, string assunto)
        {
            var mensagem = new MimeMessage();
            mensagem.From.Add(new MailboxAddress("Sistema Proway", "franciscosensaulasexemplos@gmail.com"));
            mensagem.To.Add(new MailboxAddress(nomeDestinatario, destinatario));

            mensagem.Subject = assunto;
            mensagem.Body = new TextPart("plain")
            {
                Text = corpo
            };

            var cliente = new SmtpClient();
            cliente.Connect("smtp.gmail.com", 587, false);
            cliente.Authenticate("bbatata686@gmail.com", "accjroaraswdlwrz");

            cliente.Send(mensagem);
            cliente.Disconnect(true);
        }
    }
}
