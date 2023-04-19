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
    public partial class EasyGame : ContentPage
    {

        int selectMusic = 1;
        int usersSelect = 0;
        public static int points = 0;
        public static int i = 1;
        public EasyGame()
        {
            InitializeComponent();
            Points.Text = points.ToString() + "/10";
            Iteracja.Text = i.ToString();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button1.BackgroundColor = Color.Green;
            usersSelect = 1;
            Stream fileName = GetStreamFromFile("c4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button2.BackgroundColor = Color.Green;
            usersSelect = 2;
            Stream fileName = GetStreamFromFile("d4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button3.BackgroundColor = Color.Green;
            usersSelect = 3;
            Stream fileName = GetStreamFromFile("e4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button4.BackgroundColor = Color.Green;
            usersSelect = 4;
            Stream fileName = GetStreamFromFile("f4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button5.BackgroundColor = Color.Green;
            usersSelect = 5;
            Stream fileName = GetStreamFromFile("g4.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button6.BackgroundColor = Color.Green;
            usersSelect = 6;
            Stream fileName = GetStreamFromFile("a5.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            AllBackGroundsWhite();
            Button7.BackgroundColor = Color.Green;
            usersSelect = 7;
            Stream fileName = GetStreamFromFile("b5.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
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
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("HearingTest." + filename);

            return stream;
        }

        private void TestButton_Clicked(object sender, EventArgs e)
        {
            Stream fileName = GetStreamFromFile("c4.mp3");
            switch (selectMusic)
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
            }
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {

            AllBackGroundsWhite();
            if (selectMusic == usersSelect)
            {
                points++;
            }
            else
            {

            }
            if (i == 10)
            {
                i = 0;
                await Navigation.PushAsync(new EndGame());
            }
            i++;
            Points.Text = points.ToString() + "/10";
            Iteracja.Text = i.ToString();
            Random r = new Random();
            selectMusic = r.Next(1, 8);
            usersSelect = 0;
        }
    }
}