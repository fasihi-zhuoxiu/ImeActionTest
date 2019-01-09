using Android.Content;
using IMEActionTest.Specific;
using Xamarin.Forms.Platform.Android;
using IMEActionTest.Droid.Extensions;
using IMEActionTest.Droid.Specific;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(SpecificEditor), typeof(SpecificEditorRenderer))]
namespace IMEActionTest.Droid.Specific
{
    public class SpecificEditorRenderer : EditorRenderer
    {
        public SpecificEditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Editor> e)
        {
            base.OnElementChanged(e);
            var imeOptions = SpecificEditor.GetImeOptions(Element.OnThisPlatform().Element);
            this.Control.ImeOptions = imeOptions.ToAndroidImeOptions();
        }
    }
}