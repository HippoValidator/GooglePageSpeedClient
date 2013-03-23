using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public abstract class RuleWithUrlsBase : RuleBase
    {
        private UrlBlock[] _urlBlocks;

        public UrlBlock[] UrlBlocks
        {
            get
            {
                return _urlBlocks ??
                       (_urlBlocks =
                        (UrlBlock[])
                        JsonClassHelper.ReadArray(JsonClassHelper.GetJToken<JArray>(Jobject, "urlBlocks"),
                                                  JsonClassHelper.ReadStronglyTypedObject<UrlBlock>, typeof (UrlBlock[])));
            }
        }

        protected RuleWithUrlsBase(JObject obj)
            : base(obj)
        {
        }
    }
}