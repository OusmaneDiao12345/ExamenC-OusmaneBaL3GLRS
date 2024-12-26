using Projet_csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Projet_csharp.Models;

public class Commande
{
    public int CommandeId { get; set; }
    public DateTime Date { get; set; }
    public decimal Montant { get; set; }
    public string Etat { get; set; }

    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
    public virtual ICollection<Produit> Produits { get; set; }
}