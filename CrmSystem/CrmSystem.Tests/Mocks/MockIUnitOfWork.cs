using CrmSystem.Data.Repository;
using CrmSystem.Models;
using Moq;
using System.Linq;

namespace CrmSystem.Tests.Mocks
{
    public class MockIUnitOfWork: UnitOfWorkMock, IUnitOfWorkMock
    {
        protected override void ArrangeUnitOfWorkMock()
        {
            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(x => x.Customers.Add(It.IsAny<Customer>())).Verifiable();
            mockedUnitOfWork.Setup(x => x.Customers.All()).Returns(this.FakeCustomers.AsQueryable());
            mockedUnitOfWork.Setup(x => x.Customers.GetById(It.IsAny<int>())).Returns(this.FakeCustomers.First());
            mockedUnitOfWork.Setup(x => x.Customers.Delete(It.IsAny<Customer>())).Verifiable();
            this.Data = mockedUnitOfWork.Object;
        }
    }
}
