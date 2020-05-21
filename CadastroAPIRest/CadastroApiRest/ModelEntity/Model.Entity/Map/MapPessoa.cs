using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entity.Entity;

namespace Model.Entity.Map
{
    public class MapPessoa
    {
        public MapPessoa(EntityTypeBuilder<Pessoa> etPessoa)
        {
            etPessoa.HasKey(pessoa => pessoa.id);
        }
    }
}
