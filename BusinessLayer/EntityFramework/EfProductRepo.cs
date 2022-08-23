using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using DataAccessLayer.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntityFramework
{
    public class EfProductRepo:GenericRepo<Product>, IProduct
    {
        public List<Product> GetListWithCategory()
        {
            using(var context=new Context())
            {
                return null;
            }
        }
    }
}
