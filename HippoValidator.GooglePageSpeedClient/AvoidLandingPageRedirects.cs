using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class AvoidLandingPageRedirects : RuleBase
    {
        public AvoidLandingPageRedirects(JObject obj)
            : base(obj)
        {
        }
    }
}