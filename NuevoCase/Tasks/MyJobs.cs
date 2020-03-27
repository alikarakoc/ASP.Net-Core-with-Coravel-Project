using NuevoCase.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace NuevoCase.Tasks
{
    public class MyJobs
    {
        public EfNuevoCase db;

        public MyJobs()
        {
            db = new EfNuevoCase();
        }

        public void CheckUrl(int Id)
        {
            var urls = db.Urls.Where(x => x.Id == Id);
            if (urls.Any())
            {
                var url = urls.FirstOrDefault();
                HttpWebResponse response = null;
                try
                {
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url.SiteUrl);
                    request.Method = "GET";
                    response = (HttpWebResponse)request.GetResponse();
                    if ((int)response.StatusCode != 200)
                    {
                        SendMail("Website is down");
                    }
                }
                catch (WebException e)
                {
                    SendMail(e.Message + " <br />" + url.SiteUrl);
                }
                finally
                {
                    if (response != null)
                    {
                        response.Close();
                    }
                }
            }
        }

        public void SendMail(string messages)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("tes@test.com", "Subject");
            mesaj.To.Add("tomail@mail.com");
            mesaj.Subject = "Web site is down";
            mesaj.Body = messages;
            mesaj.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.yandex.ru", 587);
            client.Credentials = new NetworkCredential("tes@test.com", "password");
            client.EnableSsl = true;
            client.Send(mesaj);
        }
    }
}
