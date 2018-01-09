namespace trabFinal.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sessoes
    {
        public int Id { get; set; }

        [StringLength(5)]
        public string Horario { get; set; }

        [StringLength(10)]
        public string Data { get; set; }

        public bool Legendado { get; set; }

        public bool TresD { get; set; }

        //[StringLength(300)]
        //public string Ocupados { get; set; }

        public int QntOcupados { get; set; }

        [StringLength(300)]
        public string TextoSessao { get; set; }

        public Filmes Filmes { get; set; }

        public Salas Salas { get; set; }
    }
}
