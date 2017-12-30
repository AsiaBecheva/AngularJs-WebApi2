
using CrmSystem.Data.Repository;
using CrmSystem.Models;
using CrmSystem.Server.Models;
using System.Collections.Generic;

namespace CrmSystem.Tests.Mocks
{
    public abstract class UnitOfWorkMock : IUnitOfWorkMock
    {
        public UnitOfWorkMock()
        {
            this.FakeData();
            this.ArrangeUnitOfWorkMock();
        }

        public ICollection<Customer> FakeCustomers { get; private set; }

        public IUnitOfWork Data { get; set; }

        private void FakeData()
        {
            this.FakeCustomers = new List<Customer>
            {
                new Customer{ Id = 1, Name = "Asya", Email = "asd1@gmail.com", Phone = 0884088461, Info = "asdASDInfo!" },
                new Customer{ Id = 2, Name = "Ase", Email = "asd2@gmail.com", Phone = 0884088462, Info = "asdASDIngffo!" },
                new Customer{ Id = 3, Name = "Aseto", Email = "asd3@gmail.com", Phone = 0884088464, Info = "asdASDvcInfo!" },
                new Customer{ Id = 4, Name = "SomeAse", Email = "asd4@gmail.com", Phone = 0884088465, Info = "asdASDIgfdnfo!" }
            };
        }

        protected abstract void ArrangeUnitOfWorkMock();
    }
}
