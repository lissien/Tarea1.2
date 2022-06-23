using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarea2.Views;

namespace Tarea2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BindingPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
