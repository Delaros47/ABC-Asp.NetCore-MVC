using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> Get(int categoryId);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);

    }
}
