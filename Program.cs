using System.Net.Mail;
using System.Text;
 
Console.WriteLine("Hello, World!");
 
using (var smtpClient = new SmtpClient("cwirelay.cwinet.local", 25))
{
    MailMessage mail = new MailMessage("sistema.ponto@cwi.com.br", "eduardo.bortoto@cwi.com.br");
 
    mail.IsBodyHtml = true;
    mail.SubjectEncoding = Encoding.UTF8;
    mail.BodyEncoding = Encoding.UTF8;
    mail.Priority = MailPriority.Normal;
    mail.Subject = "assunto";
    mail.From = new MailAddress("sistema.ponto@cwi.com.br", "assunto");
    mail.Body = "llll";
 
    smtpClient.Send(mail);
}