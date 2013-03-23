using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class Url
    {
        private readonly JObject _jobject;
        private Result _result;

        public Result Result
        {
            get
            {
                return _result ??
                       (_result =
                        JsonClassHelper.ReadStronglyTypedObject<Result>(JsonClassHelper.GetJToken<JObject>(_jobject,
                                                                                                           "result")));
            }
        }

        public Url(JObject obj)
        {
            _jobject = obj;
        }
    }
}