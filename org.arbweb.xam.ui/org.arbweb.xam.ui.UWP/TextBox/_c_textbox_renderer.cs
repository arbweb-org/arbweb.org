using org.arbweb.xam.ui;
using org.arbweb.xam.ui.UWP;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(_c_textbox), typeof(_c_textbox_renderer))]
namespace org.arbweb.xam.ui.UWP
{
    class _c_textbox_renderer : EntryRenderer
    {
        public class MyEntryRenderer : EntryRenderer
        {
            protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
            {
                base.OnElementChanged(e);

                if (e.OldElement == null)
                {
                    Control.Background = new SolidColorBrush(Colors.Transparent);
                    Control.BackgroundFocusBrush = new SolidColorBrush(Colors.Transparent);
                }
            }
        }
    }
}