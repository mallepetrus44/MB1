using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Main.Shared
{
    public class Customer : User
    {
        public int CustomerID { get; set; }

        [Required]
        public string Logo { get; set; }
        [Required]
        public int KvkNummer { get; set; }
        [Required]
        public string BtwNummer { get; set; }
    }
}
