using Android.Content;
using org.arbweb.xam.ui;
using org.arbweb.xam.ui.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(_c_button), typeof(_c_button_renderer))]
namespace org.arbweb.xam.ui.Droid
{
    public class _c_button_renderer : ButtonRenderer
    {
        Context _context;

        public _c_button_renderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null) 
            {
                Control.SetAllCaps(false);
            }
        }
    }
}