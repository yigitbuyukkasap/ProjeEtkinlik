using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;

namespace ProjeEtkinlik
{
    public class ApiHttpRequests
    {
        HttpClient client = new HttpClient();
        public async Task<object> HttpPostRequest (string uri, object obj)
        {
            client.BaseAddress = new Uri("http://localhost:44344/");

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            

            var response = client.PostAsync(uri, new StringContent(new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

            if (response.IsSuccessStatusCode)
            {
                
                var user = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                return user;
            }
            else
            {
                return null;
            }
        }

        public async Task<object> HttpPutRequest (string uri, object obj)
        {
            client.BaseAddress = new Uri("http://localhost:44344/");

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            

            var response = client.PutAsync(uri, new StringContent(new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

            if (response.IsSuccessStatusCode)
            {
                var user = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}