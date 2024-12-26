using Projet_csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Projet_csharp.Models;

public class Produit
{
    public int ProduitId { get; set; }
    public string Libelle { get; set; }
    public int QuantiteStock { get; set; }
    public decimal PrixUnitaire { get; set; }
    public int QuantiteSeuil { get; set; }
    public string Images { get; set; }
}