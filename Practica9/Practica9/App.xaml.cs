using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practica9
{
    public partial class App : Application
    {
        public static SQLAzure Authenticator { get; private set; }

        public static void Init(SQLAzure authenticator) {

            Authenticator = authenticator;

        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Practica9.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            /*MainPage ventana = new Practica9.MainPage();
            ventana.Login();*/
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
