using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HearingTest
{
    public partial class MainPage : ContentPage
    {
        public static int level;
        public MainPage()
        {
            InitializeComponent();
        }

      
        private async void EasyButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EasyGame());
            level = 1;
        }

        private async void MediumButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MediumGame());
            level = 2;

        }

        private async void HardButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HardGame());
            level = 3;

        }

        private async void ExpertButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExpertGame());
            level = 4;

        }

        private async void IntervalsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Intervals());
            level = 5;
        }
    }
}
