using Model.Entity.Base;
using Model.Entity.Entity;
using Service.Interfaces;
using System.Collections.Generic;

namespace Service.Servico
{
    public class PessoaServico : IPessoa
    {
        private readonly IRepositoryBase<Pessoa> _repositoryBase;

        public PessoaServico(IRepositoryBase<Pessoa> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public Pessoa Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public void Insert(Pessoa pessoa)
        {
            _repositoryBase.Insert(pessoa);
        }

        public void Update(Pessoa pessoa)
        {
            _repositoryBase.Update(pessoa);
        }

        public void Delete(Pessoa pessoa)
        {
            _repositoryBase.Delete(pessoa);
        }
    }
}
