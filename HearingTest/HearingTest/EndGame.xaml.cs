using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HearingTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EndGame : ContentPage
    {
        public EndGame()
        {
            InitializeComponent();
            switch (MainPage.level)
            {
                case 1:
                    Score.Text = "Your Score is " + EasyGame.points.ToString() + "/10";
                    EasyGame.points = 0;
                    OnceAgain.BackgroundColor = Color.LightGreen;
                    break;
                case 2:
                    Score.Text = "Your Score is " + MediumGame.points.ToString() + "/10";
                    MediumGame.points = 0;
                    OnceAgain.BackgroundColor = Color.DeepSkyBlue;
                    break;
                case 3:
                    Score.Text = "Your Score is " + HardGame.points.ToString() + "/10";
                    HardGame.points = 0;
                    OnceAgain.BackgroundColor = Color.DimGray;
                    break;
                case 4:
                    Score.Text = "Your Score is " + ExpertGame.points.ToString() + "/10";
                    ExpertGame.points = 0;
                    OnceAgain.BackgroundColor = Color.IndianRed;
                    break;
                case 5:
                    Score.Text = "Your Score is " + Intervals.points.ToString() + "/10";
                    Intervals.points = 0;
                    OnceAgain.BackgroundColor = Color.DarkBlue;
                    break;
            }
            if (EasyGame.points > 0)
            {

            }
        }

        private async void Menu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void OnceAgain_Clicked(object sender, EventArgs e)
        {
            switch (MainPage.level)
            {
                case 1:
                    await Navigation.PushAsync(new EasyGame());
                    break;
                case 2:
                    await Navigation.PushAsync(new MediumGame());
                    break;
                case 3:
                    await Navigation.PushAsync(new HardGame());
                    break;
                case 4:
                    await Navigation.PushAsync(new ExpertGame());
                    break;
                case 5:
                    await Navigation.PushAsync(new Intervals());
                    break;
            }
        }
    }
}