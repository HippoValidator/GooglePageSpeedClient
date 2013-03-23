using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class AvoidBadRequests : RuleBase
    {
        public AvoidBadRequests(JObject obj)
            : base(obj)
        {
        }
    }
}