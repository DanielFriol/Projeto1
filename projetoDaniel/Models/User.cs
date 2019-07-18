using System.Collections.Generic;

namespace projetoDaniel.Models
{
    public class User:Entity
    {

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public int TipoUsuario { get; set; }

        public List<Avaliation> Avaliacoes { get; set; } = new List<Avaliation>();



    }
}
