using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoDaniel.Models
{

    
    [Table(nameof(Buses))]
    public class Buses:Entity
    {
        [Column(TypeName= "varchar(10)")]
        [Required(ErrorMessage ="Campo é obrigatório")]
        public string Prefixo { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        public int Quantidadelugares { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        public int Linha { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo é obrigatório")]
        public string Empresa { get; set; }

        public List<Avaliation> Avaliacoes { get; set; } = new List<Avaliation>();

    }

}
