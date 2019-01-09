using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace IMEActionTest.Specific
{
    public class SpecificEditor : Editor
    {
        /// <summary>
        /// <see cref="BindableObject"/> of the ImeOptions
        /// </summary>
        public static readonly BindableProperty ImeOptionsProperty = BindableProperty.Create(
            "ImeOptions",
            typeof(ImeFlags),
            typeof(SpecificEditor),
            default(ImeFlags));

        /// <summary>
        /// Gets or sets of the ImeOptions
        /// </summary>
        public static ImeFlags GetImeOptions(BindableObject view)
        {
            return (ImeFlags)view.GetValue(ImeOptionsProperty);
        }

        public static void SetImeOptions(BindableObject view, ImeFlags flags)
        {
            view.SetValue(ImeOptionsProperty, flags);
        }

    }
}
