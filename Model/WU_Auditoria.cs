namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class WU_Auditoria
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MTCN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ordinal { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        [Required]
        [StringLength(10)]
        public string UsuarioMov { get; set; }

        [StringLength(10)]
        public string Usuario2 { get; set; }

        [Required]
        [StringLength(10)]
        public string Movimiento { get; set; }

        [Required]
        [StringLength(10)]
        public string Tipo { get; set; }

        [StringLength(100)]
        public string Comentario { get; set; }


        public int Conteo()
        {
            using (var ctx = new dbContext())
            {
                return ctx.WU_Auditoria.Count();

            }
        }
    }
}
