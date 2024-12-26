using Projet_csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Projet_csharp.Models;

public class Livraison
{
    public int LivraisonId { get; set; }
    public DateTime Date { get; set; }
    public string AdresseLivraison { get; set; }

    public int CommandeId { get; set; }
    public virtual Commande Commande { get; set; }
}