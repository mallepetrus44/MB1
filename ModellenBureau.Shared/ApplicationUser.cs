using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Main.Server.Models
{
    public class User
    {
        // ID voor de ApplicationUser
        public int AppUserId { get; set; }

        // NAW gegevens
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        public Country Land { get; set; }

    }

    public enum Country
    {
        België,
        Duitsland,
        Nederland,
        Anders

    }
}
