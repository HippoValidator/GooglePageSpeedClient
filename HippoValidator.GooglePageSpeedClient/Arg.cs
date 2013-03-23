using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class Arg
    {
        private readonly JObject _jobject;

        public string Type
        {
            get { return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(_jobject, "type")); }
        }

        public string Value
        {
            get { return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(_jobject, "value")); }
        }

        public Arg(JObject obj)
        {
            _jobject = obj;
        }
    }
}