using Projet_csharp.Models;  
using System.Collections.Generic;  
using System.Threading.Tasks;  

namespace Projet_csharp.Services
{
    public interface IPaiementService
    {
        Task<IEnumerable<Paiement>> GetAllPaiementsAsync();  // Récupérer tous les paiements
        Task<Paiement> GetPaiementByIdAsync(int id);  // Récupérer un paiement par son ID
        Task CreatePaiementAsync(Paiement paiement);  // Créer un nouveau paiement
        Task UpdatePaiementAsync(Paiement paiement);  // Mettre à jour un paiement existant
        Task<IEnumerable<Paiement>> GetPaiementsParClientAsync(int clientId);  // Récupérer les paiements d'un client
    }
}
