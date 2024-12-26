using System.Linq;
using System.Web.Mvc;
using Projet_csharp.controller;
using Microsoft.EntityFrameworkCore;

namespace Projet_csharp.controller;

public class ClientsController : Controller
{
    private ApplicationDbContext db = new ApplicationDbContext();

    public ActionResult Index()
    {
        var clients = db.Clients.ToList();
        return View(clients);
    }

    public ActionResult Details(int id)
    {
        var client = db.Clients.Find(id);
        if (client == null)
        {
            return HttpNotFound();
        }
        return View(client);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Client client)
    {
        if (ModelState.IsValid)
        {
            db.Clients.Add(client);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(client);
    }
}