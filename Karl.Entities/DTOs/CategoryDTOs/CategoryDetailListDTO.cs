using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Entities.DTOs.CategoryDTOs
{
    public class CategoryDetailListDTO
    {
        public int Id { get; set; }
        public string CatgeoryName { get; set; }
        public string SeoUrl { get; set; }
        public int ProductCount { get; set; }
        public string PhotoUrl { get; set; }
    }
}
