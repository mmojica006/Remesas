using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class WU_Apos
    {
        [Key]
        public string MTCN { get; set; }
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
        public string CodIdentificacion { get; set; }
        public string CodNacionalidad { get; set; }
        public string CodPaisOrigenDestino { get; set; }
        public string CodEstadoOrigen { get; set; }
        public string CodCiudadOrigen { get; set; }
        public string CodMoneda { get; set; }
        public string CodSexo { get; set; }
        public string CodEstadoCivil { get; set; }
        public string Procesado { get; set; }
        public string UsuarioCarga { get; set; }
        public string FechaCarga { get; set; }
        public string HoraCarga { get; set; }
        public string TZ_LOCK { get; set; }

        public AnexGRIDResponde Listar(AnexGRID grid, string usuario)
        {
            try
            {
                using (var ctx = new dbContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;

                    grid.Inicializar();

                    var query = ctx.WU_Apos.Where(x => x.UsuarioCarga == usuario);

                    // Ordenamiento
                    if (grid.columna == "MTCN")
                    {
                        query = grid.columna_orden == "DESC" ? query.OrderByDescending(x => x.MTCN)
                                                             : query.OrderBy(x => x.MTCN);
                    }

                    if (grid.columna == "NumeroID")
                    {
                        query = grid.columna_orden == "DESC" ? query.OrderByDescending(x => x.NumeroID)
                                                             : query.OrderBy(x => x.NumeroID);
                    }

                    if (grid.columna == "UsuarioCarga")
                    {
                        query = grid.columna_orden == "DESC" ? query.OrderByDescending(x => x.UsuarioCarga)
                                                             : query.OrderBy(x => x.UsuarioCarga);
                    }

                    if (grid.columna == "FechaCarga")
                    {
                        query = grid.columna_orden == "DESC" ? query.OrderByDescending(x => x.FechaCarga)
                                                             : query.OrderBy(x => x.FechaCarga);
                    }


                    var wu_apos = query.Skip(grid.pagina)
                                          .Take(grid.limite)
                                          .ToList();

                    var total = query.Count();

                    grid.SetData(wu_apos, total);
                }
            }
            catch (Exception E)
            {

                throw;
            }

            return grid.responde();
        }

    }


}

