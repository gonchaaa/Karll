﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Entities.Concrete
{
    public class Category 
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsFeatured { get; set; }
    }
}
