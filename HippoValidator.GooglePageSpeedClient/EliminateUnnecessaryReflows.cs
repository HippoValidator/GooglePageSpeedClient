using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class EliminateUnnecessaryReflows : RuleWithUrlsBase
    {
        public EliminateUnnecessaryReflows(JObject obj)
            : base(obj)
        {
        }
    }
}