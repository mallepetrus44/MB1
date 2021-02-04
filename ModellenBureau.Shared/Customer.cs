using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Main.Shared
{
    public class Customer : User
    {
        [Required]
        public int CustomerID { get; set; }

        [Required]
        public string Logo { get; set; }
        [Required]
        [MaxLength(8), MinLength(8)]
        public int KvkNummer { get; set; }
        [Required]
        public string BtwNummer { get; set; }
    }
}
