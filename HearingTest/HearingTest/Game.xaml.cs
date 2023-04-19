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
    public partial class Game : ContentPage
    {

        int selectMusic = 1;
        int usersSelect = 0;
        public static int points = 0;
        public static int i = 1;
        public Game()
        {
            InitializeComponent();
            Iteracja.Text = i.ToString();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            AllBordersOff();
            Button1.BorderWidth = 3;
            usersSelect = 1;
            Stream fileName = GetStreamFromFile("C.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            AllBordersOff();
            Button2.BorderWidth = 3;
            usersSelect = 2;
            Stream fileName = GetStreamFromFile("D.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            AllBordersOff();
            Button3.BorderWidth = 3;
            usersSelect = 3;
            Stream fileName = GetStreamFromFile("E.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            AllBordersOff();
            Button4.BorderWidth = 3;
            usersSelect = 4;
            Stream fileName = GetStreamFromFile("F.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            AllBordersOff();
            Button5.BorderWidth = 3;
            usersSelect = 5;
            Stream fileName = GetStreamFromFile("G.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            AllBordersOff();
            Button6.BorderWidth = 3;
            usersSelect = 6;
            Stream fileName = GetStreamFromFile("A.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            AllBordersOff();
            Button7.BorderWidth = 3;
            usersSelect = 7;
            Stream fileName = GetStreamFromFile("H.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }
        private void AllBordersOff()
        {
            Button1.BorderWidth = 0;
            Button2.BorderWidth = 0;
            Button3.BorderWidth = 0;
            Button4.BorderWidth = 0;
            Button5.BorderWidth = 0;
            Button6.BorderWidth = 0;
            Button7.BorderWidth = 0;
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("HearingTest." + filename);

            return stream;
        }

        private void TestButton_Clicked(object sender, EventArgs e)
        {
            Stream fileName = GetStreamFromFile("C.mp3");
            switch (selectMusic)
            {
                case 1:
                    fileName = GetStreamFromFile("C.mp3");
                    break;
                case 2:
                    fileName = GetStreamFromFile("D.mp3");
                    break;
                case 3:
                    fileName = GetStreamFromFile("E.mp3");
                    break;
                case 4:
                    fileName = GetStreamFromFile("F.mp3");
                    break;
                case 5:
                    fileName = GetStreamFromFile("G.mp3");
                    break;
                case 6:
                    fileName = GetStreamFromFile("A.mp3");
                    break;
                case 7:
                    fileName = GetStreamFromFile("H.mp3");
                    break;
            }
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(fileName);
            audio.Play();
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
           
            AllBordersOff();
            if (selectMusic == usersSelect)
            {
                points++;
            }
            if (i == 10)
            {
                i =0;
                await Navigation.PushAsync(new MainPage());
            }
            i++;
            Iteracja.Text = i.ToString();

            Random r = new Random();
            selectMusic = r.Next(1, 7);

        }
    }
}