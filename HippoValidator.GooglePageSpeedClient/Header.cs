using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class Header
    {
        private readonly JObject _jobject;
        private Arg[] _args;

        public string Format
        {
            get { return JsonClassHelper.ReadString((JToken) JsonClassHelper.GetJToken<JValue>(this._jobject, "format")); }
        }

        public Arg[] Args
        {
            get
            {
                return this._args ??
                       (this._args =
                        (Arg[])
                        JsonClassHelper.ReadArray<Arg>(JsonClassHelper.GetJToken<JArray>(this._jobject, "args"),
                                                       new JsonClassHelper.ValueReader<Arg>(
                                                           JsonClassHelper.ReadStronglyTypedObject<Arg>), typeof (Arg[])));
            }
        }

        public Header(JObject obj)
        {
            this._jobject = obj;
        }
    }
}