using Model.Entity.Entity;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IPessoa
    {
        Pessoa Get(int id);
        IEnumerable<Pessoa> GetAll();
        void Insert(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(Pessoa pessoa);
    }
}
