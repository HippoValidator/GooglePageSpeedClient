using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class MinimizeRedirects : RuleBase
    {
        public MinimizeRedirects(JObject obj)
            : base(obj)
        {
        }
    }
}