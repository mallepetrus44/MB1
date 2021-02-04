using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Main.Server.Models
{
    public class Customer : User
    {
        public string Logo { get; set; }

        public int KvkNummer { get; set; }

        public string BtwNummer { get; set; }
    }
}
