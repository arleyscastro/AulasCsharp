using Microsoft.EntityFrameworkCore;
using Model.Entity.Entity;
using Model.Entity.Map;

namespace Model.Entity
{
    public class AppContext: DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            new MapPessoa(model.Entity<Pessoa>());
        }
    }
}
