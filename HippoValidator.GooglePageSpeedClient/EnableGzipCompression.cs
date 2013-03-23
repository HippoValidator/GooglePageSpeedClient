using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class EnableGzipCompression : RuleWithUrlsBase
    {
        public EnableGzipCompression(JObject obj)
            : base(obj)
        {
        }
    }
}