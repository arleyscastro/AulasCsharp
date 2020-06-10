using Microsoft.AspNetCore.Mvc;
using Model.Entity.Entity;
using Service.Interfaces;
using System.Collections.Generic;

namespace WebAppUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoa _pessoa;

        public PessoaController(IPessoa pessoa)
        {
            _pessoa = pessoa;
        }

        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            //regra de negócio
            return _pessoa.GetAll();
        }

        [HttpGet("{id}")]
        public Pessoa Get(int id)
        {
            // B.O.
            return _pessoa.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Pessoa pessoa)
        {
            _pessoa.Insert(pessoa);
        }

        [HttpPut]
        public void Put([FromBody] Pessoa pessoa)
        {
            _pessoa.Update(pessoa);
        }

        [HttpDelete]
        public void Delete([FromBody] Pessoa pessoa)
        {
            _pessoa.Delete(pessoa);
        }

    }
}
