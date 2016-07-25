using System.Net.Http;
using System.Threading.Tasks;

namespace txtr.core
{
    public class TxtrHttpClient : ITxtrHttpClient
    {
        public async Task<string> GetResponseString(string uri)
        {
            var httpClient = new HttpClient();
        
            var response = await httpClient.GetAsync(uri);
            var contents = await response.Content.ReadAsStringAsync();

            return contents;
        }
    }
}
