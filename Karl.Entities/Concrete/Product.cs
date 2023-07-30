using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Entities.Concrete
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal Rating { get; set; }
        public int Views { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public bool IsFeatured { get; set; }

    }
}
