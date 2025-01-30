using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User :IdentityUser
    {
        public string FullName { get; set; }


        public ICollection<Contact> Contacts { get; set; }
        public ICollection<News> NewsArticles { get; set; }
        public ICollection<ElectricityCalculation> ElectricityCalculations { get; set; }
        public ICollection<NaturalGasCalculation> NaturalGasCalculations { get; set; }
        public ICollection<CarEmission> CarEmissions { get; set; }
    }
}
