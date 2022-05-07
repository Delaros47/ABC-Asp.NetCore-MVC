using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> Get(int productId);
        IDataResult<List<Product>> GetProductsByCategoryId(int categoryId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
