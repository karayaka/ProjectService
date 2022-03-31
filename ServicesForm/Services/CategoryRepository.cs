using ServicesForm.Infrastructure;
using ServicesForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServicesForm.Services
{
    public class CategoryRepository : BaseServiceRepository, ICategoryRepository
    {
        string url = "";
        public CategoryRepository():base("https://localhost:44376/")
        {

        }

        public async Task<CategoryModel> AddCategory(CategoryModel model)
        {
            try
            {
                return await add(model, "categories");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteCategory(int ID)
        {
            try
            {
                await Delete($"categories/{ID}");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<CategoryModel> GetCategory(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryModel>> GetCategoryes()
        {
            try
            {
                return await getList<CategoryModel>("categories");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<CategoryModel> UpdateCategory(CategoryModel model)
        {
            try
            {
               return await update<CategoryModel>(model, $"categories/{model.ID}");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
