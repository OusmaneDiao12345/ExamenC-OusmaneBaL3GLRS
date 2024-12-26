using Projet_csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Projet_csharp.Models;

public class Livreur
{
    public int LivreurId { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Telephone { get; set; }
}