namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=dbContext")
        {
        }

        public virtual DbSet<WU_Auditoria> WU_Auditoria { get; set; }
        public virtual DbSet<WU_Apos> WU_Apos { get; set; }
        public virtual DbSet<WU_TablaDato> WU_TablaDato { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
