using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using txtr.core;

namespace txtr.api.Controllers
{
    [RoutePrefix("api/Text")]
    public class TextController : ApiController
    {
        readonly IYoMamaClient client;
        readonly ITwilioClient twilio;

        public TextController(IYoMamaClient client, ITwilioClient twilio)
        {
            this.client = client;
            this.twilio = twilio;
        }

        [EnableCors(origins: "http://localhost:1000,http://txtr.azurewebsites.net", headers: "*", methods: "*")]
        [HttpGet]
        public IHttpActionResult Ping()
        {
            return Ok("alive");
        }

        [EnableCors(origins: "http://localhost:1000,http://txtr.azurewebsites.net", headers: "*", methods: "*")]
        [Route("Send")]
        public async Task<IHttpActionResult> Post([FromBody] string target)
        {
            var joke = await client.GetJoke();

            var message = twilio.Send(target, joke);

            if (message.RestException != null)
            {
                return BadRequest(message.RestException.Message);
            }

            return Ok(message.Body);
        }
    }
}
