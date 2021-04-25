using EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD
        //Type Name();
        //Örnektir Dogrusu Böyle Yapılmazz 
        List<Category> List();

        void Insert(Category category);
        void Update(Category category);
        void Delete(Category category);




    }
}
