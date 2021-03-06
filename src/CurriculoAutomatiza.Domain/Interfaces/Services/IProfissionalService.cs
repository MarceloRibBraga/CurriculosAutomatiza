﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using CurriculoAutomatiza.Core.Entity;

namespace CurriculoAutomatiza.Core.Interfaces.Services
{
    public  interface IProfissionalService
    {
        Profissional Adicionar(Profissional entity);
        void Atualizar(Profissional entity);
        IEnumerable<Profissional> ObterTodos();
        Profissional ObertPorId(int id);
        IEnumerable<Profissional> Buscar(Expression<Func<Profissional, bool>> predicado);
        void Remover(Profissional entity);
    }
}
