using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProgressBarSlider
{
    public partial class ProgressView : ContentView
    {
        public double Progress
        {
            set { SetValue(ProgressProperty, value); }
            get { return (double)GetValue(ProgressProperty); }
        }

        public readonly static BindableProperty ProgressProperty = BindableProperty.Create("Progress", typeof(double), typeof(ProgressView), 0.0);

    }
}
