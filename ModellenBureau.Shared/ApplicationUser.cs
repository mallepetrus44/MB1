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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string Postal { get; set; }
        public Country Country { get; set; }

    }

    public enum Country
    {
        Belgium,
        Germany,
        Netherlands,
        Other

    }
}
