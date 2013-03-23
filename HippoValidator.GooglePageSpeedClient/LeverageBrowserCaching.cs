using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class LeverageBrowserCaching : RuleWithUrlsBase
    {
        private UrlBlock[] _urlBlocks;

        public LeverageBrowserCaching(JObject obj)
            : base(obj)
        {
        }
    }
}