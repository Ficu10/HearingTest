using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HearingTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MediumGame : ContentPage
    {

        int selectMusic = 1;
        int usersSelect = 0;
        public static int points = 0;
        public static int i = 1;
        bool isClick = false;
        public MediumGame()
        {
            InitializeComponent();
            Iteracja.Text = i.ToString();
            Random r = new Random();
            selectMusic = r.Next(1,13);
        }

        public void AllBlackisible()
        {
            Button9.IsVisible = true;
            Button10.IsVisible = true;
            Button11.IsVisible = true;
            Button12.IsVisible = true;
            Button8.IsVisible = true;
            Button1.IsVisible = false;
            Button1.IsVisible = true;
            Button2.IsVisible = false;
            Button2.IsVisible = true;
            Button3.IsVisible = false;
            Button3.IsVisible = true;
            Button4.IsVisible = false;
            Button4.IsVisible = true;
            Button5.IsVisible = false;
            Button5.IsVisible = true;
            Button6.IsVisible = false;
            Button6.IsVisible = true;
            Button7.IsVisible = false;
            Button7.IsVisible = true;
        }
        private void Button1_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button1.BackgroundColor = Color.Green;
            usersSelect = 1;
            Stream fileName = GetStreamFromFile("C4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBackGroundsBlack();

            AllBlackisible();

        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button2.BackgroundColor = Color.Green;
            usersSelect = 3;
            Stream fileName = GetStreamFromFile("D4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBackGroundsBlack();

            AllBlackisible();

        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button3.BackgroundColor = Color.Green;
            usersSelect = 5;
            Stream fileName = GetStreamFromFile("E4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBackGroundsBlack();

            AllBlackisible();

        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button4.BackgroundColor = Color.Green;
            usersSelect = 6;
            Stream fileName = GetStreamFromFile("F4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBackGroundsBlack();

            AllBlackisible();

        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button5.BackgroundColor = Color.Green;
            usersSelect = 8;
            Stream fileName = GetStreamFromFile("G4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBackGroundsBlack();

            AllBlackisible();

        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button6.BackgroundColor = Color.Green;
            usersSelect = 10;
            Stream fileName = GetStreamFromFile("A4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBackGroundsBlack();
            AllBlackisible();


        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button7.BackgroundColor = Color.Green;
            usersSelect = 12;
            Stream fileName = GetStreamFromFile("B4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBackGroundsBlack();

            AllBlackisible();

        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button8.BackgroundColor = Color.Green;
            usersSelect = 2;
            Stream fileName = GetStreamFromFile("Db4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBlackisible();
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button9.BackgroundColor = Color.Green;
            usersSelect = 4;
            Stream fileName = GetStreamFromFile("Eb4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBlackisible();
        }

        private void Button10_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button10.BackgroundColor = Color.Green;
            usersSelect = 7;
            Stream fileName = GetStreamFromFile("Gb4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBlackisible();
        }

        private void Button11_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button11.BackgroundColor = Color.Green;
            usersSelect = 9;
            Stream fileName = GetStreamFromFile("Ab4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBlackisible();
        }

        private void Button12_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button12.BackgroundColor = Color.Green;
            usersSelect = 11;
            Stream fileName = GetStreamFromFile("Bb4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            AllBlackisible();
        }
        private void AllBackGroundsWhite()
        {
            Button1.BackgroundColor = Color.White;
            Button2.BackgroundColor = Color.White;
            Button3.BackgroundColor = Color.White;
            Button4.BackgroundColor = Color.White;
            Button5.BackgroundColor = Color.White;
            Button6.BackgroundColor = Color.White;
            Button7.BackgroundColor = Color.White;
            Button8.BackgroundColor = Color.Black;
            Button9.BackgroundColor = Color.Black;
            Button10.BackgroundColor = Color.Black;
            Button11.BackgroundColor = Color.Black;
            Button12.BackgroundColor = Color.Black;

        }
        private void AllBackGroundsBlack()
        {
            Button8.BackgroundColor = Color.Black;
            Button9.BackgroundColor = Color.Black;
            Button10.BackgroundColor = Color.Black;
            Button11.BackgroundColor = Color.Black;
            Button12.BackgroundColor = Color.Black;

        }
        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("HearingTest.piano." + filename);

            return stream;
        }

        private void TestButton_Clicked(object sender, EventArgs e)
        {
            isClick = true;
            Stream fileName = GetStreamFromFile("C4.mp3");
            switch (selectMusic)
            {
                case 1:
                    fileName = GetStreamFromFile("C4.mp3");
                    break;
                case 2:
                    fileName = GetStreamFromFile("Db4.mp3");
                    break;
                case 3:
                    fileName = GetStreamFromFile("D4.mp3");
                    break;
                case 4:
                    fileName = GetStreamFromFile("Eb4.mp3");
                    break;
                case 5:
                    fileName = GetStreamFromFile("E4.mp3");
                    break;
                case 6:
                    fileName = GetStreamFromFile("F4.mp3");
                    break;
                case 7:
                    fileName = GetStreamFromFile("Gb4.mp3");
                    break;
                case 8:
                    fileName = GetStreamFromFile("G4.mp3");
                    break;
                case 9:
                    fileName = GetStreamFromFile("Ab4.mp3");
                    break;
                case 10:
                    fileName = GetStreamFromFile("A4.mp3");
                    break;
                case 11:
                    fileName = GetStreamFromFile("Bb4.mp3");
                    break;
                case 12:
                    fileName = GetStreamFromFile("B4.mp3");
                    break;
            }
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
            TestButton.IsVisible = false;
        }
        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await DisplayAlert("Wyjście", "Czy chcesz wyjść?", "Tak", "Nie");
                if (result)
                {
                    i = 1;
                    await Navigation.PushAsync(new MainPage());
                }
            });

            return true;
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            if (isClick == true)
            {
                TestButton.IsVisible = true;
                AllBackGroundsWhite();
                if (selectMusic == usersSelect)
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
                selectMusic = r.Next(1, 13);
                usersSelect = 0;
                isClick = false;
            }
            
            
        }
    }
}