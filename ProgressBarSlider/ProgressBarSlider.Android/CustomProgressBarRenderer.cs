using Android.Content;
using ProgressBarSlider;
using ProgressBarSlider.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomProgressBar), typeof(CustomProgressBarRenderer))]
namespace ProgressBarSlider.Droid
{
    public class CustomProgressBarRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var progressBar = Control as Android.Widget.ProgressBar;
                var draw = Resources.GetDrawable(Resource.Drawable.bar_color);
                progressBar.ProgressDrawable = draw;
            }



        }

        public CustomProgressBarRenderer(Context context) : base(context)
        {

        }
            
    }
}