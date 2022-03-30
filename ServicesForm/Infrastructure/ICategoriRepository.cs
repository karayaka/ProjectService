using ServicesForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesForm.Infrastructure
{
    public interface ICategoryRepository:IBaseServiceRepository
    {
        CategoryModel AddCategory(CategoryModel model);

        CategoryModel UpdateCategory(CategoryModel model);

        int DeleteCategory(int ID);

        List<CategoryModel> GetCategoryes();

        CategoryModel GetCategory(int ID);
    }
}
