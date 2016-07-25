using Twilio;

namespace txtr.core
{
    public interface ITwilioClient
    {
        Message Send(string target, string contents);
    }
}
