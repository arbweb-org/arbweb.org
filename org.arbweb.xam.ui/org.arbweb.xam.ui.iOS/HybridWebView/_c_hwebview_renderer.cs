using WebKit;
using Foundation;
using Xamarin.Forms;
using org.arbweb.xam.ui.iOS;
using Xamarin.Forms.Platform.iOS;
using org.arbweb.xam.ui;
using System.IO;

[assembly: ExportRenderer(typeof(_c_hybridwebview), typeof(_c_hwebview_renderer))]
namespace org.arbweb.xam.ui.iOS
{
    public class _c_hwebview_renderer : WkWebViewRenderer, IWKScriptMessageHandler
    {
        const string JavaScriptFunction = "function invokeCSharpAction(data){window.webkit.messageHandlers.invokeAction.postMessage(data);}";
        WKUserContentController userController;

        public _c_hwebview_renderer() : this(new WKWebViewConfiguration())
        {
        }

        public _c_hwebview_renderer(WKWebViewConfiguration config) : base(config)
        {
            userController = config.UserContentController;
            var script = new WKUserScript(new NSString(JavaScriptFunction), WKUserScriptInjectionTime.AtDocumentEnd, false);
            userController.AddUserScript(script);
            userController.AddScriptMessageHandler(this, "invokeAction");
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                userController.RemoveAllUserScripts();
                userController.RemoveScriptMessageHandler("invokeAction");
                _c_hybridwebview hybridWebView = e.OldElement as _c_hybridwebview;
                hybridWebView.Cleanup();
            }

            if (e.NewElement != null)
            {
                string filename = Path.Combine(
                    NSBundle.MainBundle.BundlePath, 
                    $"HTML/{((_c_hybridwebview)Element).Uri}");
                LoadRequest(new NSUrlRequest(new NSUrl(filename, false)));
            }
        }

        public void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message)
        {
            ((_c_hybridwebview)Element).InvokeAction(message.Body.ToString());
        }
    }
}