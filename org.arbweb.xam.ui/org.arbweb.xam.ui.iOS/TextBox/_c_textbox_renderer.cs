using Xamarin.Forms;
using org.arbweb.xam.ui.iOS;
using Xamarin.Forms.Platform.iOS;
using org.arbweb.xam.ui;
using UIKit;

[assembly: ExportRenderer(typeof(_c_textbox), typeof(_c_textbox_renderer))]
namespace org.arbweb.xam.ui.iOS
{
    class _c_textbox_renderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.BackgroundColor = UIColor.FromRGBA(0,0,0,255);
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}