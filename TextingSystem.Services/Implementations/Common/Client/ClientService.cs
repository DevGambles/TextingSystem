using TextingSystem.Services.Interfaces.Common.Client;
using TextingSystem.Core.Cryptography;
using TextingSystem.Model.DataModel;
using TextingSystem.Model.Interfaces;
using TextingSystem.Services.Messaging.Common.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TextingSystem.Services.Implementations.Common.Client
{
    public class ClientService : IClientService
    {
        private readonly ICryptographyService _cryptographer = null;
        private readonly IApplicationSettings _settings = null;
        private readonly IUnitOfWorkRepository _dbStorage = null;

        public ClientService(
            IUnitOfWorkRepository dbStorage,
            ICryptographyService cryptographer,
            IApplicationSettings settings
        )
        {
            _dbStorage = dbStorage;
            _cryptographer = cryptographer;
            _settings = settings;
        }

        public CreateClientResponse NewClient(CreateClientRequest request)
        {

            if (request == null)
            {
                throw new ArgumentNullException();
            }


            Customer customer = new Customer();
            customer.first_name = request.FirstName;
            customer.last_name = request.LastName;
            customer.AspNetUserId = request.UserId;
            customer.customer_type = "C";
            customer.date_created = DateTime.Now;
            customer.track_password = _cryptographer.EncryptAES(request.Password, _settings.AESKey);
            customer.AESApplied = true;
            _dbStorage.CustomersStorage.Insert(customer);


            _dbStorage.Commit();

            return new CreateClientResponse { };
        }
    }
}
