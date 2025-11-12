using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestation.DAL.Entities
{
    public class Prestataire
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

        [StringLength(100)]
        public string? Specialite { get; set; }

        public decimal TarifHoraire { get; set; }

        public bool Disponible { get; set; } = true;

        public DateTime DateInscription { get; set; } = DateTime.Now;

        // Navigation
        public ICollection<Prestation>? Prestations { get; set; }
    }
}
