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
        public CategoryRepository():base("")
        {

        }

        public CategoryModel AddCategory(CategoryModel model)
        {
            try
            {
                throw new Exception("");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int DeleteCategory(int ID)
        {
            throw new NotImplementedException();
        }

        public CategoryModel GetCategory(int ID)
        {
            throw new NotImplementedException();
        }

        public List<CategoryModel> GetCategoryes()
        {
            throw new NotImplementedException();
        }

        public CategoryModel UpdateCategory(CategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
