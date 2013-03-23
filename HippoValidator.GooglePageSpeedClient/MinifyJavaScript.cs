using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class MinifyJavaScript : RuleWithUrlsBase
    {
        public MinifyJavaScript(JObject obj)
            : base(obj)
        {
        }
    }
}