using System.Threading.Tasks;

namespace txtr.core
{
    public interface IYoMamaClient
    {
         Task<string> GetJoke();
    }
}
