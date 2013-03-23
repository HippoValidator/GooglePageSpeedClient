using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class Result
    {
        private readonly JObject _jobject;
        private Arg[] _args;

        public string Format
        {
            get { return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(_jobject, "format")); }
        }

        public Arg[] Args
        {
            get
            {
                return _args ??
                       (_args =
                        (Arg[])
                        JsonClassHelper.ReadArray(JsonClassHelper.GetJToken<JArray>(_jobject, "args"),
                                                  JsonClassHelper.ReadStronglyTypedObject<Arg>, typeof (Arg[])));
            }
        }

        public Result(JObject obj)
        {
            _jobject = obj;
        }
    }
}