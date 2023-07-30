using Karl.Core.DataAccess.EntityFrameWork;
using Karl.DataAccess.Abstract;
using Karl.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.DataAccess.Concrete.EntityFrameWork
{
    public class EfProductDal : EfRepostoryBase<Product,AppDbContext>,IProductDal
    {
    }
}
