﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RecyclingContainer
    {
        public int Id { get; set; } // Primary Key
        public string ContainerLocation { get; set; }
        public string ContainerType { get; set; }

        [ForeignKey("City")]
        public int CityID { get; set; } 
       



    }
}
