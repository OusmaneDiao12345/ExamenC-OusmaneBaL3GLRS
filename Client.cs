using Projet_csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Projet_csharp.Models;

public class Client
{
    public int ClientId { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Telephone { get; set; }
    public string Adresse { get; set; }
    public decimal SoldeCompte { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; }
}

