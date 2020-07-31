using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using MTPL;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Xaml;
[assembly: ExportRenderer(typeof(NativeView), typeof(NativeViewRenderer))]
namespace MTPL
{
    public class NativeViewRenderer : ViewRenderer<NativeView, Android.Widget.TextView>
    {
        public NativeViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<NativeView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                // Subscribe for events

                e.NewElement.SizeChanged += XFButtonOnSizeChanged;

                if (Context is FormsAppCompatActivity faca)
                {
                    //var view = faca.LayoutInflater.Inflate(Resource.Layout.col colleagues_colleague_item, this, true);
                }

                if (Control == null)
                {
                    // создаем и настраиваем элемент
                    Android.Widget.TextView textView = new Android.Widget.TextView(Context);
                    textView.SetTextColor(Android.Graphics.Color.DarkGreen);
                    textView.Text = "Android";
                    textView.SetTextSize(ComplexUnitType.Dip, 28);

                    // устанавливаем элемент для класса из Portable-проекта
                    SetNativeControl(textView);
                }
            }
            else if (e.OldElement != null)
            {
                // Unsubscribe from events

                e.OldElement.SizeChanged -= XFButtonOnSizeChanged;
            }

            //if (Control != null)
            //{
            //    GradientDrawable gradientDrawable = new GradientDrawable();
            //    gradientDrawable.SetShape(ShapeType.Rectangle);
            //    gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid());
            //    gradientDrawable.SetStroke(4, Element.BorderColor.ToAndroid());
            //    gradientDrawable.SetCornerRadius(38.0f);

            //    Control.SetBackground(gradientDrawable);
            //}
        }

        //protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    if (e.PropertyName == "BackgroundColor")
        //    {
        //        if (Control != null)
        //        {
        //            GradientDrawable gradientDrawable = new GradientDrawable();
        //            gradientDrawable.SetShape(ShapeType.Rectangle);
        //            gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid());
        //            gradientDrawable.SetStroke(4, Element.BorderColor.ToAndroid());
        //            gradientDrawable.SetCornerRadius(38.0f);

        //            Control.SetBackground(gradientDrawable);
        //            return;
        //        }

        //    }

        //    base.OnElementPropertyChanged(sender, e);
        //}

        private void XFButtonOnSizeChanged(object sender, EventArgs e)
        {
            //GradientDrawable gradientDrawable = new GradientDrawable();
            //gradientDrawable.SetShape(ShapeType.Rectangle);
            //gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid());
            //gradientDrawable.SetStroke(8, Element.BorderColor.ToAndroid());
            //gradientDrawable.SetCornerRadius(38.0f);

            //Control.SetBackground(gradientDrawable);
        }
    }
}
