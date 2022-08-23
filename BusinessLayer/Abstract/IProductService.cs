using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService: IGenericService<Product>
    {
        public List<Product> GetListProductUserId(int id);
        
        /* void ProductAdd(Product product);
         void ProductDelete(Product product);
         void ProductUpdate(Product product);
         List<Product> ListAll();
         Product GetById(int id);
         List<Product> GetListWithCategory();*/
    }
}
