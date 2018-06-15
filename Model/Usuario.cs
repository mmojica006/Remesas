using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        ServicioActiveDirectory ad = new ServicioActiveDirectory();
        private string domain = "crediexpress.local";
        public Usuario()
        {
            grupo = "GrpSegTMbasico";
        }
        public string usuario { get; set; }
        public string password { get; set; }
        public string grupo { get; set; }

        public responseResult Acceder(string email, string password)
        {

            var result = new responseResult();
            try
            {                
                if ((email != null) && (password != null))
                {

                    if (ad.IsAuthenticated(email, password))
                    {
                        ADHelper helper = new ADHelper(email, password, this.domain);

                        string groupDN = helper.GetGroupDN(grupo);
                        string userDN = helper.GetUserDN("GrpSegTMbasico\\" + email);

                        if (helper.isUserInGroup(userDN, groupDN))
                        {
                            SessionHelper.AddUserToSession(email.ToString());
                            result.SetResponse(true, "Credenciales Correctas!");

                        }
                        else
                        {
                            result.SetResponse(false, "No tiene permiso para usar esta aplicación");
                        }                        
                    }
                    else
                    {
                        result.SetResponse(false, "Favor verificar usuario y contraseña");
                    }


                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }





    }
}
