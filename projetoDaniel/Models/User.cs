using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoDaniel.Models
{
    [Table(nameof(User))]
    public class User:Entity
    {
        [Column(TypeName="Varchar(100)")]
        [Required(ErrorMessage ="Campo é obrigatório")]
        public string Nome { get; set; }
        [Column(TypeName = "Varchar(100)")]
        [Required(ErrorMessage = "Campo é obrigatório")]
        public string Email { get; set; }
        [Column(TypeName = "Varchar(100)")]
        [Required(ErrorMessage = "Campo é obrigatório")]
        public string Senha { get; set; }

        public int TipoUsuario { get; set; } 

        public List<Avaliation> Avaliacoes { get; set; } = new List<Avaliation>();



    }
}
