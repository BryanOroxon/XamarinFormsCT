using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsCT.Views;

namespace XamarinFormsCT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MediaElementPage();
        }

    }
}
