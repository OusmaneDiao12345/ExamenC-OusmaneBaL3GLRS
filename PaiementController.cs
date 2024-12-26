using Microsoft.AspNetCore.Mvc;  
using Projet_csharp.Models;  
using Projet_csharp.Services; 
using System.Threading.Tasks; 

namespace Projet_csharp.Controller;

public class PaiementController : Controller
{
    private readonly IPaiementService _paiementService;

    public PaiementController(IPaiementService paiementService)
    {
        _paiementService = paiementService;
    }

    // Action pour afficher la liste des paiements
    public async Task<IActionResult> Index()
    {
        var paiements = await _paiementService.GetAllPaiementsAsync();
        return View(paiements);
    }

    // Action pour enregistrer un paiement
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Paiement paiement)
    {
        if (ModelState.IsValid)
        {
            await _paiementService.CreatePaiementAsync(paiement);
            return RedirectToAction("Index");
        }
        return View(paiement);
    }
}
