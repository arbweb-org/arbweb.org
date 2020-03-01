using org.arbweb.xam.ui;
using org.arbweb.xam.ui.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(_c_button), typeof(_c_button_renderer))]
namespace org.arbweb.xam.ui.iOS
{
    public class _c_button_renderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
        }
    }
}