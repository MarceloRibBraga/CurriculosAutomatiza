using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using CurriculoAutomatiza.Domain.Entity;
using CurriculoAutomatiza.Domain.Interfaces.Repository;
using CurriculoAutomatiza.Domain.Interfaces.Services;

namespace CurriculoAutomatiza.Domain.Services
{
   public class ProfissionalService : IProfissionalService
   {
       private readonly IProfissionalRepository _profissionalRepository;
        public ProfissionalService(IProfissionalRepository profissionalRepository)
        {
            _profissionalRepository = profissionalRepository;
        }
        public Profissional Adicionar(Profissional entity)
        {
            return _profissionalRepository.Adicionar(entity);
        }

        public void Atualizar(Profissional entity)
        {
            _profissionalRepository.Atualizar(entity);
        }

        public IEnumerable<Profissional> ObterTodos()
        {
           return _profissionalRepository.ObterTodos().AsEnumerable();
        }

        public Profissional ObertPorId(int id)
        {
            return _profissionalRepository.ObertPorId(id);
        }

        public IEnumerable<Profissional> Buscar(Expression<Func<Profissional, bool>> predicado)
        {
            return _profissionalRepository.Buscar(predicado);
        }

        public void Remover(Profissional entity)
        {
            _profissionalRepository.Remover(entity);
        }
    }
}
