using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurriculoAutomatiza.Api.Models
{
    public class AreasInteresseModel
    {
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int ProfissionalId { get; set; }
        public ProfissionalModel Profissional { get; set; }
    }
}
