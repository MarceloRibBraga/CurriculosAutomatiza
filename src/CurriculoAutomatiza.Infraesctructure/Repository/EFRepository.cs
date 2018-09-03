using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using CurriculoAutomatiza.Core.Interfaces.Repository;
using CurriculoAutomatiza.Infraesctructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CurriculoAutomatiza.Infraesctructure.Repository
{
    public class EFReopsitory<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AutomatizaCurriculoDbContext _dbContext;

        public EFReopsitory(AutomatizaCurriculoDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public virtual TEntity Adicionar(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public virtual void Atualizar(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _dbContext.Set<TEntity>().AsEnumerable();
        }

        public virtual TEntity ObertPorId(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> prediado)
        {
            return _dbContext.Set<TEntity>().Where(prediado).AsEnumerable();
        }

        public void Remover(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
