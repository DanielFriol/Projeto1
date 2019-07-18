using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoDaniel.Models
{
    public class Avaliation:Entity 
    {
        [Required]
        public int Space { get; set; }
        [Required]
        public int Barulho { get; set; }
        [Required]
        public int Balanco { get; set; }
        [Required]
        public int ArCond { get; set; }
        [Required]
        public int Conforto { get; set; }
        [Required]
        public int  TemWifi { get; set; }
        
        public int BusId { get; set; }

        [ForeignKey(nameof(BusId))]
        public Buses Bus { get; set; }
        /*
        public int UsuarioId { get; set; }

        [ForeignKey(nameof(UsuarioId))]
        public User User { get; set; }
        */

    }
}
