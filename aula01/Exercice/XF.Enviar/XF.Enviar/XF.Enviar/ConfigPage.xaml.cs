using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Enviar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigPage : ContentPage
    {
        public ConfigPage()
        {
            InitializeComponent();

          
        }
                
        private void swEmail_OnChanged(object sender, ToggledEventArgs e)
        {
            if (swEmail.IsEnabled) {
                txtemail.IsEnabled = true;
                
            }
            else
            {
                txtemail.IsEnabled = false;
            }
        }
    }
}