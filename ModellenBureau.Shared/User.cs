using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Shared
{
    public class User
    {
        public int AppUserId { get; set; }
        [Required]
        public bool Verified { get; set; }

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
        public string Stad { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Paswoord { get; set; }

    }

}
