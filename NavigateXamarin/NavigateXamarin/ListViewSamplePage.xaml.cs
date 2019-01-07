using NavigateXamarin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigateXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSamplePage : ContentPage
    {
        public ListViewSamplePage()
        {
            InitializeComponent();
            var myList = new List<Users>
            {
                new Users
                {
                    UserName="Ahmet",
                    ImageUrl="https://1sg6qh19z33l3z3rl11fdxdq-wpengine.netdna-ssl.com/wp-content/uploads/2017/09/coder-traits.png",
                    UserID ="0007"
                },
                new Users
                {
                     UserName="Zafercan",
                    ImageUrl="https://juststickers.in/wp-content/uploads/2017/11/ninja-coder.png",
                    UserID ="0008"
                },
                    new Users
                {
                     UserName="Test",
                    ImageUrl="https://image.spreadshirtmedia.com/image-server/v1/compositions/1012620166/views/1,width=650,height=650,appearanceId=2,version=1543820067/icon-representation-of-super-hero-programmer-with-coding-brackets.jpg",
                    UserID ="0009"
                }

    };
            myListView.ItemsSource = myList;

        }
    }
}