﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_ASP_Final.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Icon { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}