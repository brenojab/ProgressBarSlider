using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgressBarSlider.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressBarSliderPage : ContentPage
    {
        public ProgressBarSliderPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            //for (int i = 0; i < 10; i++)
            //{
            //    Task.Delay(1000);
            //    progressBar.Progress = Convert.ToDouble($"0,{i}");
            //}
        }
    }
}