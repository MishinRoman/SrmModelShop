﻿using System.Collections.Generic;

namespace SrmBL.Model
{
    class Product
    {
        public int ProkuctId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
