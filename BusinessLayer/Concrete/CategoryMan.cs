using BusinessLayer.Abstract;
using BusinessLayer.EntityFramework;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryMan : ICategoryService
    {
        ICategory ıcategory;
        

        public CategoryMan(ICategory ıcategory)
        {
            this.ıcategory = ıcategory;
        }
        /*
        public void CategoryAdd(Category category)
        {
            ıcategory.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            ıcategory.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            ıcategory.Update(category);
        }
        */
        public Category GetById(int id)
        {
            return ıcategory.GetById(id);
        }

        public List<Category> ListAll()
        {
            return ıcategory.ListAll();
        }

        public void TAdd(Category t)
        {
            ıcategory.Insert(t);
        }

        public void TDelete(Category t)
        {
            ıcategory.Delete(t);
        }

        public void TUpdate(Category t)
        {
            ıcategory.Update(t);

        }
    }
}
