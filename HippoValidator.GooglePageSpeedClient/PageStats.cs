using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class PageStats
    {
        private readonly JObject _jobject;

        public int NumberResources
        {
            get
            {
                return
                    JsonClassHelper.ReadInteger(
                        JsonClassHelper.GetJToken<JValue>(_jobject, "numberResources"));
            }
        }

        public int NumberHosts
        {
            get
            {
                return
                    JsonClassHelper.ReadInteger(JsonClassHelper.GetJToken<JValue>(_jobject, "numberHosts"));
            }
        }

        public string TotalRequestBytes
        {
            get
            {
                return
                    JsonClassHelper.ReadString(
                        JsonClassHelper.GetJToken<JValue>(_jobject, "totalRequestBytes"));
            }
        }

        public int NumberStaticResources
        {
            get
            {
                return
                    JsonClassHelper.ReadInteger(
                        JsonClassHelper.GetJToken<JValue>(_jobject, "numberStaticResources"));
            }
        }

        public string HtmlResponseBytes
        {
            get
            {
                return
                    JsonClassHelper.ReadString(
                        JsonClassHelper.GetJToken<JValue>(_jobject, "htmlResponseBytes"));
            }
        }

        public string CssResponseBytes
        {
            get
            {
                return
                    JsonClassHelper.ReadString(
                        JsonClassHelper.GetJToken<JValue>(_jobject, "cssResponseBytes"));
            }
        }

        public string ImageResponseBytes
        {
            get
            {
                return
                    JsonClassHelper.ReadString(
                        JsonClassHelper.GetJToken<JValue>(_jobject, "imageResponseBytes"));
            }
        }

        public string JavascriptResponseBytes
        {
            get
            {
                return
                    JsonClassHelper.ReadString(
                        JsonClassHelper.GetJToken<JValue>(_jobject, "javascriptResponseBytes"));
            }
        }

        public int NumberJsResources
        {
            get
            {
                return
                    JsonClassHelper.ReadInteger(
                        JsonClassHelper.GetJToken<JValue>(_jobject, "numberJsResources"));
            }
        }

        public int NumberCssResources
        {
            get
            {
                return
                    JsonClassHelper.ReadInteger(
                        JsonClassHelper.GetJToken<JValue>(_jobject, "numberCssResources"));
            }
        }

        public PageStats(JObject obj)
        {
            _jobject = obj;
        }
    }
}