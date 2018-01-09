namespace trabFinal.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Salas
    {        
        public int Id { get; set; }

        [StringLength(30)]
        public string Nome { get; set; }

        public int Capacidade { get; set; }
    }
}
