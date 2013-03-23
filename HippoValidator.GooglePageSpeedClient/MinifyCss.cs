using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class MinifyCss : RuleWithUrlsBase
    {
        public MinifyCss(JObject obj)
            : base(obj)
        {
        }
    }
}