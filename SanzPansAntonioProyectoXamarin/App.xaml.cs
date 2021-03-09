using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SanzPansAntonioProyectoXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GhostWikiCardsPage();
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
