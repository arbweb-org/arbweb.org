using System;
using Java.Interop;
using Android.Webkit;
using org.arbweb.xam.ui;

namespace org.arbweb.xam.ui.Droid
{
    public class JSBridge : Java.Lang.Object
    {
        readonly WeakReference<_c_hwebview_renderer> hybridWebViewRenderer;

        public JSBridge(_c_hwebview_renderer hybridRenderer)
        {
            hybridWebViewRenderer = new WeakReference<_c_hwebview_renderer>(hybridRenderer);
        }

        [JavascriptInterface]
        [Export("invokeAction")]
        public void InvokeAction(string data)
        {
            _c_hwebview_renderer hybridRenderer;

            if (hybridWebViewRenderer != null && hybridWebViewRenderer.TryGetTarget(out hybridRenderer))
            {
                ((_c_hybridwebview)hybridRenderer.Element).InvokeAction(data);
            }
        }
    }
}