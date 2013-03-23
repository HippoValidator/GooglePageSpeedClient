using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class ServeScaledImages : RuleWithUrlsBase
    {
        public ServeScaledImages(JObject obj)
            : base(obj)
        {
        }
    }
}