using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class WU_TablaDato
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Relacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Valor { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public int Orden { get; set; }

        public WU_TablaDato Obtener(string relacion, int orden)
        {
            var dato = new WU_TablaDato();

            try
            {
        
            using (var ctx = new dbContext())
            {
                dato = ctx.WU_TablaDato.Where(x => x.Relacion == relacion)
                                        .Where(x => x.Orden == orden)
                                         .SingleOrDefault();
            }

            }catch(Exception ex)
            {
                throw;
            }
            return dato;
        }

    }





}
