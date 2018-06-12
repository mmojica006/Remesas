using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Remesas 
    {
        public int  AgregarRemesas(tbl_remesasDTO remesasDTO)
        {
            int response = 0;
            try
            {
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
                    Value = remesasDTO.Destinatario1,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vDestinatario2 = new SqlParameter
                {
                    ParameterName = "@vDestinatario2",
                    Value = remesasDTO.Destinatario2,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vDestinatario3 = new SqlParameter
                {
                    ParameterName = "@vDestinatario3",
                    Value = remesasDTO.Destinatario3,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vDestinatario4 = new SqlParameter
                {
                    ParameterName = "@vDestinatario4",
                    Value = remesasDTO.Destinatario4,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vDestinatario5 = new SqlParameter
                {
                    ParameterName = "@vDestinatario5",
                    Value = remesasDTO.Destinatario5,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vDireccion1 = new SqlParameter
                {
                    ParameterName = "@vDireccion1",
                    Value = remesasDTO.Direccion1,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vDireccion2 = new SqlParameter
                {
                    ParameterName = "@vDireccion2",
                    Value = remesasDTO.Direccion2,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vEstadoBeneficiario = new SqlParameter
                {
                    ParameterName = "@vEstadoBeneficiario",
                    Value = remesasDTO.EstadoBeneficiario,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vCiudadBeneficiario = new SqlParameter
                {
                    ParameterName = "@vCiudadBeneficiario",
                    Value = remesasDTO.CiudadBeneficiario,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vTelefono = new SqlParameter
                {
                    ParameterName = "@vTelefono",
                    Value = remesasDTO.Telefono,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vIdentificacion = new SqlParameter
                {
                    ParameterName = "@vIdentificacion",
                    Value = remesasDTO.Identificacion,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vNumeroID = new SqlParameter
                {
                    ParameterName = "@vNumeroID",
                    Value = remesasDTO.NumeroID,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vEmitidaPor = new SqlParameter
                {
                    ParameterName = "@vEmitidaPor",
                    Value = remesasDTO.EmitidaPor,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };



                var vFechaEmision = new SqlParameter
                {
                    ParameterName = "@vFechaEmision",
                    Value = remesasDTO.FechaEmision,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vFechaExpiracion = new SqlParameter
                {
                    ParameterName = "@vFechaExpiracion",
                    Value = remesasDTO.FechaExpiracion,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vFechaNacimiento = new SqlParameter
                {
                    ParameterName = "@vFechaNacimiento",
                    Value = remesasDTO.FechaNacimiento,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vOcupacion = new SqlParameter
                {
                    ParameterName = "@vOcupacion",
                    Value = remesasDTO.EmitidaPor,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vNacionalidad = new SqlParameter
                {
                    ParameterName = "@vNacionalidad",
                    Value = remesasDTO.Nacionalidad,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vTrabajo = new SqlParameter
                {
                    ParameterName = "@vTrabajo",
                    Value = remesasDTO.Trabajo,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vSexo = new SqlParameter
                {
                    ParameterName = "@vSexo",
                    Value = remesasDTO.Sexo,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var vEstadoCivil = new SqlParameter
                {
                    ParameterName = "@vEstadoCivil",
                    Value = remesasDTO.EstadoCivil,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vWUCard = new SqlParameter
                {
                    ParameterName = "@vWUCard",
                    Value = remesasDTO.WUCard,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vRemitente1 = new SqlParameter
                {
                    ParameterName = "@vRemitente1",
                    Value = remesasDTO.Remitente1,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vRemitente2 = new SqlParameter
                {
                    ParameterName = "@vRemitente2",
                    Value = remesasDTO.Remitente2,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vRemitente3 = new SqlParameter
                {
                    ParameterName = "@vRemitente3",
                    Value = remesasDTO.Remitente3,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vRemitente4 = new SqlParameter
                {
                    ParameterName = "@vRemitente4",
                    Value = remesasDTO.Remitente4,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vRemitente5 = new SqlParameter
                {
                    ParameterName = "@vRemitente5",
                    Value = remesasDTO.Remitente5,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var vOrigen = new SqlParameter
                {
                    ParameterName = "@vOrigen",
                    Value = remesasDTO.Origen,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var vEstadoOrigen = new SqlParameter
                {
                    ParameterName = "@vEstadoOrigen",
                    Value = remesasDTO.EstadoOrigen,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var vCiudadOrigen = new SqlParameter
                {
                    ParameterName = "@vCiudadOrigen",
                    Value = remesasDTO.CiudadOrigen,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };


                var vFecha = new SqlParameter
                {
                    ParameterName = "@vFecha",
                    Value = remesasDTO.Fecha,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vHora = new SqlParameter
                {
                    ParameterName = "@vHora",
                    Value = remesasDTO.Hora,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vOperador = new SqlParameter
                {
                    ParameterName = "@vOperador",
                    Value = remesasDTO.Operador,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vMTCN = new SqlParameter
                {
                    ParameterName = "@vMTCN",
                    Value = remesasDTO.MTCN,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vMonto = new SqlParameter
                {
                    ParameterName = "@vMonto",
                    Value = remesasDTO.Monto,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vMoneda = new SqlParameter
                {
                    ParameterName = "@vMoneda",
                    Value = remesasDTO.Moneda,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vAgente = new SqlParameter
                {
                    ParameterName = "@vAgente",
                    Value = remesasDTO.Agente,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vIDTerminal = new SqlParameter
                {
                    ParameterName = "@vIDTerminal",
                    Value = remesasDTO.IDTerminal,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vExchangeRate = new SqlParameter
                {
                    ParameterName = "@vExchangeRate",
                    Value = remesasDTO.ExchangeRate,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vTestQuestion = new SqlParameter
                {
                    ParameterName = "@vTestQuestion",
                    Value = remesasDTO.TestQuestion,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vTestAnswer = new SqlParameter
                {
                    ParameterName = "@vTestAnswer",
                    Value = remesasDTO.Monto,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vMensaje = new SqlParameter
                {
                    ParameterName = "@vMensaje",
                    Value = remesasDTO.Mensaje,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vTasaDeCambioFD = new SqlParameter
                {
                    ParameterName = "@vTasaDeCambioFD",
                    Value = remesasDTO.TasaDeCambioFD,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };

                var vMonedaOriginalTransaccionTL = new SqlParameter
                {
                    ParameterName = "@vMonedaOriginalTransaccionTL",
                    Value = remesasDTO.Monto,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };
                var vMontoOriginalTransaccionTL = new SqlParameter
                {
                    ParameterName = "@vMontoOriginalTransaccionTL",
                    Value = remesasDTO.Monto,
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input
                };



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
                    response = ctx.Database.ExecuteSqlCommand("exec @procResult =  uspe_reme_add @vTipo,@vDestinatario1,@vDestinatario2,@vDestinatario3,@vDestinatario4,@vDestinatario5,@vDireccion1,@vDireccion2," +
                        " @vEstadoBeneficiario, @vCiudadBeneficiario,@vTelefono, @vIdentificacion,@vNumeroID, @vEmitidaPor, @vFechaEmision,@vFechaExpiracion, @vFechaNacimiento, @vOcupacion,@vNacionalidad," +
                        " @vTrabajo, @vSexo, @vEstadoCivil, @vWUCard,@vRemitente1, @vRemitente2,@vRemitente3,@vRemitente4,@vRemitente5,@vOrigen,@vEstadoOrigen,@vCiudadOrigen,@vFecha,@vHora,@vOperador,@vMTCN," +
                        " @vMonto, @vMoneda,@vAgente,@vIDTerminal, @vExchangeRate,@vTestQuestion,@vTestAnswer, @vMensaje,@vTasaDeCambioFD,@vMonedaOriginalTransaccionTL, @vMontoOriginalTransaccionTL,@v_out OUTPUT",
                         new object[]
                         {
                         vTipo,vDestinatario1,vDestinatario2,vDestinatario3,vDestinatario4,vDestinatario5,vDireccion1,vDireccion2,vEstadoBeneficiario,vCiudadBeneficiario,vTelefono,vIdentificacion,vNumeroID,vEmitidaPor,
                        vFechaEmision,vFechaExpiracion,vFechaNacimiento,vOcupacion,vNacionalidad,vTrabajo,vSexo,vEstadoCivil,vWUCard,vRemitente1,vRemitente2,vRemitente3,vRemitente4,vRemitente5,vOrigen,vEstadoOrigen,vCiudadOrigen,vFecha,vHora,
                        vOperador,vMTCN,vMonto,vMoneda,vAgente,vIDTerminal,vExchangeRate,vTestQuestion,vTestAnswer,vMensaje,vTasaDeCambioFD,vMonedaOriginalTransaccionTL,vMontoOriginalTransaccionTL
                        ,
                         v_out,procResult
                        }

                        );
                     response = (int)v_out.Value;
                    int resp1 = (int)procResult.Value;

                }

            }
            catch (Exception e)
            {
                throw;
            }

            return response;


        }
    }
}
