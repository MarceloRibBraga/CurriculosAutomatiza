using System;
using System.Collections.Generic;
using System.Text;

namespace CurriculoAutomatiza.Core.Entity
{
    public class AreasInteresse
    {
        public int AreasInteresseId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int ProfissionalId { get; set; }
        public Profissional Profissional { get; set; }

    }
}
