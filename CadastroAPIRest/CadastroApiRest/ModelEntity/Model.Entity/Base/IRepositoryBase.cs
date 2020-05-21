using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity.Base
{
    public interface IRepositoryBase<TEntidade>
    {
        TEntidade Get(int id);
        IEnumerable<TEntidade> GetAll();
        void Insert(TEntidade entidade);
        void Update(TEntidade entidade);
        void Delete(TEntidade entidade);
    }
}
