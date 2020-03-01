using org.arbweb.xam.ui;
using org.arbweb.xam.ui.UWP;
using Windows.UI;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(_c_button), typeof(_c_button_renderer))]
namespace org.arbweb.xam.ui.UWP
{
    public class _c_button_renderer : ButtonRenderer
    {
        public _c_button_renderer() 
        {
        
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.PointerEntered += (p_snd_, p_arg_) => 
                {
                    Control.BackgroundColor = new SolidColorBrush(Colors.LightGray);
                };

                Control.PointerMoved += (p_snd_, p_arg_) => 
                {
                    Control.BackgroundColor = new SolidColorBrush(Colors.LightGray);
                };

                Control.PointerExited += (p_snd_, p_arg_) =>
                {
                    Control.BackgroundColor = new SolidColorBrush(Colors.LightGray);
                };

                //click
                Control.Click += (p_snd_, p_arg_) => 
                {
                    Control.BackgroundColor = new SolidColorBrush(Colors.LightGray);
                };
            }
        }
    }
}