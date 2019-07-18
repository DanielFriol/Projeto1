using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoDaniel.Models
{


    [Table("Bus")]
    public class Buses:Entity
    {
     
        [Column(TypeName= "varchar(10)")]
        [Required]
        public string Prefixo { get; set; }
        [Required]
        public int Quantidadelugares { get; set; }
        [Required]
        public int Linha { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Empresa { get; set; }

        public List<Avaliation> Avaliacoes { get; set; } = new List<Avaliation>();

    }

}
