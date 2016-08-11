using AcikAkademi5.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AcikAkademi5.Provider
{
    public class ServiceManager
    {
        private string Url = "http://192.168.0.17/ServiceHub/api/aakademi/";
        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<StudentModel>> GetAll()
        {
            HttpClient client = await GetClient();
            var result = await client.GetStringAsync(Url + "getall");
            var mobileResult = JsonConvert.DeserializeObject<MobileResult>(result);
            return JsonConvert.DeserializeObject<IEnumerable<StudentModel>>
                (mobileResult.Data.ToString());
        }

        private async Task<MobileResult> Process(StudentModel model, 
            string processType)
        {
            HttpClient client = await GetClient();
            // Insert işlemini gerçekleştirdik.
            var response = await client.PostAsync(Url + processType,
                new StringContent(JsonConvert.SerializeObject(model),
                Encoding.UTF8, "application/json"));
            var mobileResult = await response.Content.ReadAsStringAsync();
            // Insert işleminin cevabını alıyoruz...
            var result = JsonConvert.DeserializeObject<MobileResult>(mobileResult);
            return result;
        }

        public async Task<MobileResult> Insert(StudentModel model)
        {
            return await Process(model, "insert");
        }

        public async Task<MobileResult> Delete(StudentModel model)
        {
            return await Process(model, "delete");
        }

        public async Task<MobileResult> Update(StudentModel model)
        {
            return await Process(model, "update");
        }
    }
}