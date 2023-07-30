using Karl.Core.DataAccess;
using Karl.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.DataAccess.Abstract
{
    public interface IProductDal : IRepostoryBase<Product>
    {
    }
}
