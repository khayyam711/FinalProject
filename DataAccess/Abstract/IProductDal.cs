using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
       

        void Add(Product product );
        new void Update(Product product);
        void Delete(Product product);

        List<Product> GetALLByCategory(int categoryId);
       



    }
}
