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
            if (EasyGame.points > 0)
            {
                Score.Text = "Your Score is " + EasyGame.points.ToString() + "/10";

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
            }
        }
    }
}