using CurriculoAutomatiza.Core.Entity;
using CurriculoAutomatiza.Core.Interfaces.Repository;
using CurriculoAutomatiza.Infraesctructure.Data;

namespace CurriculoAutomatiza.Infraesctructure.Repository
{
   public class ProfissionalRepository : EFReopsitory<Profissional> , IProfissionalRepository
    {
        public ProfissionalRepository(AutomatizaCurriculoDbContext dbContext) : base (dbContext)
        {
                
        }
    }
}
