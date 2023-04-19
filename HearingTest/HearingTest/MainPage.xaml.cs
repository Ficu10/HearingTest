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
        public MainPage()
        {
            InitializeComponent();
            if (Game.points > 0)
            {
                Score.Text = "Your Score is " + Game.points.ToString() + "/10";

            }
        }

        private async void StartButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Game());
            Game.points = 0;
            Score.IsVisible = true;
        }

        private async void EasyButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EasyGame());

        }

        private async void MediumButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MediumGame());

        }

        private async void HardButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HardGame());

        }

        private async void ExpertButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExpertGame());

        }
    }
}
