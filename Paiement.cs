using Projet_csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Projet_csharp.Models;

public class Paiement
{
    public int PaiementId { get; set; }
    public DateTime Date { get; set; }
    public decimal Montant { get; set; }
    public string TypePaiement { get; set; }
    public string Reference { get; set; }

    public int CommandeId { get; set; }
    public virtual Commande Commande { get; set; }
}