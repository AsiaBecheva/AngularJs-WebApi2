namespace CrmSystem.Data
{
    using CrmSystem.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class CrmDbContext : IdentityDbContext<User>
    {
        public CrmDbContext() : base("CrmSystem")
        {
        }

        public virtual IDbSet<Product> Products { get; set; }
        public virtual IDbSet<Project> Projects { get; set; }
        public virtual IDbSet<Customer> Customers { get; set; }
        public virtual IDbSet<Company> Companies { get; set; }
        public virtual IDbSet<Sale> Sales { get; set; }

        public static CrmDbContext Create()
        {
            return new CrmDbContext();
        }
    }
}
