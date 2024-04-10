using TextingSystem.Services.Messaging.Common.Client;
using System.Threading.Tasks;

namespace TextingSystem.Services.Interfaces.Common.Client
{
    public interface IClientService
    {
        CreateClientResponse NewClient(CreateClientRequest request);
    }
}