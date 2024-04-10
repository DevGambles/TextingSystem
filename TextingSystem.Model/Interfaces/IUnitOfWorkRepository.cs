using System;

namespace TextingSystem.Model.Interfaces
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        int Commit();

        ICustomersRepository CustomersStorage { get; }
    }
}

