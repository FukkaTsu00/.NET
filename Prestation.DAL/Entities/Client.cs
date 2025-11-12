using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestation.DAL.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nom { get; set; } = null!;

        [Required, StringLength(100)]
        public string Prenom { get; set; } = null!;

        [Required, StringLength(20)]
        public string Telephone { get; set; } = null!;

        [Required, StringLength(100)]
        public string Email { get; set; } = null!;

        [StringLength(255)]
        public string? Adresse { get; set; }

        public DateTime DateInscription { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string TypeClient { get; set; } = "Particulier";

        // Navigation
        public ICollection<Contrat>? Contrats { get; set; }
    }
}
