using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class ValidationResult
    {
        private readonly JObject _jobject;
        private PageStats _pageStats;
        private FormattedResults _formattedResults;
        private Version _version;

        public string Kind
        {
            get { return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(_jobject, "kind")); }
        }

        public string Id
        {
            get { return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(_jobject, "id")); }
        }

        public int ResponseCode
        {
            get { return JsonClassHelper.ReadInteger(JsonClassHelper.GetJToken<JValue>(_jobject, "responseCode")); }
        }

        public string Title
        {
            get { return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(_jobject, "title")); }
        }

        public int Score
        {
            get { return JsonClassHelper.ReadInteger(JsonClassHelper.GetJToken<JValue>(_jobject, "score")); }
        }

        public PageStats PageStats
        {
            get
            {
                return _pageStats ??
                       (_pageStats =
                        JsonClassHelper.ReadStronglyTypedObject<PageStats>(JsonClassHelper.GetJToken<JObject>(_jobject,
                                                                                                              "pageStats")));
            }
        }

        public FormattedResults FormattedResults
        {
            get
            {
                return _formattedResults ??
                       (_formattedResults =
                        JsonClassHelper.ReadStronglyTypedObject<FormattedResults>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "formattedResults")));
            }
        }

        public Version Version
        {
            get
            {
                return _version ??
                       (_version =
                        JsonClassHelper.ReadStronglyTypedObject<Version>(JsonClassHelper.GetJToken<JObject>(_jobject,
                                                                                                            "version")));
            }
        }

        public ValidationResult(string json)
            : this(JObject.Parse(json))
        {
        }

        public ValidationResult(JObject obj)
        {
            _jobject = obj;
        }
    }
}