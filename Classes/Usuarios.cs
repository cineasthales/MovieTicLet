namespace trabFinal.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Login { get; set; }

        [StringLength(30)]
        public string Senha { get; set; }

        public int Nivel { get; set; }
    }
}
