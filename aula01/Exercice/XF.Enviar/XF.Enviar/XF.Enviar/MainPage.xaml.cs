using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Enviar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnHome_config(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage());
        }
    }
}
