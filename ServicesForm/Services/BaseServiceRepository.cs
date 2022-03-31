using Newtonsoft.Json;
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

        public async Task<T> add<T>(T model,string url) where T : BaseModel
        {
            try
            {
                var str = JsonConvert.SerializeObject(model);
                var byteContent  = new StringContent(str, Encoding.UTF8, "application/json");
                var response= await cliend.PostAsync(url,byteContent);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(json);// newton json nugettebn alınacak
                }
                throw new Exception("İstek Başarısız");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task Delete(string url)
        {
            try
            {
                var response= await cliend.DeleteAsync(url);                
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<T> get<T>(int ID, string url) where T : BaseModel
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
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<T>>(json);// newton json nugettebn alınacak
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

        public async Task<T> update<T>(T model, string url) where T : BaseModel
        {
            var str = JsonConvert.SerializeObject(model);
            var byteContent = new StringContent(str, Encoding.UTF8, "application/json");
            var response = await cliend.PutAsync(url, byteContent);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(json);// newton json nugettebn alınacak
            }
            throw new Exception("İstek Başarısız");
        }
    }
}
