using Microsoft.EntityFrameworkCore;  
using Projet_csharp.Data;  
using Projet_csharp.Models;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  


namespace Projet_csharp.services;

public interface IPaiementService
{
    Task<IEnumerable<Paiement>> GetAllPaiementsAsync();
    Task CreatePaiementAsync(Paiement paiement);
}

public class PaiementService : IPaiementService
{
    private readonly ApplicationDbContext _context;

    public PaiementService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Paiement>> GetAllPaiementsAsync()
    {
        return await _context.Paiements.Include(p => p.Client).ToListAsync();
    }

    public async Task CreatePaiementAsync(Paiement paiement)
    {
        _context.Add(paiement);
        await _context.SaveChangesAsync();
    }
}
