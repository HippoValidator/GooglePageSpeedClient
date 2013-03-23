using System;
using System.Net;

namespace HippoValidator.GooglePageSpeedClient
{
    public class GooglePageSpeedValidator : IGooglePageSpeedValidator
    {
        private readonly string _apiKey;

        public GooglePageSpeedValidator(string apiKey)
        {
            this._apiKey = apiKey;
        }

        public ValidationResult Validate(Uri url)
        {
            return
                new ValidationResult(
                    new WebClient().DownloadString(
                        string.Format("https://www.googleapis.com/pagespeedonline/v1/runPagespeed?url={0}&key={1}",
                                      (object) url, (object) this._apiKey)));
        }
    }
}