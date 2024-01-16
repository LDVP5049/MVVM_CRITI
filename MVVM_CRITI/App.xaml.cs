using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM_CRITI.View;


namespace MVVM_CRITI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Critico();
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
