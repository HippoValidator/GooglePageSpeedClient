using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class RemoveQueryStringsFromStaticResources : RuleWithUrlsBase
    {
        public RemoveQueryStringsFromStaticResources(JObject obj)
            : base(obj)
        {
        }
    }
}