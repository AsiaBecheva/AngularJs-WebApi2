namespace CrmSystem.Data.Repository
{
    using CrmSystem.Models;
    using System.Data.Entity;

    public interface IUnitOfWork
    {
        DbContext Context { get; }

        IRepository<Project> Projects { get; }

        IRepository<Sale> Sales { get; }

        IRepository<Customer> Customers { get; }

        IRepository<Company> Companies { get; }

        IRepository<User> Users { get; }

        IRepository<Product> Products { get; }

        void Dispose();

        int SaveChanges();
    }
}
