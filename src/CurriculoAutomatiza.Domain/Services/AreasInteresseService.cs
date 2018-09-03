using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CurriculoAutomatiza.Core.Entity;
using CurriculoAutomatiza.Core.Interfaces.Services;

namespace CurriculoAutomatiza.Core.Services
{
    public class AreasInteresseService : IAreasInteresseService
    {
        private readonly IAreasInteresseService _areasInteresseService;
        public AreasInteresseService(IAreasInteresseService areasInteresseService)
        {
            _areasInteresseService = areasInteresseService;
        }
        public AreasInteresse Adicionar(AreasInteresse entity)
        {
            return _areasInteresseService.Adicionar(entity);
        }

        public void Atualizar(AreasInteresse entity)
        {
            _areasInteresseService.Atualizar(entity);
        }

        public IEnumerable<AreasInteresse> ObterTodos()
        {
            return _areasInteresseService.ObterTodos().AsEnumerable();
        }

        public AreasInteresse ObertPorId(int id)
        {
            return _areasInteresseService.ObertPorId(id);
        }

        public IEnumerable<AreasInteresse> Buscar(Expression<Func<AreasInteresse, bool>> predicado)
        {
           return _areasInteresseService.Buscar(predicado);
        }

        public void Remover(AreasInteresse entity)
        {
           _areasInteresseService.Remover(entity);
        }
    }
}
