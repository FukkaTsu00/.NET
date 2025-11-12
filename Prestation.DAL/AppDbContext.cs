using Microsoft.EntityFrameworkCore;

namespace Prestation.DAL.Entities
{
    public class AppDbContext : DbContext
    {
            

        public DbSet<Societe> Societes { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<TypeDocument> TypeDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>()
                .HasIndex(d => new { d.IdPrestation, d.IdTypeDocument, d.NomDocument })
                .IsUnique();

            // Optional: further Fluent API configurations
        }
    }
}
