using BusinessLayer.Abstract;
using Entity.Concrete;
using DataAccessLayer.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductMan : IProductService
    {
        IProduct ıproduct;

        public ProductMan(IProduct ıproduct)
        {
            this.ıproduct = ıproduct;
        }

        public Product GetById(int id)
        {
            return ıproduct.GetById(id);
        }

        public List<Product> GetListProductUserId(int id)
        {
            return ıproduct.GetListAll(x => x.UserId == id);
        }
        public List<Product> GetListWithCategory()
        {
            return ıproduct.GetListWithCategory();
        }

        public List<Product> ListAll()
        {
            return ıproduct.ListAll();
        }
        public List<Product> GetProductById(int id)
        {
            return ıproduct.GetListAll(x => x.ProductId==id);
        }

        public void ProductAdd(Product product)
        {
            throw new NotImplementedException();
        }

        public void ProductDelete(Product product)
        {
            throw new NotImplementedException();
        }

        public void ProductUpdate(Product product)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Product t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Product t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
