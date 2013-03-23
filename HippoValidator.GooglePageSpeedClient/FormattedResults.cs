using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class FormattedResults
    {
        private readonly JObject _jobject;
        private RuleResults _ruleResults;

        public string Locale
        {
            get { return JsonClassHelper.ReadString((JToken) JsonClassHelper.GetJToken<JValue>(this._jobject, "locale")); }
        }

        public RuleResults RuleResults
        {
            get
            {
                return this._ruleResults ??
                       (this._ruleResults =
                        JsonClassHelper.ReadStronglyTypedObject<RuleResults>(
                            (JToken) JsonClassHelper.GetJToken<JObject>(this._jobject, "ruleResults")));
            }
        }

        public FormattedResults(JObject obj)
        {
            this._jobject = obj;
        }
    }
}