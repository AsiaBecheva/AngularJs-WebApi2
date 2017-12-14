using System;
using System.Collections.Generic;

namespace CrmSystem.Models
{
    public class Sale
    {
        private ICollection<Product> products;
        public Sale()
        {
            this.products = new HashSet<Product>();
            this.SoldOn = DateTime.Now;
        }

        public int Id { get; set; }

        public DateTime SoldOn { get; set; }

        public virtual ICollection<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }

        public virtual Customer Customer { get; set; }

        public virtual Company Company { get; set; }
    }
}
