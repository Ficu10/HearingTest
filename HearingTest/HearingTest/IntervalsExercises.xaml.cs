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
            if (IntervalsExercisesMenu.listOfIntervals.Contains(0))
            {
                Pryma.IsVisible = true;
            }
            if(IntervalsExercisesMenu.listOfIntervals.Contains(1))
            {
                SekundaM.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(2))
            {
                SekundaW.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(3))
            {
                TercjaM.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(4))
            {
                TercjaW.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(5))
            {
                Kwarta.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(6))
            {
                Tryton.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(7))
            {
                Kwinta.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(8))
            {
                SekstaW.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(9))
            {
                SekstaM.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(10))
            {
                SeptymaM.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(11))
            {
                SeptymaW.IsVisible = true;
            }
            if (IntervalsExercisesMenu.listOfIntervals.Contains(12))
            {
                Oktawa.IsVisible = true;
            }
            Iteracja.Text = i.ToString();
            Random r = new Random();
            selectMusic1 = r.Next(1, 85);
            Thread.Sleep(100);
            Random rList = new Random();
            int rListInt = rList.Next(IntervalsExercisesMenu.listOfIntervals.Count());


            selectMusic2 = selectMusic1 + IntervalsExercisesMenu.listOfIntervals[rListInt];
            if (selectMusic2 % 2 == 0)
            {
                if (selectMusic2 > 84)
                {
                    selectMusic2 = selectMusic1 - IntervalsExercisesMenu.listOfIntervals[rListInt];
                }
                else
                {
                    selectMusic2 = selectMusic1 + IntervalsExercisesMenu.listOfIntervals[rListInt];
                }
              
            }
            else
            {
                if (selectMusic2 > 84)
                {
                    selectMusic2 = selectMusic1 - IntervalsExercisesMenu.listOfIntervals[rListInt];
                }
                else
                {
                    selectMusic2 = selectMusic1 + IntervalsExercisesMenu.listOfIntervals[rListInt];
                }
              
            }
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
            
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(MusicSelect(selectMusic1));
            audio.Play();
            Thread.Sleep(1000);
            
            audio.Load(MusicSelect(selectMusic2));
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
                    IntervalsExercisesMenu.listOfIntervals.Clear();
                    i = 1;
                    await Navigation.PushAsync(new IntervalsExercisesMenu());
                }
            });
            return true; // return true to prevent the default behavior
        }

        public void AllPink()
        {
            Pryma.BackgroundColor = Color.HotPink;
            SekundaM.BackgroundColor = Color.HotPink;
            SekundaW.BackgroundColor = Color.HotPink;
            TercjaM.BackgroundColor = Color.HotPink;
            TercjaW.BackgroundColor = Color.HotPink;
            Kwarta.BackgroundColor = Color.HotPink;
            Tryton.BackgroundColor = Color.HotPink;
            Kwinta.BackgroundColor = Color.HotPink;
            SekstaM.BackgroundColor = Color.HotPink;
            SekstaW.BackgroundColor = Color.HotPink;
            SeptymaM.BackgroundColor = Color.HotPink;
            SeptymaW.BackgroundColor = Color.HotPink;
            Oktawa.BackgroundColor = Color.HotPink;
        }
        private void Pryma_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 0;
            Pryma.BackgroundColor = Color.Green;
        }

        private void SekundaM_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 1;
            SekundaM.BackgroundColor = Color.Green;
        }

        private void SekundaW_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 2;
            SekundaW.BackgroundColor = Color.Green;
        }

        private void TercjaM_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 3;
            TercjaM.BackgroundColor = Color.Green;
        }

        private void TercjaW_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 4;
            TercjaW.BackgroundColor = Color.Green;
        }

        private void Kwarta_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 5;
            Kwarta.BackgroundColor = Color.Green;
        }

        private void Tryton_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 6;
            Tryton.BackgroundColor = Color.Green;
        }

        private void Kwinta_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 7;
            Kwinta.BackgroundColor = Color.Green;
        }

        private void SekstaW_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 9;
            SekstaW.BackgroundColor = Color.Green;
        }

        private void SekstaM_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 8;
            SekstaM.BackgroundColor = Color.Green;
        }

        private void SeptymaM_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 10;
            SeptymaM.BackgroundColor = Color.Green;
        }

        private void Oktawa_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 12;
            Oktawa.BackgroundColor = Color.Green;
        }

        private void SeptymaW_Clicked(object sender, EventArgs e)
        {
            AllPink();
            usersSelect = 11;
            SeptymaW.BackgroundColor = Color.Green;
        }


        private async void Next_Clicked(object sender, EventArgs e)
        {
            if (isClick == true)
            {
                TestButton.IsVisible = true;
                AllPink();
                if (usersSelect == Math.Abs(selectMusic1 - selectMusic2) % 12)
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
                selectMusic1 = r.Next(1, 13);
                Thread.Sleep(100);
                Random rList = new Random();
                int rListInt = rList.Next(IntervalsExercisesMenu.listOfIntervals.Count());


                selectMusic2 = selectMusic1 + IntervalsExercisesMenu.listOfIntervals[rListInt];
                if (selectMusic2 % 2 == 0)
                {
                    if (selectMusic2 > 84)
                    {
                        selectMusic2 = selectMusic1 - IntervalsExercisesMenu.listOfIntervals[rListInt];
                    }
                    else
                    {
                        selectMusic2 = selectMusic1 + IntervalsExercisesMenu.listOfIntervals[rListInt];
                    }
                }
                else
                {
                    if (selectMusic2 > 84)
                    {
                        selectMusic2 = selectMusic1 - IntervalsExercisesMenu.listOfIntervals[rListInt];
                    }
                    else
                    {
                        selectMusic2 = selectMusic1 + IntervalsExercisesMenu.listOfIntervals[rListInt];
                    }
                }
                usersSelect = -1;
                isClick = false;
            }


        }

        private Stream MusicSelect(int number)
        {
            Stream fileName = GetStreamFromFile("C4.mp3");
            switch (number)
            {
                case 1:
                    fileName = GetStreamFromFile("C1.mp3");
                    break;
                case 2:
                    fileName = GetStreamFromFile("Db1.mp3");
                    break;
                case 3:
                    fileName = GetStreamFromFile("D1.mp3");
                    break;
                case 4:
                    fileName = GetStreamFromFile("Eb1.mp3");
                    break;
                case 5:
                    fileName = GetStreamFromFile("E1.mp3");
                    break;
                case 6:
                    fileName = GetStreamFromFile("F1.mp3");
                    break;
                case 7:
                    fileName = GetStreamFromFile("Gb1.mp3");
                    break;
                case 8:
                    fileName = GetStreamFromFile("G1.mp3");
                    break;
                case 9:
                    fileName = GetStreamFromFile("Ab1.mp3");
                    break;
                case 10:
                    fileName = GetStreamFromFile("A1.mp3");
                    break;
                case 11:
                    fileName = GetStreamFromFile("Bb1.mp3");
                    break;
                case 12:
                    fileName = GetStreamFromFile("B1.mp3");
                    break;
                case 13:
                    fileName = GetStreamFromFile("C2.mp3");
                    break;
                case 14:
                    fileName = GetStreamFromFile("Db2.mp3");
                    break;
                case 15:
                    fileName = GetStreamFromFile("D2.mp3");
                    break;
                case 16:
                    fileName = GetStreamFromFile("Eb2.mp3");
                    break;
                case 17:
                    fileName = GetStreamFromFile("E2.mp3");
                    break;
                case 18:
                    fileName = GetStreamFromFile("F2.mp3");
                    break;
                case 19:
                    fileName = GetStreamFromFile("Gb2.mp3");
                    break;
                case 20:
                    fileName = GetStreamFromFile("G2.mp3");
                    break;
                case 21:
                    fileName = GetStreamFromFile("Ab2.mp3");
                    break;
                case 22:
                    fileName = GetStreamFromFile("A2.mp3");
                    break;
                case 23:
                    fileName = GetStreamFromFile("Bb2.mp3");
                    break;
                case 24:
                    fileName = GetStreamFromFile("B2.mp3");
                    break;
                case 25:
                    fileName = GetStreamFromFile("C3.mp3");
                    break;
                case 26:
                    fileName = GetStreamFromFile("Db3.mp3");
                    break;
                case 27:
                    fileName = GetStreamFromFile("D3.mp3");
                    break;
                case 28:
                    fileName = GetStreamFromFile("Eb3.mp3");
                    break;
                case 29:
                    fileName = GetStreamFromFile("E3.mp3");
                    break;
                case 30:
                    fileName = GetStreamFromFile("F3.mp3");
                    break;
                case 31:
                    fileName = GetStreamFromFile("Gb3.mp3");
                    break;
                case 32:
                    fileName = GetStreamFromFile("G3.mp3");
                    break;
                case 33:
                    fileName = GetStreamFromFile("Ab3.mp3");
                    break;
                case 34:
                    fileName = GetStreamFromFile("A3.mp3");
                    break;
                case 35:
                    fileName = GetStreamFromFile("Bb3.mp3");
                    break;
                case 36:
                    fileName = GetStreamFromFile("B3.mp3");
                    break;
                case 37:
                    fileName = GetStreamFromFile("C4.mp3");
                    break;
                case 38:
                    fileName = GetStreamFromFile("Db4.mp3");
                    break;
                case 39:
                    fileName = GetStreamFromFile("D4.mp3");
                    break;
                case 40:
                    fileName = GetStreamFromFile("Eb4.mp3");
                    break;
                case 41:
                    fileName = GetStreamFromFile("E4.mp3");
                    break;
                case 42:
                    fileName = GetStreamFromFile("F4.mp3");
                    break;
                case 43:
                    fileName = GetStreamFromFile("Gb4.mp3");
                    break;
                case 44:
                    fileName = GetStreamFromFile("G4.mp3");
                    break;
                case 45:
                    fileName = GetStreamFromFile("Ab4.mp3");
                    break;
                case 46:
                    fileName = GetStreamFromFile("A4.mp3");
                    break;
                case 47:
                    fileName = GetStreamFromFile("Bb4.mp3");
                    break;
                case 48:
                    fileName = GetStreamFromFile("B4.mp3");
                    break;
                case 49:
                    fileName = GetStreamFromFile("C5.mp3");
                    break;
                case 50:
                    fileName = GetStreamFromFile("Db5.mp3");
                    break;
                case 51:
                    fileName = GetStreamFromFile("D5.mp3");
                    break;
                case 52:
                    fileName = GetStreamFromFile("Eb5.mp3");
                    break;
                case 53:
                    fileName = GetStreamFromFile("E5.mp3");
                    break;
                case 54:
                    fileName = GetStreamFromFile("F5.mp3");
                    break;
                case 55:
                    fileName = GetStreamFromFile("Gb5.mp3");
                    break;
                case 56:
                    fileName = GetStreamFromFile("G5.mp3");
                    break;
                case 57:
                    fileName = GetStreamFromFile("Ab5.mp3");
                    break;
                case 58:
                    fileName = GetStreamFromFile("A5.mp3");
                    break;
                case 59:
                    fileName = GetStreamFromFile("Bb5.mp3");
                    break;
                case 60:
                    fileName = GetStreamFromFile("B5.mp3");
                    break;
                case 61:
                    fileName = GetStreamFromFile("C6.mp3");
                    break;
                case 62:
                    fileName = GetStreamFromFile("Db6.mp3");
                    break;
                case 63:
                    fileName = GetStreamFromFile("D6.mp3");
                    break;
                case 64:
                    fileName = GetStreamFromFile("Eb6.mp3");
                    break;
                case 65:
                    fileName = GetStreamFromFile("E6.mp3");
                    break;
                case 66:
                    fileName = GetStreamFromFile("F6.mp3");
                    break;
                case 67:
                    fileName = GetStreamFromFile("Gb6.mp3");
                    break;
                case 68:
                    fileName = GetStreamFromFile("G6.mp3");
                    break;
                case 69:
                    fileName = GetStreamFromFile("Ab6.mp3");
                    break;
                case 70:
                    fileName = GetStreamFromFile("A6.mp3");
                    break;
                case 71:
                    fileName = GetStreamFromFile("Bb6.mp3");
                    break;
                case 72:
                    fileName = GetStreamFromFile("B6.mp3");
                    break;
                case 73:
                    fileName = GetStreamFromFile("C7.mp3");
                    break;
                case 74:
                    fileName = GetStreamFromFile("Db7.mp3");
                    break;
                case 75:
                    fileName = GetStreamFromFile("D7.mp3");
                    break;
                case 76:
                    fileName = GetStreamFromFile("Eb7.mp3");
                    break;
                case 77:
                    fileName = GetStreamFromFile("E7.mp3");
                    break;
                case 78:
                    fileName = GetStreamFromFile("F7.mp3");
                    break;
                case 79:
                    fileName = GetStreamFromFile("Gb7.mp3");
                    break;
                case 80:
                    fileName = GetStreamFromFile("G7.mp3");
                    break;
                case 81:
                    fileName = GetStreamFromFile("Ab7.mp3");
                    break;
                case 82:
                    fileName = GetStreamFromFile("A7.mp3");
                    break;
                case 83:
                    fileName = GetStreamFromFile("Bb7.mp3");
                    break;
                case 84:
                    fileName = GetStreamFromFile("B7.mp3");
                    break;
            }
            return fileName;
        }
    }
}