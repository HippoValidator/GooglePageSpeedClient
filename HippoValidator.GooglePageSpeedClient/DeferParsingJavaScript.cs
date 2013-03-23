using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class DeferParsingJavaScript : RuleWithUrlsBase
    {
        public DeferParsingJavaScript(JObject obj)
            : base(obj)
        {
        }
    }
}