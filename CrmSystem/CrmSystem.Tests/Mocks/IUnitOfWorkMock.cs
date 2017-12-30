using CrmSystem.Data.Repository;

namespace CrmSystem.Tests.Mocks
{
    public interface IUnitOfWorkMock
    {
        IUnitOfWork Data { get; set; }
    }
}
