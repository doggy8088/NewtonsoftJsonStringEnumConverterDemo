using System.Net.Http;
using QuickType;
using System.Threading.Tasks;

namespace c1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            var result = await client.GetFromJsonAsync<Holiday>("https://data.taipei/api/v1/dataset/29d9771d-c0ee-40d4-8dfb-3866b0b7adaa?scope=resourceAquire&offset=958&limit=1000");

            foreach (var item in result.Result.Results)
            {
                System.Console.WriteLine(item.Date + " 假日: " + item.IsHoliday );
            }
        }
    }
}
