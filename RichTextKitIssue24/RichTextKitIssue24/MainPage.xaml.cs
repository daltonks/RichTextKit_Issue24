using SkiaSharp;
using SkiaSharp.Views.Forms;
using Topten.RichTextKit;
using Xamarin.Forms;

namespace RichTextKitIssue24
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var canvas = e.Surface.Canvas;

            canvas.Clear(SKColors.White);

            var richString = new RichString()
                .Add("Big text", fontSize: 40)
                .Add("Little text", fontSize: 12);
            richString.Paint(canvas, new SKPoint(0, 100));

            richString = new RichString()
                .Add("Big text", fontSize: 40, letterSpacing: 0)
                .Add("Little text", fontSize: 12, letterSpacing: 0);
            richString.Paint(canvas, new SKPoint(0, 150));
        }
    }
}
