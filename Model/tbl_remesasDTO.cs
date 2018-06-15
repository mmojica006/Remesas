using Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Model
{
    public class tbl_remesasDTO
    {
        public int id { get; set; }
        public string Tipo { get; set; }
        public string Destinatario1 { get; set; }
        public string Destinatario2 { get; set; }
        public string Destinatario3 { get; set; }
        public string Destinatario4 { get; set; }
        public string Destinatario5 { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string EstadoBeneficiario { get; set; }
        public string CiudadBeneficiario { get; set; }


        public string Telefono { get; set; }
        public string Identificacion { get; set; }
        public string NumeroID { get; set; }
        public string EmitidaPor { get; set; }
        public string FechaEmision { get; set; }
        public string FechaExpiracion { get; set; }
        public string FechaNacimiento { get; set; }
        public string Ocupacion { get; set; }
        public string Nacionalidad { get; set; }

        public string Trabajo { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string WUCard { get; set; }
        public string Remitente1 { get; set; }
        public string Remitente2 { get; set; }
        public string Remitente3 { get; set; }

        public string Remitente4 { get; set; }
        public string Remitente5 { get; set; }
        public string Origen { get; set; }
        public string EstadoOrigen { get; set; }
        public string CiudadOrigen { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Operador { get; set; }

        public string MTCN { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Agente { get; set; }
        public string IDTerminal { get; set; }
        public decimal ExchangeRate { get; set; }
        public string TestQuestion { get; set; }
        public string TestAnswer { get; set; }
        public string Mensaje { get; set; }

        public decimal TasaDeCambioFD { get; set; }
        public string MonedaOriginalTransaccionTL { get; set; }
        public decimal MontoOriginalTransaccionTL { get; set; }

        public string UsuarioCarga { get; set; }

        public int AgregarRemesas(tbl_remesasDTO remesasDTO)
        {
            int result = 0;

            try
            {
                var MTCN = new SqlParameter

                {
                    ParameterName = "@MTCN",
                    Value = remesasDTO.MTCN,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var Tipo = new SqlParameter

                {
                    ParameterName = "@Tipo",
                    Value = remesasDTO.Tipo,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Destinatario1 = new SqlParameter
                {
                    ParameterName = "@Destinatario1",
                    Value = remesasDTO.Destinatario1 == null ? string.Empty : remesasDTO.Destinatario1,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Destinatario2 = new SqlParameter
                {
                    ParameterName = "@Destinatario2",
                    Value = remesasDTO.Destinatario2 == null ? string.Empty : remesasDTO.Destinatario2,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Destinatario3 = new SqlParameter
                {
                    ParameterName = "@Destinatario3",
                    Value = remesasDTO.Destinatario3 == null ? string.Empty : remesasDTO.Destinatario3,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Destinatario4 = new SqlParameter
                {
                    ParameterName = "@Destinatario4",
                    Value = remesasDTO.Destinatario4 == null ? string.Empty : remesasDTO.Destinatario4,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Destinatario5 = new SqlParameter
                {
                    ParameterName = "@Destinatario5",
                    Value = remesasDTO.Destinatario5 == null ? string.Empty : remesasDTO.Destinatario5,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Direccion1 = new SqlParameter
                {
                    ParameterName = "@Direccion1",
                    Value = remesasDTO.Direccion1 == null ? string.Empty : remesasDTO.Direccion1,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Direccion2 = new SqlParameter
                {
                    ParameterName = "@Direccion2",
                    Value = remesasDTO.Direccion2 == null ? string.Empty : remesasDTO.Direccion2,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var EstadoBeneficiario = new SqlParameter
                {
                    ParameterName = "@EstadoBeneficiario",
                    Value = remesasDTO.EstadoBeneficiario == null ? string.Empty : remesasDTO.EstadoBeneficiario,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var CiudadBeneficiario = new SqlParameter
                {
                    ParameterName = "@CiudadBeneficiario",
                    Value = remesasDTO.CiudadBeneficiario == null ? string.Empty : remesasDTO.CiudadBeneficiario,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Telefono = new SqlParameter
                {
                    ParameterName = "@Telefono",
                    Value = remesasDTO.Telefono == null ? string.Empty : remesasDTO.Telefono,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Identificacion = new SqlParameter
                {
                    ParameterName = "@Identificacion",
                    Value = remesasDTO.Identificacion == null ? string.Empty : remesasDTO.Identificacion,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var NumeroID = new SqlParameter
                {
                    ParameterName = "@NumeroID",
                    Value = remesasDTO.NumeroID == null ? string.Empty : remesasDTO.NumeroID,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var EmitidaPor = new SqlParameter
                {
                    ParameterName = "@EmitidaPor",
                    Value = remesasDTO.EmitidaPor == null ? string.Empty : remesasDTO.EmitidaPor,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };



                var FechaEmision = new SqlParameter
                {
                    ParameterName = "@FechaEmision",
                    Value = remesasDTO.FechaEmision == null ? string.Empty : remesasDTO.FechaEmision,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var FechaExpiracion = new SqlParameter
                {
                    ParameterName = "@FechaExpiracion",
                    Value = remesasDTO.FechaExpiracion == null ? string.Empty : remesasDTO.FechaExpiracion,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var FechaNacimiento = new SqlParameter
                {
                    ParameterName = "@FechaNacimiento",
                    Value = remesasDTO.FechaNacimiento == null ? string.Empty : remesasDTO.FechaNacimiento,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var Ocupacion = new SqlParameter
                {
                    ParameterName = "@Ocupacion",
                    Value = remesasDTO.Ocupacion == null ? string.Empty : remesasDTO.Ocupacion,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var Nacionalidad = new SqlParameter
                {
                    ParameterName = "@Nacionalidad",
                    Value = remesasDTO.Nacionalidad == null ? string.Empty : remesasDTO.Nacionalidad,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var Trabajo = new SqlParameter
                {
                    ParameterName = "@Trabajo",
                    Value = remesasDTO.Trabajo == null ? string.Empty : remesasDTO.Trabajo,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var Sexo = new SqlParameter
                {
                    ParameterName = "@Sexo",
                    Value = remesasDTO.Sexo == null ? string.Empty : remesasDTO.Sexo,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var EstadoCivil = new SqlParameter
                {
                    ParameterName = "@EstadoCivil",
                    Value = remesasDTO.EstadoCivil == null ? string.Empty : remesasDTO.EstadoCivil,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var WUCard = new SqlParameter
                {
                    ParameterName = "@WUCard",
                    Value = remesasDTO.WUCard == null ? string.Empty : remesasDTO.WUCard,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var Remitente1 = new SqlParameter
                {
                    ParameterName = "@Remitente1",
                    Value = remesasDTO.Remitente1 == null ? string.Empty : remesasDTO.Remitente1,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Remitente2 = new SqlParameter
                {
                    ParameterName = "@Remitente2",
                    Value = remesasDTO.Remitente2 == null ? string.Empty : remesasDTO.Remitente2,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Remitente3 = new SqlParameter
                {
                    ParameterName = "@Remitente3",
                    Value = remesasDTO.Remitente3 == null ? string.Empty : remesasDTO.Remitente3,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Remitente4 = new SqlParameter
                {
                    ParameterName = "@Remitente4",
                    Value = remesasDTO.Remitente4 == null ? string.Empty : remesasDTO.Remitente4,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var Remitente5 = new SqlParameter
                {
                    ParameterName = "@Remitente5",
                    Value = remesasDTO.Remitente5 == null ? string.Empty : remesasDTO.Remitente5,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var Origen = new SqlParameter
                {
                    ParameterName = "@Origen",
                    Value = remesasDTO.Origen == null ? string.Empty : remesasDTO.Origen,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var EstadoOrigen = new SqlParameter
                {
                    ParameterName = "@EstadoOrigen",
                    Value = remesasDTO.EstadoOrigen == null ? string.Empty : remesasDTO.EstadoOrigen,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var CiudadOrigen = new SqlParameter
                {
                    ParameterName = "@CiudadOrigen",
                    Value = remesasDTO.CiudadOrigen == null ? string.Empty : remesasDTO.CiudadOrigen,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var Fecha = new SqlParameter
                {
                    ParameterName = "@Fecha",
                    Value = remesasDTO.CiudadOrigen == null ? string.Empty : remesasDTO.CiudadOrigen,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var Hora = new SqlParameter
                {
                    ParameterName = "@Hora",
                    Value = remesasDTO.Hora == null ? string.Empty : remesasDTO.Hora,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var Operador = new SqlParameter
                {
                    ParameterName = "@Operador",
                    Value = remesasDTO.Operador == null ? string.Empty : remesasDTO.Operador,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var Monto = new SqlParameter
                {
                    ParameterName = "@Monto",
                    Value = Convert.ToString(remesasDTO.Monto) == null ? 0 : remesasDTO.Monto,
                    SqlDbType = SqlDbType.Decimal,
                    Direction = ParameterDirection.Input
                };

                var Moneda = new SqlParameter
                {
                    ParameterName = "@Moneda",
                    Value = remesasDTO.Moneda == null ? string.Empty : remesasDTO.Moneda,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var Agente = new SqlParameter
                {
                    ParameterName = "@Agente",
                    Value = remesasDTO.Agente == null ? string.Empty : remesasDTO.Agente,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var IDTerminal = new SqlParameter
                {
                    ParameterName = "@IDTerminal",
                    Value = remesasDTO.IDTerminal == null ? string.Empty : remesasDTO.IDTerminal,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var ExchangeRate = new SqlParameter
                {
                    ParameterName = "@ExchangeRate",
                    Value = Convert.ToString(remesasDTO.ExchangeRate) == null ? 0 : remesasDTO.ExchangeRate,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var TestQuestion = new SqlParameter
                {
                    ParameterName = "@TestQuestion",
                    Value = remesasDTO.TestQuestion == null ? string.Empty : remesasDTO.TestQuestion,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var TestAnswer = new SqlParameter
                {
                    ParameterName = "@TestAnswer",
                    Value = remesasDTO.TestAnswer == null ? string.Empty : remesasDTO.TestAnswer,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var Mensaje = new SqlParameter
                {
                    ParameterName = "@Mensaje",
                    Value = remesasDTO.Mensaje == null ? string.Empty : remesasDTO.Mensaje,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var TasaDeCambioFD = new SqlParameter
                {
                    ParameterName = "@TasaDeCambioFD",
                    Value = Convert.ToString(remesasDTO.TasaDeCambioFD) == null ? 0 : remesasDTO.TasaDeCambioFD,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var MonedaOriginalTransaccionTL = new SqlParameter
                {
                    ParameterName = "@MonedaOriginalTransaccionTL",
                    Value = remesasDTO.MonedaOriginalTransaccionTL == null ? string.Empty : remesasDTO.MonedaOriginalTransaccionTL,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var MontoOriginalTransaccionTL = new SqlParameter
                {
                    ParameterName = "@MontoOriginalTransaccionTL",
                    Value = Convert.ToString(remesasDTO.MontoOriginalTransaccionTL) == null ? 0 : remesasDTO.MontoOriginalTransaccionTL,
                    SqlDbType = SqlDbType.Float,
                    Direction = ParameterDirection.Input
                };

                var UsuarioCarga = new SqlParameter
                {
                    ParameterName = "@UsuarioCarga",
                    Value = remesasDTO.UsuarioCarga == null ? string.Empty : remesasDTO.UsuarioCarga,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var Salida = new SqlParameter
                {
                    ParameterName = "@Salida",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output

                };

                var procResult = new SqlParameter
                {
                    ParameterName = "@procResult",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                using (var ctx = new dbContext())
                {

                    var response = ctx.Database.ExecuteSqlCommand("exec @procResult = USPCE_WU_PagosRemesas  @MTCN,@Tipo,@Destinatario1,@Destinatario2,@Destinatario3,@Destinatario4,@Destinatario5,@Direccion1,@Direccion2,@EstadoBeneficiario,@CiudadBeneficiario,@Telefono,@Identificacion,@NumeroID,@EmitidaPor,@FechaEmision,@FechaExpiracion,@FechaNacimiento,@Ocupacion,@Nacionalidad,@Trabajo,@Sexo,@EstadoCivil,@WUCard,@Remitente1,@Remitente2,@Remitente3,@Remitente4,@Remitente5,@Origen,@EstadoOrigen,@CiudadOrigen,@Fecha,@Hora,@Operador,@Monto,@Moneda,@Agente,@IDTerminal,@ExchangeRate,@TestQuestion,@TestAnswer,@Mensaje,@TasaDeCambioFD,@MonedaOriginalTransaccionTL,@MontoOriginalTransaccionTL,@UsuarioCarga,@Salida OUTPUT",
                        new object[]
                       {MTCN,Tipo,Destinatario1,Destinatario2,Destinatario3,Destinatario4,Destinatario5,Direccion1,Direccion2,EstadoBeneficiario,CiudadBeneficiario,Telefono,Identificacion,NumeroID,EmitidaPor,FechaEmision,FechaExpiracion,FechaNacimiento,Ocupacion,Nacionalidad,Trabajo,Sexo,EstadoCivil,WUCard,Remitente1,Remitente2,Remitente3,Remitente4,Remitente5,Origen,EstadoOrigen,CiudadOrigen,Fecha,Hora,Operador,Monto,Moneda,Agente,IDTerminal,ExchangeRate,TestQuestion,TestAnswer,Mensaje,TasaDeCambioFD,MonedaOriginalTransaccionTL,MontoOriginalTransaccionTL,UsuarioCarga,Salida,procResult

                        }
            );
                    int res0 = (int)Salida.Value;
                    result = res0;





                    int resp = (int)procResult.Value;
                }


            }
            catch (Exception e)
            {
                throw;

            }

            return result;


        }

        public string ObtenerUsuarioTopaz(string usuario)
        {
            string response = string.Empty;
            try
            {
                using (var ctx = new dbContext())
                {
                    string resp = ctx.Database.SqlQuery<string>("select isnull(INICIALES,'') from USUARIOS where LDAPUSER='" + usuario + "'").FirstOrDefault();

                    if (resp != "")
                        response = resp;
                }

            }
            catch (Exception ex)
            {

            }

            return response;
        }

        public string ObtenerMensaje(int id)
        {
            string response = string.Empty;
            try
            {
                using (var ctx = new dbContext())
                {
                    string resp = ctx.Database.SqlQuery<string>("select isnull(Descripcion,'') from WU_EstadosCargaRem where Codigo=" + id).FirstOrDefault();

                    if (resp != "")
                        response = resp;
                }

            }
            catch (Exception)
            {

            }

            return response;

        }

        public responseResult GuardarFile(string usuario, HttpPostedFileBase fileXml)
        {
            var rm = new responseResult();
            tbl_remesasDTO _remesas = new tbl_remesasDTO();
            _remesas.UsuarioCarga = ObtenerUsuarioTopaz(usuario.ToLower());
            // string Domain = HttpContext.Current.Request.Url.Authority;



            try
            {
                if (fileXml != null)
                {
                    string archivo = usuario + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(fileXml.FileName);
                    fileXml.SaveAs(HttpContext.Current.Server.MapPath("~/upload/" + archivo));

                    string path = HttpContext.Current.Server.MapPath("~/upload/" + archivo);


                    String URLString = path;

                    XmlTextReader reader = new XmlTextReader(URLString);

                    while (reader.Read())
                    {


                        switch (reader.Name.ToString())

                        {

                            case "Tipo":
                                _remesas.Tipo = reader.ReadString();
                                break;

                            case "Destinatario1":
                                _remesas.Destinatario1 = reader.ReadString();
                                break;

                            case "Destinatario2":

                                _remesas.Destinatario2 = reader.ReadString();
                                break;
                            case "Destinatario3":

                                _remesas.Destinatario3 = reader.ReadString();
                                break;
                            case "Destinatario4":

                                _remesas.Destinatario4 = reader.ReadString();
                                break;
                            case "Destinatario5":

                                _remesas.Destinatario5 = reader.ReadString();
                                break;
                            case "Direccion1":

                                _remesas.Direccion1 = reader.ReadString();
                                break;
                            case "Direccion2":

                                _remesas.Direccion2 = reader.ReadString();
                                break;
                            case "EstadoBeneficiario":

                                _remesas.EstadoBeneficiario = reader.ReadString();
                                break;
                            case "CiudadBeneficiario":

                                _remesas.CiudadBeneficiario = reader.ReadString();
                                break;
                            case "Telefono":

                                _remesas.Telefono = reader.ReadString();
                                break;
                            case "Identificacion":

                                _remesas.Identificacion = reader.ReadString();
                                break;
                            case "NumeroID":

                                _remesas.NumeroID = reader.ReadString();
                                break;
                            case "EmitidaPor":

                                _remesas.EmitidaPor = reader.ReadString();
                                break;
                            case "FechaEmision":

                                _remesas.FechaEmision = reader.ReadString();
                                break;
                            case "FechaExpiracion":

                                _remesas.FechaExpiracion = reader.ReadString();
                                break;
                            case "FechaNacimiento":

                                _remesas.FechaNacimiento = reader.ReadString();
                                break;
                            case "Ocupacion":

                                _remesas.Ocupacion = reader.ReadString();
                                break;
                            case "Nacionalidad":

                                _remesas.Nacionalidad = reader.ReadString();
                                break;
                            case "Trabajo":

                                _remesas.Trabajo = reader.ReadString();
                                break;
                            case "Sexo":

                                _remesas.Sexo = reader.ReadString();
                                break;
                            case "EstadoCivil":

                                _remesas.EstadoCivil = reader.ReadString();
                                break;
                            case "WUCard":

                                _remesas.WUCard = reader.ReadString();
                                break;
                            case "Remitente1":

                                _remesas.Remitente1 = reader.ReadString();
                                break;
                            case "Remitente2":

                                _remesas.Remitente2 = reader.ReadString();
                                break;
                            case "Remitente3":

                                _remesas.Remitente3 = reader.ReadString();
                                break;
                            case "Remitente4":

                                _remesas.Remitente4 = reader.ReadString();
                                break;
                            case "Remitente5":

                                _remesas.Remitente5 = reader.ReadString();
                                break;
                            case "Origen":

                                _remesas.Origen = reader.ReadString();
                                break;

                            case "EstadoOrigen":

                                _remesas.EstadoOrigen = reader.ReadString();
                                break;

                            case "CiudadOrigen":

                                _remesas.CiudadOrigen = reader.ReadString();
                                break;
                            case "Fecha":

                                _remesas.Fecha = reader.ReadString();
                                break;
                            case "Hora":

                                _remesas.Hora = reader.ReadString();
                                break;
                            case "Operador":

                                _remesas.Operador = reader.ReadString();
                                break;
                            case "MTCN":

                                _remesas.MTCN = reader.ReadString();
                                break;
                            case "Monto":

                                _remesas.Monto = Convert.ToDecimal(reader.ReadString());
                                break;
                            case "Moneda":

                                _remesas.Moneda = reader.ReadString();
                                break;
                            case "Agente":

                                _remesas.Agente = reader.ReadString();
                                break;
                            case "IDTerminal":

                                _remesas.IDTerminal = reader.ReadString();
                                break;
                            case "ExchangeRate":

                                _remesas.ExchangeRate = Convert.ToDecimal(reader.ReadString());
                                break;
                            case "TestQuestion":

                                _remesas.TestQuestion = reader.ReadString();
                                break;
                            case "TestAnswer":

                                _remesas.TestAnswer = reader.ReadString();
                                break;
                            case "Mensaje":

                                _remesas.Mensaje = reader.ReadString();
                                break;
                            case "TasaDeCambioFD":

                                _remesas.TasaDeCambioFD = Convert.ToDecimal(reader.ReadString());
                                break;
                            case "MonedaOriginalTransaccionTL":

                                _remesas.MonedaOriginalTransaccionTL = reader.ReadString();
                                break;
                            case "MontoOriginalTransaccionTL":

                                _remesas.MontoOriginalTransaccionTL = Convert.ToDecimal(reader.ReadString());
                                break;

                        }





                    } //End While



                    int GuardarBD = AgregarRemesas(_remesas);

                    ObtenerMensaje(GuardarBD);

                    rm.SetResponse(true, ObtenerMensaje(GuardarBD));
                }
                else
                {
                    rm.SetResponse(false);
                }
            }
            catch (Exception ex)
            {
                rm.SetResponse(false, ex.Message);

            }


            return rm;


        }

    }
}
