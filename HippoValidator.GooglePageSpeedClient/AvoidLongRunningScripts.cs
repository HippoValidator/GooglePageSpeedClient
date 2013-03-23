using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class AvoidLongRunningScripts : RuleBase
    {
        public AvoidLongRunningScripts(JObject obj)
            : base(obj)
        {
        }
    }
}