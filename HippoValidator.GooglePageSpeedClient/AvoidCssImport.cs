using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class AvoidCssImport : RuleBase
    {
        public AvoidCssImport(JObject obj)
            : base(obj)
        {
        }
    }
}