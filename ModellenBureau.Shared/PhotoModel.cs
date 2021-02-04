using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Main.Server.Models
{
    public class PhotoModel : User
    {
        public int PhotoModelID { get; set; }
        public int Leeftijd
        {
            get { return (DateTime.Today - Geboortedatum).Days / 365; }
        }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }

        [Required]
        public double Bovenwijdte { get; set; }
        [Required]
        public double Taillewijdte { get; set; }
        [Required]
        public double Heupwijdte { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Fotos { get; set; }
    }
}
