using Xamarin.Forms;
using Android.Content;
using org.arbweb.xam.ui.Droid;
using Xamarin.Forms.Platform.Android;
using org.arbweb.xam.ui;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(_c_textbox), typeof(_c_textbox_renderer))]
namespace org.arbweb.xam.ui.Droid
{
    class _c_textbox_renderer : EntryRenderer
    {
        Context _context;

        public _c_textbox_renderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();

                gradientDrawable.SetColor(Android.Graphics.Color.Transparent);
                gradientDrawable.SetStroke(0, Android.Graphics.Color.Transparent);
                gradientDrawable.SetCornerRadius(0);

                Control.SetBackground(gradientDrawable);

                Control.SetPadding(0, 0, 0, 0);
            }
        }
    }
}