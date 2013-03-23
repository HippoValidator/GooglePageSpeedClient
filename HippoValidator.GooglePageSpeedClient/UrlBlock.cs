using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class UrlBlock
    {
        private readonly JObject _jobject;
        private Header _header;
        private Url[] _urls;

        public Header Header
        {
            get
            {
                return _header ??
                       (_header =
                        JsonClassHelper.ReadStronglyTypedObject<Header>(JsonClassHelper.GetJToken<JObject>(_jobject,
                                                                                                           "header")));
            }
        }

        public Url[] Urls
        {
            get
            {
                return _urls ??
                       (_urls =
                        (Url[])
                        JsonClassHelper.ReadArray(JsonClassHelper.GetJToken<JArray>(_jobject, "urls"),
                                                  JsonClassHelper.ReadStronglyTypedObject<Url>, typeof (Url[])));
            }
        }

        public UrlBlock(JObject obj)
        {
            _jobject = obj;
        }
    }
}