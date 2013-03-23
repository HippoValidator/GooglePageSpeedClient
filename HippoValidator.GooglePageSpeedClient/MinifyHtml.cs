using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class MinifyHtml : RuleWithUrlsBase
    {
        public MinifyHtml(JObject obj)
            : base(obj)
        {
        }
    }
}