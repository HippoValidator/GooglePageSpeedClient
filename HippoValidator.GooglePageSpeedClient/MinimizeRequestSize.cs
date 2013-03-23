using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class MinimizeRequestSize : RuleBase
    {
        public MinimizeRequestSize(JObject obj)
            : base(obj)
        {
        }
    }
}