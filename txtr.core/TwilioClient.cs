using Twilio;

namespace txtr.core
{
    public class TwilioClient : ITwilioClient
    {
        readonly TwilioRestClient client;

        public TwilioClient(string accountSid, string authToken)
        {
            this.client = new TwilioRestClient(accountSid, authToken);
        }

        public Message Send(string target, string contents)
        {
            return client.SendMessage("17166382031", target, contents);
        }
    }

    public class TextResult
    {
        public string ErrorMessage { get; set; }
        public string Contents { get; set; }
    }
}
