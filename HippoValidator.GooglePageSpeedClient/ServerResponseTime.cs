using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class ServerResponseTime : RuleBase
    {
        public ServerResponseTime(JObject obj)
            : base(obj)
        {
        }
    }
}