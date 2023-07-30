using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Entities.Concrete
{
    public class CategoryLanguage
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string LangCode { get; set; }
        public string SeoUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
