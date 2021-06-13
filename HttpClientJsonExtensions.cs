using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace c1
{
    public static class HttpClientJsonExtensions
    {
        public static async System.Threading.Tasks.Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, string requestUrl, T theObj)
        {
            return await client.PostAsync(requestUrl, new StringContent(JsonConvert.SerializeObject(theObj), Encoding.UTF8, "application/json"));
        }

        public static async System.Threading.Tasks.Task<T> GetFromJsonAsync<T>(this HttpClient client, string requestUrl)
        {
            return JsonConvert.DeserializeObject<T>(await client.GetStringAsync(requestUrl));
        }
    }
 }