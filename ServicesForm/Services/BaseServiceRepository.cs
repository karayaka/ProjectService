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
    public class BaseServiceRepository:IBaseServiceRepository
    {
        public HttpClient cliend;
        /// <summary>
        /// Autorazation işlemleri için yeni dependensi injection yapılmalı
        /// </summary>
        /// <param name="_baseUrl"></param>
        public BaseServiceRepository(string _baseUrl)
        {
            cliend = new HttpClient();
            cliend.BaseAddress = new Uri(_baseUrl);
            cliend.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("aplication/json"));
        }

        public T add<T>(T model,string url) where T : BaseModel
        {
            throw new NotImplementedException();
        }

        public T get<T>(int ID, string url) where T : BaseModel
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> getList<T>(string url) where T : BaseModel
        {
            try
            {
                var response = await cliend.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync();
                    //return JsonConvert.DeserializeObject<List<T>>(json); newton json nugettebn alınacak
                    throw new Exception("İstek Başarısız oldu");
                }
                else
                {
                    throw new Exception("İstek Başarısız oldu");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public T update<T>(T model, string url) where T : BaseModel
        {
            throw new NotImplementedException();
        }
    }
}
