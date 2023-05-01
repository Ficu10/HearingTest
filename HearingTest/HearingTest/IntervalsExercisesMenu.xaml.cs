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
		public IntervalsExercisesMenu ()
		{
			InitializeComponent ();
		}

        private async void Start_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IntervalsExercises());
        }
    }
}