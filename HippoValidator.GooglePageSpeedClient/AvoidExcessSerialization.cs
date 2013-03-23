using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class AvoidExcessSerialization : RuleWithUrlsBase
    {
        public AvoidExcessSerialization(JObject obj)
            : base(obj)
        {
        }
    }
}