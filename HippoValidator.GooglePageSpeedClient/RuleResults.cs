using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
    public class RuleResults
    {
        private AvoidBadRequests _avoidBadRequests;
        private AvoidCssImport _avoidCssImport;
        private AvoidExcessSerialization _avoidExcessSerialization;
        private AvoidLandingPageRedirects _avoidLandingPageRedirects;
        private AvoidLongRunningScripts _avoidLongRunningScripts;
        private DeferParsingJavaScript _deferParsingJavaScript;
        private EliminateUnnecessaryReflows _eliminateUnnecessaryReflows;
        private EnableGzipCompression _enableGzipCompression;
        private InlineSmallCss _inlineSmallCss;
        private InlineSmallJavaScript _inlineSmallJavaScript;
        private LeverageBrowserCaching _leverageBrowserCaching;
        private MinifyCss _minifyCss;
        private MinifyHtml _minifyHtml;
        private MinifyJavaScript _minifyJavaScript;
        private MinimizeRedirects _minimizeRedirects;
        private MinimizeRequestSize _minimizeRequestSize;
        private OptimizeImages _optimizeImages;
        private OptimizeTheOrderOfStylesAndScripts _optimizeTheOrderOfStylesAndScripts;
        private PreferAsyncResources _preferAsyncResources;
        private PutCssInTheDocumentHead _putCssInTheDocumentHead;
        private RemoveQueryStringsFromStaticResources _removeQueryStringsFromStaticResources;
        private ServeResourcesFromAConsistentUrl _serveResourcesFromAConsistentUrl;
        private ServeScaledImages _serveScaledImages;
        private ServerResponseTime _serverResponseTime;
        private SpecifyACacheValidator _specifyACacheValidator;
        private SpecifyAVaryAcceptEncodingHeader _specifyAVaryAcceptEncodingHeader;
        private SpecifyCharsetEarly _specifyCharsetEarly;
        private SpecifyImageDimensions _specifyImageDimensions;
        private SpriteImages _spriteImages;
        private readonly JObject _jobject;

        public AvoidBadRequests AvoidBadRequests
        {
            get
            {
                return _avoidBadRequests ??
                       (_avoidBadRequests =
                        JsonClassHelper.ReadStronglyTypedObject<AvoidBadRequests>(JsonClassHelper.GetJToken<JObject>(
                            _jobject, "AvoidBadRequests")));
            }
        }

        public AvoidCssImport AvoidCssImport
        {
            get
            {
                return _avoidCssImport ??
                       (_avoidCssImport =
                        JsonClassHelper.ReadStronglyTypedObject<AvoidCssImport>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "AvoidCssImport")));
            }
        }

        public AvoidExcessSerialization AvoidExcessSerialization
        {
            get
            {
                return _avoidExcessSerialization ??
                       (_avoidExcessSerialization =
                        JsonClassHelper.ReadStronglyTypedObject<AvoidExcessSerialization>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "AvoidExcessSerialization")));
            }
        }

        public AvoidLandingPageRedirects AvoidLandingPageRedirects
        {
            get
            {
                return _avoidLandingPageRedirects ??
                       (_avoidLandingPageRedirects =
                        JsonClassHelper.ReadStronglyTypedObject<AvoidLandingPageRedirects>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "AvoidLandingPageRedirects")));
            }
        }

        public AvoidLongRunningScripts AvoidLongRunningScripts
        {
            get
            {
                return _avoidLongRunningScripts ??
                       (_avoidLongRunningScripts =
                        JsonClassHelper.ReadStronglyTypedObject<AvoidLongRunningScripts>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "AvoidLongRunningScripts")));
            }
        }

        public DeferParsingJavaScript DeferParsingJavaScript
        {
            get
            {
                return _deferParsingJavaScript ??
                       (_deferParsingJavaScript =
                        JsonClassHelper.ReadStronglyTypedObject<DeferParsingJavaScript>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "DeferParsingJavaScript")));
            }
        }

        public EliminateUnnecessaryReflows EliminateUnnecessaryReflows
        {
            get
            {
                return _eliminateUnnecessaryReflows ??
                       (_eliminateUnnecessaryReflows =
                        JsonClassHelper.ReadStronglyTypedObject<EliminateUnnecessaryReflows>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "EliminateUnnecessaryReflows")));
            }
        }

        public EnableGzipCompression EnableGzipCompression
        {
            get
            {
                return _enableGzipCompression ??
                       (_enableGzipCompression =
                        JsonClassHelper.ReadStronglyTypedObject<EnableGzipCompression>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "EnableGzipCompression")));
            }
        }

        public InlineSmallCss InlineSmallCss
        {
            get
            {
                return _inlineSmallCss ??
                       (_inlineSmallCss =
                        JsonClassHelper.ReadStronglyTypedObject<InlineSmallCss>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "InlineSmallCss")));
            }
        }

        public InlineSmallJavaScript InlineSmallJavaScript
        {
            get
            {
                return _inlineSmallJavaScript ??
                       (_inlineSmallJavaScript =
                        JsonClassHelper.ReadStronglyTypedObject<InlineSmallJavaScript>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "InlineSmallJavaScript")));
            }
        }

        public LeverageBrowserCaching LeverageBrowserCaching
        {
            get
            {
                return _leverageBrowserCaching ??
                       (_leverageBrowserCaching =
                        JsonClassHelper.ReadStronglyTypedObject<LeverageBrowserCaching>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "LeverageBrowserCaching")));
            }
        }

        public MinifyCss MinifyCss
        {
            get
            {
                return _minifyCss ??
                       (_minifyCss =
                        JsonClassHelper.ReadStronglyTypedObject<MinifyCss>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "MinifyCss")));
            }
        }

        public MinifyHtml MinifyHtml
        {
            get
            {
                return _minifyHtml ??
                       (_minifyHtml =
                        JsonClassHelper.ReadStronglyTypedObject<MinifyHtml>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "MinifyHTML")));
            }
        }

        public MinifyJavaScript MinifyJavaScript
        {
            get
            {
                return _minifyJavaScript ??
                       (_minifyJavaScript =
                        JsonClassHelper.ReadStronglyTypedObject<MinifyJavaScript>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "MinifyJavaScript")));
            }
        }

        public MinimizeRedirects MinimizeRedirects
        {
            get
            {
                return _minimizeRedirects ??
                       (_minimizeRedirects =
                        JsonClassHelper.ReadStronglyTypedObject<MinimizeRedirects>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "MinimizeRedirects")));
            }
        }

        public MinimizeRequestSize MinimizeRequestSize
        {
            get
            {
                return _minimizeRequestSize ??
                       (_minimizeRequestSize =
                        JsonClassHelper.ReadStronglyTypedObject<MinimizeRequestSize>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "MinimizeRequestSize")));
            }
        }

        public OptimizeImages OptimizeImages
        {
            get
            {
                return _optimizeImages ??
                       (_optimizeImages =
                        JsonClassHelper.ReadStronglyTypedObject<OptimizeImages>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "OptimizeImages")));
            }
        }

        public OptimizeTheOrderOfStylesAndScripts OptimizeTheOrderOfStylesAndScripts
        {
            get
            {
                return _optimizeTheOrderOfStylesAndScripts ??
                       (_optimizeTheOrderOfStylesAndScripts =
                        JsonClassHelper.ReadStronglyTypedObject<OptimizeTheOrderOfStylesAndScripts>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "OptimizeTheOrderOfStylesAndScripts")));
            }
        }

        public PreferAsyncResources PreferAsyncResources
        {
            get
            {
                return _preferAsyncResources ??
                       (_preferAsyncResources =
                        JsonClassHelper.ReadStronglyTypedObject<PreferAsyncResources>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "PreferAsyncResources")));
            }
        }

        public PutCssInTheDocumentHead PutCssInTheDocumentHead
        {
            get
            {
                return _putCssInTheDocumentHead ??
                       (_putCssInTheDocumentHead =
                        JsonClassHelper.ReadStronglyTypedObject<PutCssInTheDocumentHead>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "PutCssInTheDocumentHead")));
            }
        }

        public RemoveQueryStringsFromStaticResources RemoveQueryStringsFromStaticResources
        {
            get
            {
                return _removeQueryStringsFromStaticResources ??
                       (_removeQueryStringsFromStaticResources =
                        JsonClassHelper.ReadStronglyTypedObject<RemoveQueryStringsFromStaticResources>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "RemoveQueryStringsFromStaticResources")));
            }
        }

        public ServeResourcesFromAConsistentUrl ServeResourcesFromAConsistentUrl
        {
            get
            {
                return _serveResourcesFromAConsistentUrl ??
                       (_serveResourcesFromAConsistentUrl =
                        JsonClassHelper.ReadStronglyTypedObject<ServeResourcesFromAConsistentUrl>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "ServeResourcesFromAConsistentUrl")));
            }
        }

        public ServeScaledImages ServeScaledImages
        {
            get
            {
                return _serveScaledImages ??
                       (_serveScaledImages =
                        JsonClassHelper.ReadStronglyTypedObject<ServeScaledImages>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "ServeScaledImages")));
            }
        }

        public ServerResponseTime ServerResponseTime
        {
            get
            {
                return _serverResponseTime ??
                       (_serverResponseTime =
                        JsonClassHelper.ReadStronglyTypedObject<ServerResponseTime>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "ServerResponseTime")));
            }
        }

        public SpecifyACacheValidator SpecifyACacheValidator
        {
            get
            {
                return _specifyACacheValidator ??
                       (_specifyACacheValidator =
                        JsonClassHelper.ReadStronglyTypedObject<SpecifyACacheValidator>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "SpecifyACacheValidator")));
            }
        }

        public SpecifyAVaryAcceptEncodingHeader SpecifyAVaryAcceptEncodingHeader
        {
            get
            {
                return _specifyAVaryAcceptEncodingHeader ??
                       (_specifyAVaryAcceptEncodingHeader =
                        JsonClassHelper.ReadStronglyTypedObject<SpecifyAVaryAcceptEncodingHeader>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "SpecifyAVaryAcceptEncodingHeader")));
            }
        }

        public SpecifyCharsetEarly SpecifyCharsetEarly
        {
            get
            {
                return _specifyCharsetEarly ??
                       (_specifyCharsetEarly =
                        JsonClassHelper.ReadStronglyTypedObject<SpecifyCharsetEarly>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "SpecifyCharsetEarly")));
            }
        }

        public SpecifyImageDimensions SpecifyImageDimensions
        {
            get
            {
                return _specifyImageDimensions ??
                       (_specifyImageDimensions =
                        JsonClassHelper.ReadStronglyTypedObject<SpecifyImageDimensions>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "SpecifyImageDimensions")));
            }
        }

        public SpriteImages SpriteImages
        {
            get
            {
                return _spriteImages ??
                       (_spriteImages =
                        JsonClassHelper.ReadStronglyTypedObject<SpriteImages>(
                            JsonClassHelper.GetJToken<JObject>(_jobject, "SpriteImages")));
            }
        }

        public RuleResults(JObject obj)
        {
            _jobject = obj;
        }
    }
}