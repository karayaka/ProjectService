using ServicesForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesForm.Infrastructure
{
    public interface IBaseServiceRepository
    {
        T add<T>(T model, string url) where T : BaseModel;

        T update<T>(T model, string url) where T : BaseModel;

        Task<List<T>> getList<T>(string url) where T : BaseModel;

        T get<T>(int ID, string url) where T : BaseModel;
    }
}
