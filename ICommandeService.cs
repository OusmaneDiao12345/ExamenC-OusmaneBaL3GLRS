using Projet_csharp.Models;  
using System.Collections.Generic;  
using System.Threading.Tasks;  

namespace Projet_csharp.Services
{
    public interface ICommandeService
    {
        Task<IEnumerable<Commande>> GetAllCommandesAsync();  
        Task<Commande> GetCommandeByIdAsync(int id);  
        Task CreateCommandeAsync(Commande commande);  
        Task UpdateCommandeAsync(Commande commande);  
        Task<IEnumerable<Commande>> GetCommandesEnAttenteAsync();  
    }
}
