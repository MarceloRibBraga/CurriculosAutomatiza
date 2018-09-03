using System;
using System.Collections.Generic;
using System.Text;

namespace CurriculoAutomatiza.Core.Entity
{
    public class Profissional
    {
       public int ProfissionalId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public ICollection<AreasInteresse> AreasInteresses { get; set; }
    }
}
