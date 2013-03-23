using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class OptimizeImages : RuleWithUrlsBase
    {
        public OptimizeImages(JObject obj)
            : base(obj)
        {
        }
    }
}