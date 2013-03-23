using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class AvoidCharsetInMetaTag : RuleBase
    {
        public AvoidCharsetInMetaTag(JObject obj)
            : base(obj)
        {
        }
    }
}