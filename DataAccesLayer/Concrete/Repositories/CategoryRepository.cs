using DataAccesLayer.Abstract;
using EntityLayer.Concerete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    class CategoryRepository : ICategoryDal
    {

        Context c = new Context();
        DbSet<Category> _object;    
        public void Delete(Category category)
        {
            _object.Remove(category);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category category)
        {
            _object.Add(category);
            c.SaveChanges();
        }

        public List<Category> List()
        {
           return _object.ToList();
            
        
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            c.SaveChanges();
        }
    }
}
