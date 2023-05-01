using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HearingTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntervalsExercises : ContentPage
    {

        int selectMusic1;
        int selectMusic2;
        int usersSelect = 0;
        public static int points = 0;
        public static int i = 1;
        bool isClick = false;
        public IntervalsExercises()
        {
            InitializeComponent();
            Iteracja.Text = i.ToString();
            Random r = new Random();
            selectMusic1 = r.Next(1, 9);
            Thread.Sleep(100);
            selectMusic2 = r.Next(1, 9);

        }

       

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("HearingTest." + filename);

            return stream;
        }

        private void TestButton_Clicked(object sender, EventArgs e)
        {
            isClick = true;
            Stream fileName = GetStreamFromFile("c4.mp3");
            switch (selectMusic1)
            {
                case 1:
                    fileName = GetStreamFromFile("c4.mp3");
                    break;
                case 2:
                    fileName = GetStreamFromFile("d4.mp3");
                    break;
                case 3:
                    fileName = GetStreamFromFile("e4.mp3");
                    break;
                case 4:
                    fileName = GetStreamFromFile("f4.mp3");
                    break;
                case 5:
                    fileName = GetStreamFromFile("g4.mp3");
                    break;
                case 6:
                    fileName = GetStreamFromFile("a5.mp3");
                    break;
                case 7:
                    fileName = GetStreamFromFile("b5.mp3");
                    break;
                case 8:
                    fileName = GetStreamFromFile("c5.mp3");
                    break;
            }
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            Thread.Sleep(1000);
            switch (selectMusic2)
            {
                case 1:
                    fileName = GetStreamFromFile("c4.mp3");
                    break;
                case 2:
                    fileName = GetStreamFromFile("d4.mp3");
                    break;
                case 3:
                    fileName = GetStreamFromFile("e4.mp3");
                    break;
                case 4:
                    fileName = GetStreamFromFile("f4.mp3");
                    break;
                case 5:
                    fileName = GetStreamFromFile("g4.mp3");
                    break;
                case 6:
                    fileName = GetStreamFromFile("a5.mp3");
                    break;
                case 7:
                    fileName = GetStreamFromFile("b5.mp3");
                    break;
                case 8:
                    fileName = GetStreamFromFile("c5.mp3");
                    break;
            }

            audio.Load(fileName);
            audio.Play();
            TestButton.IsVisible = false;
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            if (isClick == true)
            {
                TestButton.IsVisible = true;
                if (Math.Abs((selectMusic1 - selectMusic2)) == usersSelect)
                {
                    points++;
                    switch (i)
                    {
                        case 1:
                            Answear1.Source = "goodImage.png";
                            break;
                        case 2:
                            Answear2.Source = "goodImage.png";
                            break;
                        case 3:
                            Answear3.Source = "goodImage.png";
                            break;
                        case 4:
                            Answear4.Source = "goodImage.png";
                            break;
                        case 5:
                            Answear5.Source = "goodImage.png";
                            break;
                        case 6:
                            Answear6.Source = "goodImage.png";
                            break;
                        case 7:
                            Answear7.Source = "goodImage.png";
                            break;
                        case 8:
                            Answear8.Source = "goodImage.png";
                            break;
                        case 9:
                            Answear9.Source = "goodImage.png";
                            break;
                        case 10:
                            Answear10.Source = "goodImage.png";
                            break;
                    }

                }
                else
                {
                    switch (i)
                    {
                        case 1:
                            Answear1.Source = "wrongImage.png";
                            break;
                        case 2:
                            Answear2.Source = "wrongImage.png";
                            break;
                        case 3:
                            Answear3.Source = "wrongImage.png";
                            break;
                        case 4:
                            Answear4.Source = "wrongImage.png";
                            break;
                        case 5:
                            Answear5.Source = "wrongImage.png";
                            break;
                        case 6:
                            Answear6.Source = "wrongImage.png";
                            break;
                        case 7:
                            Answear7.Source = "wrongImage.png";
                            break;
                        case 8:
                            Answear8.Source = "wrongImage.png";
                            break;
                        case 9:
                            Answear9.Source = "wrongImage.png";
                            break;
                        case 10:
                            Answear10.Source = "wrongImage.png";
                            break;
                    }
                }
                if (i == 10)
                {
                    i = 0;
                    await Navigation.PushAsync(new EndGame());
                }
                i++;
                Iteracja.Text = i.ToString();

                Random r = new Random();
                selectMusic1 = r.Next(1, 9);
                Thread.Sleep(1000);
                selectMusic2 = r.Next(1, 9);
                usersSelect = 0;
                isClick = false;
            }


        }
        protected override bool OnBackButtonPressed()
        {
            i = 0;
            Navigation.PushAsync(new IntervalsExercisesMenu());
            return true; // return true to prevent the default behavior
        }
        private void Pryma_Clicked(object sender, EventArgs e)
        {

        }

        private void SekundaM_Clicked(object sender, EventArgs e)
        {

        }

        private void SekundaW_Clicked(object sender, EventArgs e)
        {

        }

        private void TercjaM_Clicked(object sender, EventArgs e)
        {

        }

        private void TercjaW_Clicked(object sender, EventArgs e)
        {

        }

        private void Kwarta_Clicked(object sender, EventArgs e)
        {

        }

        private void Tryton_Clicked(object sender, EventArgs e)
        {

        }

        private void Kwinta_Clicked(object sender, EventArgs e)
        {

        }

        private void SekstaW_Clicked(object sender, EventArgs e)
        {

        }

        private void SekstaM_Clicked(object sender, EventArgs e)
        {

        }

        private void SeptymaM_Clicked(object sender, EventArgs e)
        {

        }

        private void Oktawa_Clicked(object sender, EventArgs e)
        {

        }

        private void SeptymaW_Clicked(object sender, EventArgs e)
        {

        }
    }
}