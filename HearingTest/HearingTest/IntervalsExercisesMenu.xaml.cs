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
	public partial class IntervalsExercisesMenu : ContentPage
	{
        public static List<int> listOfIntervals = new List<int>();
		public IntervalsExercisesMenu ()
		{
			InitializeComponent ();
		}

        private async void Start_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Count() == 0)
            {
                DisplayAlert("Błąd", "Wybierz interwał", "Ok");
            }
            else
            {
                await Navigation.PushAsync(new IntervalsExercises());
            }
        }

        private void Pryma_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(0))
            {
                listOfIntervals.Remove(0);
                Pryma.TextColor = Color.Gray;
                Pryma.BackgroundColor = Color.LightGray;
            }
            else
            {
                listOfIntervals.Add(0);
                Pryma.TextColor = Color.Black;
                Pryma.BackgroundColor = Color.FromHex("#b51414");
            }
           
            
        }
        protected override bool OnBackButtonPressed()
        {
            listOfIntervals.Clear();
            Device.BeginInvokeOnMainThread(async () =>
            {
               
                    await Navigation.PushAsync(new MainPage());
              
            });
            return true; // return true to prevent the default behavior
        }
        private void SekundaM_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(1))
            {
                listOfIntervals.Remove(1);
                SekundaM.TextColor = Color.Gray;
                SekundaM.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(1);
                SekundaM.TextColor = Color.Black;
                SekundaM.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void SekundaW_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(2))
            {
                listOfIntervals.Remove(2);
                SekundaW.TextColor = Color.Gray;
                SekundaW.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(2);
                SekundaW.TextColor = Color.Black;
                SekundaW.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void TercjaM_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(3))
            {
                listOfIntervals.Remove(3);
                TercjaM.TextColor = Color.Gray;
                TercjaM.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(3);
                TercjaM.TextColor = Color.Black;
                TercjaM.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void TercjaW_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(4))
            {
                listOfIntervals.Remove(4);
                TercjaW.TextColor = Color.Gray;
                TercjaW.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(4);
                TercjaW.TextColor = Color.Black;
                TercjaW.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void Kwarta_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(5))
            {
                listOfIntervals.Remove(5);
                Kwarta.TextColor = Color.Gray;
                Kwarta.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(5);
                Kwarta.TextColor = Color.Black;
                Kwarta.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void Tryton_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(6))
            {
                listOfIntervals.Remove(6);
                Tryton.TextColor = Color.Gray;
                Tryton.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(6);
                Tryton.TextColor = Color.Black;
                Tryton.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void Kwinta_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(7))
            {
                listOfIntervals.Remove(7);
                Kwinta.TextColor = Color.Gray;
                Kwinta.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(7);
                Kwinta.TextColor = Color.Black;
                Kwinta.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void SekstaM_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(8))
            {
                listOfIntervals.Remove(8);
                SekstaM.TextColor = Color.Gray;
                SekstaM.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(8);
                SekstaM.TextColor = Color.Black;
                SekstaM.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void SekstaW_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(9))
            {
                listOfIntervals.Remove(9);
                SekstaW.TextColor = Color.Gray;
                SekstaW.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(9);
                SekstaW.TextColor = Color.Black;
                SekstaW.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void SeptymaM_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(10))
            {
                listOfIntervals.Remove(10);
                SeptymaM.TextColor = Color.Gray;
                SeptymaM.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(10);
                SeptymaM.TextColor = Color.Black;
                SeptymaM.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void SeptymaW_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(11))
            {
                listOfIntervals.Remove(11);
                SeptymaW.TextColor = Color.Gray;
                SeptymaW.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(11);
                SeptymaW.TextColor = Color.Black;
                SeptymaW.BackgroundColor = Color.FromHex("#b51414");

            }
        }

        private void Oktawa_Clicked(object sender, EventArgs e)
        {
            if (listOfIntervals.Contains(12))
            {
                listOfIntervals.Remove(12);
                Oktawa.TextColor = Color.Gray;
                Oktawa.BackgroundColor = Color.LightGray;

            }
            else
            {
                listOfIntervals.Add(12);
                Oktawa.TextColor = Color.Black;
                Oktawa.BackgroundColor = Color.FromHex("#b51414");

            }
        }
    }
}