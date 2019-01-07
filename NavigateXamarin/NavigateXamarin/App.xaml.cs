using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NavigateXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ListViewSamplePage();

            //MainPage = new NavigationPage(new MainPage());//IOS ve Android de geri tuşu getiriyor. NavigationPage dediğimde de redirect ederken pusshasync metodu ile redirect etmeliyim.
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
