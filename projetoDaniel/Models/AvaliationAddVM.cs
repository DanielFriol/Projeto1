using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDaniel.Models
{
    public class AvaliationAddVM
    {
        public Buses Bus { get; set; }
        public User User { get; set; }

        int um = 1;
        int dois = 2;
        int tres = 3;
        int quatro = 4;
        int cinco = 5;

        public List<Avaliation> avaliations { get; set; }

        [Required(ErrorMessage = "Campo é obrigatório")]
        public int Space { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        public int Barulho { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        public int Balanco { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        public int ArCond { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        public int Conforto { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        public int TemWifi { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        public int BusId { get; set; }

        public int UsuarioId { get; set; }

    }
}
