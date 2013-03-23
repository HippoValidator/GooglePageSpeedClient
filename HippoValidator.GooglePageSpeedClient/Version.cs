using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class Version
    {
        private readonly JObject _jobject;

        public int Major
        {
            get { return JsonClassHelper.ReadInteger(JsonClassHelper.GetJToken<JValue>(_jobject, "major")); }
        }

        public int Minor
        {
            get { return JsonClassHelper.ReadInteger(JsonClassHelper.GetJToken<JValue>(_jobject, "minor")); }
        }

        public Version(JObject obj)
        {
            _jobject = obj;
        }
    }
}