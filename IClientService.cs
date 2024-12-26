using Projet_csharp.Models;  
using System.Collections.Generic;  
using System.Threading.Tasks;

namespace Projet_csharp.Services;


public interface IClientService
{
    IEnumerable<Client> GetAllClients();
    Client GetClientById(int id);
    void AddClient(Client client);
    void UpdateClient(Client client);
    void DeleteClient(int id);
}
