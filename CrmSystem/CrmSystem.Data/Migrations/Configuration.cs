namespace CrmSystem.Data.Migrations
{
    using CrmSystem.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CrmDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CrmDbContext context)
        {
            if (!context.Sales.Any())
            {
                var customers = new List<Customer>();
                var companies = new List<Company>();
                var projects = new List<Project>();
                var products = new List<Product>();
                var sales = new List<Sale>();

                for (int i = 0; i < 15; i++)
                {
                    var customer = new Customer
                    {
                        Email = "asd" + i + "@gmail.com",
                        Name = "Customer-" + i,
                        Phone = 08841122 + i + i,
                        Info = "asdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasd"
                    };

                    customers.Add(customer);
                    context.Customers.Add(customer);

                    var company = new Company
                    {
                        Email = "asd" + i + "@gmail.com",
                        Name = "Customer-" + i,
                        Info = "hfkdhsfjkhdkhfkdhsfjkhdkhfkdhsfjkhdkhfkdhsfjkhdkhfkdhsfjkhdkhfkdhsfjkhdkhfkdhsfjkhdk"
                    };

                    companies.Add(company);
                    context.Companies.Add(company);

                    var project = new Project
                    {
                        Name = "Project-" + i,
                        Description = "DJSDJFKLDSJFDDJSDJFKLDSJFDDJSDJFKLDSJFDDJSDJFKLDSJFDDJSDJFKLDSJFD",
                        Customer = customer,
                        Company = company
                    };

                    projects.Add(project);
                    context.Projects.Add(project);

                    var product = new Product
                    {
                        Name = "Product" + i,
                        Price = i + 4545 + i * 20,
                        Info = "Info for product asd Info for product asd Info for product asd"
                    };

                    products.Add(product);
                    context.Products.Add(product);

                    var sale = new Sale()
                    {
                        Products = new List<Product>
                        {
                            new Product
                            {
                                Name = "Product" + i + 200,
                                Price = i + 4545 + i * 2,
                                Info = "Info for product asd Info for product asd Info for product asd"
                            },
                            new Product
                            {
                                Name = "Product" + i + 100,
                                Price = i + 4545 + i * 3,
                                Info = "Info for product asd Info for product asd Info for product asd"
                            }
                        },
                        Company = company,
                        Customer = customer
                    };

                    sales.Add(sale);
                    context.Sales.Add(sale);

                };

                context.SaveChanges();
            }

        }
    }
}
