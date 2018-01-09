namespace trabFinal.Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Compras> Compras { get; set; }

        public virtual DbSet<Filmes> Filmes { get; set; }

        public virtual DbSet<Salas> Salas { get; set; }

        public virtual DbSet<Sessoes> Sessoes { get; set; }

        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
