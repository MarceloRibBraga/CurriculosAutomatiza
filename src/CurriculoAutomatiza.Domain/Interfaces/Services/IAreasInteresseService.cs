using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using CurriculoAutomatiza.Domain.Entity;

namespace CurriculoAutomatiza.Domain.Interfaces.Services
{
    public interface IAreasInteresseService
    {
        AreasInteresse Adicionar(AreasInteresse entity);
        void Atualizar(AreasInteresse entity);
        IEnumerable<AreasInteresse> ObterTodos();
        AreasInteresse ObertPorId(int id);
        IEnumerable<AreasInteresse> Buscar(Expression<Func<AreasInteresse, bool>> predicado);
        void Remover(AreasInteresse entity);
    }
}
