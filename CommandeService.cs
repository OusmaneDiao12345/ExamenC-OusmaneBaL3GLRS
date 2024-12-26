using Microsoft.EntityFrameworkCore;  
using Projet_csharp.Data;  
using Projet_csharp.Models;  
using System.Collections.Generic; 
using System.Linq;  
using System.Threading.Tasks;  

namespace Projet_csharp.services;

public interface ICommandeService
{
    Task<IEnumerable<Commande>> GetAllCommandesAsync();
    Task<Commande> GetCommandeByIdAsync(int id);
    Task CreateCommandeAsync(Commande commande);
    Task UpdateCommandeAsync(Commande commande);
    Task<IEnumerable<Commande>> GetCommandesEnAttenteAsync();
}

public class CommandeService : ICommandeService
{
    private readonly ApplicationDbContext _context;

    public CommandeService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Commande>> GetAllCommandesAsync()
    {
        return await _context.Commandes.Include(c => c.Client)
                                       .Include(c => c.Produits)
                                       .ToListAsync();
    }

    public async Task<Commande> GetCommandeByIdAsync(int id)
    {
        return await _context.Commandes.Include(c => c.Client)
                                       .Include(c => c.Produits)
                                       .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task CreateCommandeAsync(Commande commande)
    {
        _context.Add(commande);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCommandeAsync(Commande commande)
    {
        _context.Update(commande);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Commande>> GetCommandesEnAttenteAsync()
    {
        return await _context.Commandes.Where(c => c.EstEnAttente)
                                       .ToListAsync();
    }
}
