using Xamarin.Forms;
using Android.Content;
using org.arbweb.xam.ui.Droid;
using Xamarin.Forms.Platform.Android;
using org.arbweb.xam.ui;

[assembly: ExportRenderer(typeof(_c_hybridwebview), typeof(_c_hwebview_renderer))]
namespace org.arbweb.xam.ui.Droid
{
    public class _c_hwebview_renderer : WebViewRenderer
    {
        const string JavascriptFunction = "function invokeCSharpAction(data){jsBridge.invokeAction(data);}";
        Context _context;

        public _c_hwebview_renderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                Control.RemoveJavascriptInterface("jsBridge");
                ((_c_hybridwebview)Element).Cleanup();
            }

            if (e.NewElement != null)
            {
                Control.Settings.JavaScriptEnabled = true;
                Control.Settings.AllowFileAccessFromFileURLs = true;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
                Control.Settings.DatabaseEnabled = true;
                Control.Settings.DomStorageEnabled = true;
                Control.Settings.MediaPlaybackRequiresUserGesture = false;
                Control.Settings.SafeBrowsingEnabled = false;

                //Control.ClearCache(true);

                Control.SetWebViewClient(new JavascriptWebViewClient($"javascript: {JavascriptFunction}"));
                Control.SetWebChromeClient(new CustomWebChromeClient(_context));
                Control.AddJavascriptInterface(new JSBridge(this), "jsBridge");
                Control.LoadUrl($"file:///android_asset/HTML/{((_c_hybridwebview)Element).Uri}");
            }
        }
    }
}