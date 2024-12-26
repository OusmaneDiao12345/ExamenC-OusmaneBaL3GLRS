using Projet_csharp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Projet_csharp.Data;    

namespace Projet_csharp.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Produit> Produits { get; set; }
    public DbSet<Commande> Commandes { get; set; }
    public DbSet<Paiement> Paiements { get; set; }
    public DbSet<Livraison> Livraisons { get; set; }
    public DbSet<Livreur> Livreurs { get; set; }

    public ApplicationDbContext() : base("DefaultConnection")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<Commande>()
            .HasRequired(c => c.Client)
            .WithMany(cl => cl.Commandes)
            .HasForeignKey(c => c.ClientId);

        modelBuilder.Entity<Paiement>()
            .HasRequired(p => p.Commande)
            .WithMany()
            .HasForeignKey(p => p.CommandeId);

        modelBuilder.Entity<Livraison>()
            .HasRequired(l => l.Commande)
            .WithMany()
            .HasForeignKey(l => l.CommandeId);

        base.OnModelCreating(modelBuilder);
    }
}