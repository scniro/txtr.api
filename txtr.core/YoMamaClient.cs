using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace txtr.core
{
    public class YoMamaClient : IYoMamaClient
    {
        readonly ITxtrHttpClient client;
        readonly string uri;

        public YoMamaClient(ITxtrHttpClient baseClient, string uri)
        {
            this.client = baseClient;
            this.uri = uri;
        }

        public async Task<string> GetJoke()
        {
            var response = await client.GetResponseString(uri);
            return JObject.Parse(response).SelectToken("joke").Value<string>();
        }
    }
}
