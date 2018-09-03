using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurriculoAutomatiza.Api.Models;
using CurriculoAutomatiza.Core.Entity;
using CurriculoAutomatiza.Core.Interfaces.Repository;
using CurriculoAutomatiza.Core.Interfaces.Services;
using CurriculoAutomatiza.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoAutomatiza.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Profissional")]
    public class ProfissionalController : Controller
    {
        private readonly IProfissionalRepository _profissionalService;

        public ProfissionalController(IProfissionalRepository profissionalService)
        {
            _profissionalService = profissionalService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Profissional> Get()
        {
            return _profissionalService.ObterTodos();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]ProfissionalModel value)
        {
            var profisssional = new Profissional();
            profisssional.Cpf = value.Cpf;
            profisssional.Nome = value.Nome;
            profisssional.Email = value.Email;
            profisssional.Senha = value.Senha;
            profisssional.Telefone = value.Telefone;

            _profissionalService.Adicionar(profisssional);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}