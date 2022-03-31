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
        Task<T> add<T>(T model, string url) where T : BaseModel;

        Task<T> update<T>(T model, string url) where T : BaseModel;

        Task<List<T>> getList<T>(string url) where T : BaseModel;

        Task<T> get<T>(int ID, string url) where T : BaseModel;

        Task Delete(string url);
    }
}
