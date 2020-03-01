using Android.Content;
using Android.Webkit;
using Android.App;

namespace org.arbweb.xam.ui.Droid
{
    // A class used to grant permissions for native api calls
    class CustomWebChromeClient : WebChromeClient
    {
        Activity s_act_;

        public CustomWebChromeClient(Context p_act_)
        { 
            s_act_ = (Activity)p_act_; 
        }

        public override void OnPermissionRequest(PermissionRequest p_per_)
        {
            s_act_.RunOnUiThread(() =>
            {
                p_per_.Grant(p_per_.GetResources());
            });
        }
    }
}