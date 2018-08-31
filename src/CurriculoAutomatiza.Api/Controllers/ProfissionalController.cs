using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurriculoAutomatiza.Api.Models;
using CurriculoAutomatiza.Domain.Entity;
using CurriculoAutomatiza.Domain.Interfaces.Services;
using CurriculoAutomatiza.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoAutomatiza.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Profissional")]
    public class ProfissionalController : Controller
    {
        private readonly IProfissionalService _profissionalService;

        /// <summary>
        /// o erro está aqui
        /// </summary>
        /// <param name="profissionalService"></param>
        public ProfissionalController(IProfissionalService profissionalService)
        {
            _profissionalService = profissionalService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            
            return new string[] { "value1", "value2" };
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

            //_profissionalService.Adicionar(profisssional);
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