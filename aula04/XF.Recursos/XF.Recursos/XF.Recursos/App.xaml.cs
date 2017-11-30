using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace XF.Recursos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeAppCenter();

            MainPage = new NavigationPage(new XF.Recursos.MainPage());
        }

        public static async Task Sleep(int ms) {
            await Task.Delay(ms);
        }

        public void InitializeAppCenter() {

            AppCenter.Start("android=b918d044-2979-4e7e-bd74-8c72769e7551;" + "uwp={Your UWP App secret here};" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
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
