using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigateXamarin.NaviPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new MainPage());
            await DisplayAlert("Son Sayfadason", "Tamam", "Çıkış");
        }
    }
}