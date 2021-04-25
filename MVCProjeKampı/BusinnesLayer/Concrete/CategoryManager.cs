using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAllBL()
        {

            return repo.List();

        }
        public void CategoryAddBL(Category p)
        {

            if (p.CategoryName==null||p.CategoryName.Length<3||p.CategoryDescription==""||p.CategoryName.Length>=51)
            {
                //Hata Mesajı
            }
            else
            {
                repo.Insert(p);
            }



        }


    }
}
