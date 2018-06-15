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
        public string Monto { get; set; }
        public string Moneda { get; set; }
        public string Agente { get; set; }
        public string IDTerminal { get; set; }
        public string ExchangeRate { get; set; }
        public string TestQuestion { get; set; }
        public string TestAnswer { get; set; }
        public string Mensaje { get; set; }

        public string TasaDeCambioFD { get; set; }
        public string MonedaOriginalTransaccionTL { get; set; }
        public string MontoOriginalTransaccionTL { get; set; }

        public int AgregarRemesas(tbl_remesasDTO remesasDTO)
        {
            int result = 0;

            try
            {
                var MTCN = new SqlParameter

                {
                    ParameterName = "@MTCN",
                    Value = remesasDTO.Tipo,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var vTipo = new SqlParameter

                {
                    ParameterName = "@vTipo",
                    Value = remesasDTO.Tipo,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vDestinatario1 = new SqlParameter
                {
                    ParameterName = "@vDestinatario1",
                    Value = remesasDTO.Destinatario1 == null ? string.Empty : remesasDTO.Destinatario1,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                //var vDestinatario2 = new SqlParameter
                //{
                //    ParameterName = "@vDestinatario2",
                //    Value = remesasDTO.Destinatario2,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vDestinatario3 = new SqlParameter
                //{
                //    ParameterName = "@vDestinatario3",
                //    Value = remesasDTO.Destinatario3,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vDestinatario4 = new SqlParameter
                //{
                //    ParameterName = "@vDestinatario4",
                //    Value = remesasDTO.Destinatario4,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vDestinatario5 = new SqlParameter
                //{
                //    ParameterName = "@vDestinatario5",
                //    Value = remesasDTO.Destinatario5,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vDireccion1 = new SqlParameter
                //{
                //    ParameterName = "@vDireccion1",
                //    Value = remesasDTO.Direccion1,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vDireccion2 = new SqlParameter
                //{
                //    ParameterName = "@vDireccion2",
                //    Value = remesasDTO.Direccion2,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vEstadoBeneficiario = new SqlParameter
                //{
                //    ParameterName = "@vEstadoBeneficiario",
                //    Value = remesasDTO.EstadoBeneficiario,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vCiudadBeneficiario = new SqlParameter
                //{
                //    ParameterName = "@vCiudadBeneficiario",
                //    Value = remesasDTO.CiudadBeneficiario,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vTelefono = new SqlParameter
                //{
                //    ParameterName = "@vTelefono",
                //    Value = remesasDTO.Telefono,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vIdentificacion = new SqlParameter
                //{
                //    ParameterName = "@vIdentificacion",
                //    Value = remesasDTO.Identificacion,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vNumeroID = new SqlParameter
                //{
                //    ParameterName = "@vNumeroID",
                //    Value = remesasDTO.NumeroID,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vEmitidaPor = new SqlParameter
                //{
                //    ParameterName = "@vEmitidaPor",
                //    Value = remesasDTO.EmitidaPor,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};



                //var vFechaEmision = new SqlParameter
                //{
                //    ParameterName = "@vFechaEmision",
                //    Value = remesasDTO.FechaEmision,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vFechaExpiracion = new SqlParameter
                //{
                //    ParameterName = "@vFechaExpiracion",
                //    Value = remesasDTO.FechaExpiracion,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vFechaNacimiento = new SqlParameter
                //{
                //    ParameterName = "@vFechaNacimiento",
                //    Value = remesasDTO.FechaNacimiento,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vOcupacion = new SqlParameter
                //{
                //    ParameterName = "@vOcupacion",
                //    Value = remesasDTO.EmitidaPor,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vNacionalidad = new SqlParameter
                //{
                //    ParameterName = "@vNacionalidad",
                //    Value = remesasDTO.Nacionalidad,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vTrabajo = new SqlParameter
                //{
                //    ParameterName = "@vTrabajo",
                //    Value = remesasDTO.Trabajo,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vSexo = new SqlParameter
                //{
                //    ParameterName = "@vSexo",
                //    Value = remesasDTO.Sexo,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};


                //var vEstadoCivil = new SqlParameter
                //{
                //    ParameterName = "@vEstadoCivil",
                //    Value = remesasDTO.EstadoCivil,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vWUCard = new SqlParameter
                //{
                //    ParameterName = "@vWUCard",
                //    Value = remesasDTO.WUCard,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vRemitente1 = new SqlParameter
                //{
                //    ParameterName = "@vRemitente1",
                //    Value = remesasDTO.Remitente1,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vRemitente2 = new SqlParameter
                //{
                //    ParameterName = "@vRemitente2",
                //    Value = remesasDTO.Remitente2,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vRemitente3 = new SqlParameter
                //{
                //    ParameterName = "@vRemitente3",
                //    Value = remesasDTO.Remitente3,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vRemitente4 = new SqlParameter
                //{
                //    ParameterName = "@vRemitente4",
                //    Value = remesasDTO.Remitente4,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vRemitente5 = new SqlParameter
                //{
                //    ParameterName = "@vRemitente5",
                //    Value = remesasDTO.Remitente5,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};


                //var vOrigen = new SqlParameter
                //{
                //    ParameterName = "@vOrigen",
                //    Value = remesasDTO.Origen,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};


                //var vEstadoOrigen = new SqlParameter
                //{
                //    ParameterName = "@vEstadoOrigen",
                //    Value = remesasDTO.EstadoOrigen,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};


                //var vCiudadOrigen = new SqlParameter
                //{
                //    ParameterName = "@vCiudadOrigen",
                //    Value = remesasDTO.CiudadOrigen,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};


                //var vFecha = new SqlParameter
                //{
                //    ParameterName = "@vFecha",
                //    Value = remesasDTO.Fecha,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vHora = new SqlParameter
                //{
                //    ParameterName = "@vHora",
                //    Value = remesasDTO.Hora,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vOperador = new SqlParameter
                //{
                //    ParameterName = "@vOperador",
                //    Value = remesasDTO.Operador,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vMTCN = new SqlParameter
                //{
                //    ParameterName = "@vMTCN",
                //    Value = remesasDTO.MTCN,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vMonto = new SqlParameter
                //{
                //    ParameterName = "@vMonto",
                //    Value = remesasDTO.Monto,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vMoneda = new SqlParameter
                //{
                //    ParameterName = "@vMoneda",
                //    Value = remesasDTO.Moneda,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vAgente = new SqlParameter
                //{
                //    ParameterName = "@vAgente",
                //    Value = remesasDTO.Agente,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vIDTerminal = new SqlParameter
                //{
                //    ParameterName = "@vIDTerminal",
                //    Value = remesasDTO.IDTerminal,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vExchangeRate = new SqlParameter
                //{
                //    ParameterName = "@vExchangeRate",
                //    Value = remesasDTO.ExchangeRate,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vTestQuestion = new SqlParameter
                //{
                //    ParameterName = "@vTestQuestion",
                //    Value = remesasDTO.TestQuestion,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vTestAnswer = new SqlParameter
                //{
                //    ParameterName = "@vTestAnswer",
                //    Value = remesasDTO.Monto,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vMensaje = new SqlParameter
                //{
                //    ParameterName = "@vMensaje",
                //    Value = remesasDTO.Mensaje,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vTasaDeCambioFD = new SqlParameter
                //{
                //    ParameterName = "@vTasaDeCambioFD",
                //    Value = remesasDTO.TasaDeCambioFD,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};

                //var vMonedaOriginalTransaccionTL = new SqlParameter
                //{
                //    ParameterName = "@vMonedaOriginalTransaccionTL",
                //    Value = remesasDTO.Monto,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};
                //var vMontoOriginalTransaccionTL = new SqlParameter
                //{
                //    ParameterName = "@vMontoOriginalTransaccionTL",
                //    Value = remesasDTO.Monto,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //};



                var v_out = new SqlParameter
                {
                    ParameterName = "@v_out",
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

                    //response = ctx.Database.ExecuteSqlCommand("exec @procResult =  uspe_reme_add @vTipo, @vDestinatario1,@vDestinatario2,@vDestinatario3,@vDestinatario4,@vDestinatario5,@vDireccion1,@vDireccion2," +
                    //    " @vEstadoBeneficiario, @vCiudadBeneficiario,@vTelefono, @vIdentificacion,@vNumeroID, @vEmitidaPor, @vFechaEmision,@vFechaExpiracion, @vFechaNacimiento, @vOcupacion,@vNacionalidad," +
                    //    " @vTrabajo, @vSexo, @vEstadoCivil, @vWUCard,@vRemitente1, @vRemitente2,@vRemitente3,@vRemitente4,@vRemitente5,@vOrigen,@vEstadoOrigen,@vCiudadOrigen,@vFecha,@vHora,@vOperador,@vMTCN," +
                    //    " @vMonto, @vMoneda,@vAgente,@vIDTerminal, @vExchangeRate,@vTestQuestion,@vTestAnswer, @vMensaje,@vTasaDeCambioFD,@vMonedaOriginalTransaccionTL, @vMontoOriginalTransaccionTL,@v_out OUTPUT",
                    //     new object[]
                    //     {
                    //     vTipo, vDestinatario1, vDestinatario2,vDestinatario3,vDestinatario4,vDestinatario5,vDireccion1,vDireccion2,vEstadoBeneficiario,vCiudadBeneficiario,vTelefono,vIdentificacion,vNumeroID,vEmitidaPor,
                    //    vFechaEmision,vFechaExpiracion,vFechaNacimiento,vOcupacion,vNacionalidad,vTrabajo,vSexo,vEstadoCivil,vWUCard,vRemitente1,vRemitente2,vRemitente3,vRemitente4,vRemitente5,vOrigen,vEstadoOrigen,vCiudadOrigen,vFecha,vHora,
                    //    vOperador,vMTCN,vMonto,vMoneda,vAgente,vIDTerminal,vExchangeRate,vTestQuestion,vTestAnswer,vMensaje,vTasaDeCambioFD,vMonedaOriginalTransaccionTL,vMontoOriginalTransaccionTL
                    //    ,
                    //     v_out,procResult
                    //    }

                    //    );


                    var response = ctx.Database.ExecuteSqlCommand("exec @procResult = USPCE_WU_PagosRemesas  @vTipo, @vDestinatario1",
                        new object[]
                        {

                            vTipo

            ,
                            vDestinatario1
               ,
                    procResult



                }
            );
                }
                //    new SqlParameter
                //{
                //    ParameterName = "@vDesti1",
                //    Value = remesasDTO.Destinatario1,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //}
                //     new SqlParameter
                //{
                //    ParameterName = "@vDesti2",
                //    Value = remesasDTO.Destinatario2,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //    new SqlParameter
                //{
                //    ParameterName = "@vDesti3",
                //    Value = remesasDTO.Destinatario3,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vDesti4",
                //    Value = remesasDTO.Destinatario4,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vDesti5",
                //    Value = remesasDTO.Destinatario5,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vDire1",
                //    Value = remesasDTO.Direccion1,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vDire2",
                //    Value = remesasDTO.Direccion2,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},

                //new SqlParameter
                //{
                //    ParameterName = "@vEstadoBeneficiario",
                //    Value = remesasDTO.EstadoBeneficiario,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vCiudadBeneficiario",
                //    Value = remesasDTO.CiudadBeneficiario,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vTelefono",
                //    Value = remesasDTO.Telefono,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vIdentificacion",
                //    Value = remesasDTO.Identificacion,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vNumeroID",
                //    Value = remesasDTO.NumeroID,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vEmitidaPor",
                //    Value = remesasDTO.EmitidaPor,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vFechaEmision",
                //    Value = remesasDTO.FechaEmision,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vFechaExpiracion",
                //    Value = remesasDTO.FechaExpiracion,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vFechaNacimiento",
                //    Value = remesasDTO.FechaNacimiento,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vOcupacion",
                //    Value = remesasDTO.EmitidaPor,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},

                //new SqlParameter
                //{
                //    ParameterName = "@vNacionalidad",
                //    Value = remesasDTO.Nacionalidad,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vTrabajo",
                //    Value = remesasDTO.Trabajo,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vSexo",
                //    Value = remesasDTO.Sexo,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vEstadoCivil",
                //    Value = remesasDTO.EstadoCivil,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vWUCard",
                //    Value = remesasDTO.WUCard,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vRemitente1",
                //    Value = remesasDTO.Remitente1,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vRemitente2",
                //    Value = remesasDTO.Remitente2,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vRemitente3",
                //    Value = remesasDTO.Remitente3,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vRemitente4",
                //    Value = remesasDTO.Remitente4,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vRemitente5",
                //    Value = remesasDTO.Remitente5,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vOrigen",
                //    Value = remesasDTO.Origen,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vEstadoOrigen",
                //    Value = remesasDTO.EstadoOrigen,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vCiudadOrigen",
                //    Value = remesasDTO.CiudadOrigen,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vFecha",
                //    Value = remesasDTO.Fecha,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vHora",
                //    Value = remesasDTO.Hora,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vOperador",
                //    Value = remesasDTO.Operador,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vMTCN",
                //    Value = remesasDTO.MTCN,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vMonto",
                //    Value = remesasDTO.Monto,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vMoneda",
                //    Value = remesasDTO.Moneda,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},

                //new SqlParameter
                //{
                //    ParameterName = "@vAgente",
                //    Value = remesasDTO.Agente,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vIDTerminal",
                //    Value = remesasDTO.IDTerminal,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vExchangeRate",
                //    Value = remesasDTO.ExchangeRate,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vTestQuestion",
                //    Value = remesasDTO.TestQuestion,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vTestAnswer",
                //    Value = remesasDTO.Monto,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},

                //new SqlParameter
                //{
                //    ParameterName = "@vMensaje",
                //    Value = remesasDTO.Mensaje,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vTasaDeCambioFD",
                //    Value = remesasDTO.TasaDeCambioFD,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vMonedaOriginalTransaccionTL",
                //    Value = remesasDTO.Monto,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                //new SqlParameter
                //{
                //    ParameterName = "@vMontoOriginalTransaccionTL",
                //    Value = remesasDTO.Monto,
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Input
                //},
                // new SqlParameter
                //{
                //    ParameterName = "@v_out",
                //    SqlDbType = SqlDbType.Int,
                //    Direction = ParameterDirection.Output
                //}




                // );



                //   result = (int)v_out.Value;
                // int resp1 = (int)procResult.Value;

                //}

            }
            catch (Exception e)
            {
                throw;

            }

            return result;


        }

        public responseResult GuardarFile(HttpPostedFileBase fileXml)
        {
            var rm = new responseResult();
            tbl_remesasDTO _remesas = new tbl_remesasDTO();
            // string Domain = HttpContext.Current.Request.Url.Authority;



            try
            {
                if (fileXml != null)
                {
                    string archivo = DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(fileXml.FileName);
                    fileXml.SaveAs(HttpContext.Current.Server.MapPath("~/upload/" + archivo));

                    string path = HttpContext.Current.Server.MapPath("~/upload/" + archivo);


                    String URLString = path;

                    XmlTextReader reader = new XmlTextReader(URLString);

                    while (reader.Read())
                    {
                        string sValue;

                        if (reader.NodeType.Equals(XmlNodeType.Element))
                        {



                            switch (reader.Name)
                            {
                                case "Tipo":
                                    sValue = reader.ReadElementString();
                                    _remesas.Tipo = sValue;

                                    break;
                                case "Destinatario1":
                                    sValue = reader.ReadElementString();
                                    _remesas.Destinatario1 = sValue;
                                    break;
                                case "Destinatario2":
                                    sValue = reader.ReadElementString();
                                    _remesas.Destinatario2 = sValue;
                                    break;
                                case "Destinatario3":
                                    sValue = reader.ReadElementString();
                                    _remesas.Destinatario3 = sValue;
                                    break;
                                case "Destinatario4":
                                    sValue = reader.ReadElementString();
                                    _remesas.Destinatario4 = sValue;
                                    break;
                                case "Destinatario5":
                                    sValue = reader.ReadElementString();
                                    _remesas.Destinatario5 = sValue;
                                    break;
                                case "Direccion1":
                                    sValue = reader.ReadElementString();
                                    _remesas.Direccion1 = sValue;
                                    break;
                                case "Direccion2":
                                    sValue = reader.ReadElementString();
                                    _remesas.Direccion2 = sValue;
                                    break;
                                case "EstadoBeneficiario":
                                    sValue = reader.ReadElementString();
                                    _remesas.EstadoBeneficiario = sValue;
                                    break;
                                case "CiudadBeneficiario":
                                    sValue = reader.ReadElementString();
                                    _remesas.CiudadBeneficiario = sValue;
                                    break;
                                case "Telefono":
                                    sValue = reader.ReadElementString();
                                    _remesas.Telefono = sValue;
                                    break;
                                case "Identificacion":
                                    sValue = reader.ReadElementString();
                                    _remesas.Identificacion = sValue;
                                    break;
                                case "NumeroID":
                                    sValue = reader.ReadElementString();
                                    _remesas.NumeroID = sValue;
                                    break;
                                case "EmitidaPor":
                                    sValue = reader.ReadElementString();
                                    _remesas.EmitidaPor = sValue;
                                    break;
                                case "FechaEmision":
                                    sValue = reader.ReadElementString();
                                    _remesas.FechaEmision = sValue;
                                    break;
                                case "FechaExpiracion":
                                    sValue = reader.ReadElementString();
                                    _remesas.FechaExpiracion = sValue;
                                    break;
                                case "FechaNacimiento":
                                    sValue = reader.ReadElementString();
                                    _remesas.FechaNacimiento = sValue;
                                    break;
                                case "Ocupacion":
                                    sValue = reader.ReadElementString();
                                    _remesas.Ocupacion = sValue;
                                    break;
                                case "Nacionalidad":
                                    sValue = reader.ReadElementString();
                                    _remesas.Nacionalidad = sValue;
                                    break;
                                case "Trabajo":
                                    sValue = reader.ReadElementString();
                                    _remesas.Trabajo = sValue;
                                    break;
                                case "Sexo":
                                    sValue = reader.ReadElementString();
                                    _remesas.Sexo = sValue;
                                    break;
                                case "EstadoCivil":
                                    sValue = reader.ReadElementString();
                                    _remesas.EstadoCivil = sValue;
                                    break;
                                case "WUCard":
                                    sValue = reader.ReadElementString();
                                    _remesas.WUCard = sValue;
                                    break;
                                case "Remitente1":
                                    sValue = reader.ReadElementString();
                                    _remesas.Remitente1 = sValue;
                                    break;
                                case "Remitente2":
                                    sValue = reader.ReadElementString();
                                    _remesas.Remitente2 = sValue;
                                    break;
                                case "Remitente3":
                                    sValue = reader.ReadElementString();
                                    _remesas.Remitente3 = sValue;
                                    break;
                                case "Remitente4":
                                    sValue = reader.ReadElementString();
                                    _remesas.Remitente4 = sValue;
                                    break;
                                case "Remitente5":
                                    sValue = reader.ReadElementString();
                                    _remesas.Remitente5 = sValue;
                                    break;
                                case "Origen":
                                    sValue = reader.ReadElementString();
                                    _remesas.Origen = sValue;
                                    break;

                                case "EstadoOrigen":
                                    sValue = reader.ReadElementString();
                                    _remesas.EstadoOrigen = sValue;
                                    break;

                                case "CiudadOrigen":
                                    sValue = reader.ReadElementString();
                                    _remesas.CiudadOrigen = sValue;
                                    break;
                                case "Fecha":
                                    sValue = reader.ReadElementString();
                                    _remesas.Fecha = sValue;
                                    break;
                                case "Hora":
                                    sValue = reader.ReadElementString();
                                    _remesas.Hora = sValue;
                                    break;
                                case "Operador":
                                    sValue = reader.ReadElementString();
                                    _remesas.Operador = sValue;
                                    break;
                                case "MTCN":
                                    sValue = reader.ReadElementString();
                                    _remesas.MTCN = sValue;
                                    break;
                                case "Monto":
                                    sValue = reader.ReadElementString();
                                    _remesas.Monto = sValue;
                                    break;
                                case "Moneda":
                                    sValue = reader.ReadElementString();
                                    _remesas.Moneda = sValue;
                                    break;
                                case "Agente":
                                    sValue = reader.ReadElementString();
                                    _remesas.Agente = sValue;
                                    break;
                                case "IDTerminal":
                                    sValue = reader.ReadElementString();
                                    _remesas.IDTerminal = sValue;
                                    break;
                                case "ExchangeRate":
                                    sValue = reader.ReadElementString();
                                    _remesas.ExchangeRate = sValue;
                                    break;
                                case "TestQuestion":
                                    sValue = reader.ReadElementString();
                                    _remesas.TestQuestion = sValue;
                                    break;
                                case "TestAnswer":
                                    sValue = reader.ReadElementString();
                                    _remesas.TestAnswer = sValue;
                                    break;
                                case "Mensaje":
                                    sValue = reader.ReadElementString();
                                    _remesas.Mensaje = sValue;
                                    break;
                                case "TasaDeCambioFD":
                                    sValue = reader.ReadElementString();
                                    _remesas.TasaDeCambioFD = sValue;
                                    break;
                                case "MonedaOriginalTransaccionTL":
                                    sValue = reader.ReadElementString();
                                    _remesas.MonedaOriginalTransaccionTL = sValue;
                                    break;
                                case "MontoOriginalTransaccionTL":
                                    sValue = reader.ReadElementString();
                                    _remesas.MontoOriginalTransaccionTL = sValue;
                                    break;

                            }


                            //Console.WriteLine(reader.LocalName);


                        }
                    } //End While



                    int GuardarBD = AgregarRemesas(_remesas);




                    rm.SetResponse(true, "Archivo cargado correctamente!");
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
