using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistance.Contexts
{
    public class ETicaretAPIDbContext : DbContext
    {

        public ETicaretAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : Entityler üzerinden yapılan değişikliklerin ya da yeni eklenen verinin yakalanmaısını sağlayan Property dir.Update operasyonlarında Track edilen verileri 
            //yakalayıp elde etmemizi sağlar.
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.Now;
                        data.Entity.Status = true;
                        data.Entity.IsDeleted = false;
                        break;

                    case EntityState.Modified:
                        data.Entity.LastUpdatedDate = DateTime.Now;
                        data.Entity.Status = true;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);

        }
    }
}
