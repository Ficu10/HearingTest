using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HearingTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            base.OnStart();
            MainPage.SetValue(NavigationPage.HasNavigationBarProperty, false);
            MainPage.SetValue(NavigationPage.HasBackButtonProperty, false);
            Application.Current.MainPage.SetValue(Page.BackgroundColorProperty, Color.Black);
            Application.Current.MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Black);
            Application.Current.MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
            Device.SetFlags(new[] { "FullScreen" });
        }

        protected override void OnSleep()
        {
            base.OnSleep();
            MainPage.SetValue(NavigationPage.HasNavigationBarProperty, false);
            MainPage.SetValue(NavigationPage.HasBackButtonProperty, false);
            Application.Current.MainPage.SetValue(Page.BackgroundColorProperty, Color.Black);
            Application.Current.MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Black);
            Application.Current.MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
            Device.SetFlags(new[] { "FullScreen" });
        }

        protected override void OnResume()
        {
            base.OnResume();
            MainPage.SetValue(NavigationPage.HasNavigationBarProperty, false);
            MainPage.SetValue(NavigationPage.HasBackButtonProperty, false);
            Application.Current.MainPage.SetValue(Page.BackgroundColorProperty, Color.Black);
            Application.Current.MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Black);
            Application.Current.MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
            Device.SetFlags(new[] { "FullScreen" });
        }
        

    }
}
