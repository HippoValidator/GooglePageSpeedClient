using GoCommando;
using GoCommando.Api;
using GoCommando.Attributes;
using System;

namespace HippoValidator.GooglePageSpeedClient.Console
{
    public class Program : ICommando
    {
        [Description("The URL to validate.")]
        [PositionalArgument]
        public string Url { get; set; }

        [PositionalArgument]
        [Description("Your Google Page Speed API key.")]
        public string ApiKey { get; set; }

        private static void Main(string[] args)
        {
            Go.Run<Program>(args);
        }

        public void Run()
        {
            var validationResult = new GooglePageSpeedValidator(ApiKey).Validate(new Uri(Url));
            System.Console.WriteLine("Google Page Speed result of '{0}'", Url);
            System.Console.WriteLine("------------------------------{0}", new string('-', Url.Length));
            System.Console.WriteLine(" Score: " + validationResult.Score);
            if (validationResult.FormattedResults == null || validationResult.FormattedResults.RuleResults == null)
                return;
            System.Console.WriteLine(" Rules:");
            var ruleResults = validationResult.FormattedResults.RuleResults;
            ruleResults.AvoidBadRequests.WriteIfSet();
            ruleResults.AvoidCssImport.WriteIfSet();
            ruleResults.AvoidExcessSerialization.WriteIfSet();
            ruleResults.AvoidLandingPageRedirects.WriteIfSet();
            ruleResults.AvoidLongRunningScripts.WriteIfSet();
            ruleResults.DeferParsingJavaScript.WriteIfSet();
            ruleResults.EliminateUnnecessaryReflows.WriteIfSet();
            ruleResults.EnableGzipCompression.WriteIfSet();
            ruleResults.InlineSmallCss.WriteIfSet();
            ruleResults.InlineSmallJavaScript.WriteIfSet();
            ruleResults.LeverageBrowserCaching.WriteIfSet();
            ruleResults.MinifyCss.WriteIfSet();
            ruleResults.MinifyHtml.WriteIfSet();
            ruleResults.MinifyJavaScript.WriteIfSet();
            ruleResults.MinimizeRedirects.WriteIfSet();
            ruleResults.MinimizeRequestSize.WriteIfSet();
            ruleResults.OptimizeImages.WriteIfSet();
            ruleResults.OptimizeTheOrderOfStylesAndScripts.WriteIfSet();
            ruleResults.PreferAsyncResources.WriteIfSet();
            ruleResults.PutCssInTheDocumentHead.WriteIfSet();
            ruleResults.RemoveQueryStringsFromStaticResources.WriteIfSet();
            ruleResults.ServeResourcesFromAConsistentUrl.WriteIfSet();
            ruleResults.ServeScaledImages.WriteIfSet();
            ruleResults.ServerResponseTime.WriteIfSet();
            ruleResults.SpecifyACacheValidator.WriteIfSet();
            ruleResults.SpecifyAVaryAcceptEncodingHeader.WriteIfSet();
            ruleResults.SpecifyCharsetEarly.WriteIfSet();
            ruleResults.SpecifyImageDimensions.WriteIfSet();
            ruleResults.SpriteImages.WriteIfSet();
        }
    }
}