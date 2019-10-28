using System;
using Xamarin.Forms;

namespace XAMLDesignThinking.Controls
{
    public class CustomEntry : Entry
    {
        // Border Color
        //public static BindableProperty BorderColorProp = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomEntry), Color.Blue);
        //public Color BorderColor
        //{
        //    get => (Color)GetValue(BorderColorProp);
        //    set => SetValue(BorderColorProp, value);
        //}

        // Border Radius
        //public static BindableProperty CornerRadiusProp = BindableProperty.Create(nameof(CornerRadius), typeof(double), typeof(CustomEntry), "6,7,7");
        //public double CornerRadiues
        //{
        //    get => (double)GetValue(CornerRadiusProp);
        //    set => SetValue(CornerRadiusProp, value);
        //}

                    public static readonly BindableProperty BorderColorProperty =
                    BindableProperty.Create(
                    nameof(BorderColor),
                    typeof(Color),
                    typeof(CustomEntry),
                    Color.Gray);
                    // Gets or sets BorderColor value
                    public Color BorderColor
                    {
                        get { return (Color)GetValue(BorderColorProperty); }
                        set { SetValue(BorderColorProperty, value); }
                    }
                    public static readonly BindableProperty BorderWidthProperty =
                    BindableProperty.Create(
                    nameof(BorderWidth),
                    typeof(int),
                    typeof(CustomEntry),
                    Device.OnPlatform<int>(1, 2, 2));
                    // Gets or sets BorderWidth value
                    public int BorderWidth
                    {
                        get { return (int)GetValue(BorderWidthProperty); }
                        set { SetValue(BorderWidthProperty, value); }
                    }
                    public static readonly BindableProperty CornerRadiusProperty =
                    BindableProperty.Create(
                    nameof(CornerRadius),
                    typeof(double),
                    typeof(CustomEntry),
                    Device.OnPlatform<double>(6, 7, 7));
                    // Gets or sets CornerRadius value
                    public double CornerRadius
                    {
                        get { return (double)GetValue(CornerRadiusProperty); }
                        set { SetValue(CornerRadiusProperty, value); }
                    }
                    public static readonly BindableProperty IsCurvedCornersEnabledProperty =
                    BindableProperty.Create(
                    nameof(IsCurvedCornersEnabled),
                    typeof(bool),
                    typeof(CustomEntry),
                    true);
                    // Gets or sets IsCurvedCornersEnabled value
                    public bool IsCurvedCornersEnabled
                    {
                        get { return (bool)GetValue(IsCurvedCornersEnabledProperty); }
                        set { SetValue(IsCurvedCornersEnabledProperty, value); }
                    }
    }
}
