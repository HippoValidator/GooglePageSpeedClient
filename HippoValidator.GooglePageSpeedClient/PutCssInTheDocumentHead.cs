using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class PutCssInTheDocumentHead : RuleWithUrlsBase
    {
        public PutCssInTheDocumentHead(JObject obj)
            : base(obj)
        {
        }
    }
}