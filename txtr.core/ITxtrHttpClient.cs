using System.Threading.Tasks;

namespace txtr.core
{
    public interface ITxtrHttpClient
    {
        Task<string> GetResponseString(string uri);
    }
}
