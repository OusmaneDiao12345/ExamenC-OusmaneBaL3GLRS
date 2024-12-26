using Microsoft.AspNetCore.Mvc;  
using Projet_csharp.Models; 
using Projet_csharp.Services; 
using System.Threading.Tasks;

namespace Projet_csharp.Controller;

public class CommandeController : Controller
{
    private readonly ApplicationDbContext _context;

    public CommandeController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Action pour enregistrer une commande
    public IActionResult Create(Commande commande)
    {
        if (ModelState.IsValid)
        {
            _context.Add(commande);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(commande);
    }
}
