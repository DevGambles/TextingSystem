using TextingSystem.Core.Domain;
using TextingSystem.Model.DataModel;

namespace TextingSystem.Model.Interfaces
{
    public interface ICustomersRepository : IRepository<Customer, int>
    {
        CustomerProfile GetProfile(string userName);
    }
}

