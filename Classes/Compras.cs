namespace trabFinal.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Compras
    {        
        public int Id { get; set; }

        public double PrecoUnitario { get; set; }

        public double PrecoTotal { get; set; }

        public int Qnt { get; set; }

        // public string Lugares { get; set; }

        public Sessoes Sessoes { get; set; }

        public Usuarios Usuarios { get; set; }
    }
}
