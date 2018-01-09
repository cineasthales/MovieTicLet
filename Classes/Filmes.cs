namespace trabFinal.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Filmes
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string TituloOriginal { get; set; }

        [StringLength(100)]
        public string TituloNacional { get; set; }

        public int Duracao { get; set; }

        public int Classificacao { get; set; }

        [StringLength(200)]
        public string Sinopse { get; set; }

        [StringLength(30)]
        public string Genero { get; set; }
    }
}
