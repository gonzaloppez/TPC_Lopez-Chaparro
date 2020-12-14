using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tpc_Lopez_Chaparro
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviarComentario(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add("glopez.ezequiel@gmail.com");
            mmsg.Subject = "ComentarioWeb";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = txtComentario.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.From = new System.Net.Mail.MailAddress("pruebarestaurantprogramacion@gmail");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.UseDefaultCredentials = false;

            cliente.Credentials = new System.Net.NetworkCredential("pruebarestaurantprogramacion@gmail.com","Prueba2020");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(mmsg);
                Response.Redirect("Contacto");
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
           
                          
            
            
        }
    }
}