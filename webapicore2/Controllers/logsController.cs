using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapicore2.Models;

namespace webapicore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class logsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Save([FromBody] Log log)
        {
            DateTime logCST = log.Fecha.AddHours(-6);
            log.Fecha = logCST;
            using (Team4RMContext BD = new Team4RMContext())
            {
                BD.Log.Add(log);
                BD.SaveChanges();
            }
            SendEmail(log);

            return Ok(log);
        }

        [HttpGet]
        public IEnumerable<Models.Log> Get()
        {
            using (Team4RMContext BD = new Team4RMContext())
            {
                var listado = BD.Log.ToList();
                return listado;
            }
        }

        private void SendEmail(Log log)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();


            mmsg.To.Add("softtekt4@gmail.com");

            mmsg.Subject = log.Mensaje;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = log.Mensaje;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;

            mmsg.From = new System.Net.Mail.MailAddress("softtekt4@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            //cliente.UseDefaultCredentials = false;
            cliente.Credentials = new System.Net.NetworkCredential("softtekt4@gmail.com", "Soporte01");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com"; //en caso de estar usando otro dominio es mail.dominio.com
            try
            {
                cliente.Send(mmsg);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}