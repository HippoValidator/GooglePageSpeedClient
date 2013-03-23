using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class SpecifyACacheValidator : RuleWithUrlsBase
    {
        public SpecifyACacheValidator(JObject obj)
            : base(obj)
        {
        }
    }
}