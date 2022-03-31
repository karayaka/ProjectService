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
        Task<CategoryModel> AddCategory(CategoryModel model);

        Task<CategoryModel> UpdateCategory(CategoryModel model);

        Task DeleteCategory(int ID);

        Task<List<CategoryModel>> GetCategoryes();

        Task<CategoryModel> GetCategory(int ID);
    }
}
