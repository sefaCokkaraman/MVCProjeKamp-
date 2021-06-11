using BusinnesLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;


     
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categoryDal.List(); ;
        
        }

    
        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);

        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x=>x.CategoryID==id);

        
        }

        public void CategoryDelete(Category category)
        {

            _categoryDal.Delete(category);
            


        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
