using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinLoginExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        #region ButtonClicked
        async private void ButtonClicked(object sender, EventArgs e)
        {
            bool empty = false;
            string[] entries = { name.Text, email.Text, password.Text,
                                 newPassword.Text };

            //Check if there's any empty entry. 
            for (int i = 0; i < entries.Length; i++) {
                if (string.IsNullOrEmpty(entries[i]))
                {
                    empty = true;
                    break;
                }
            }


            if (empty)
            {
                await DisplayAlert("No se puede completar la acción",
                                   "Debe llenar todos los campos", "Ok");
            }
            else if (!password.Text.Equals(newPassword.Text))
            {
                await DisplayAlert("No se puede completar la acción",
                                   "La contraseña debe ser igual en ambos campos",
                                   "OK");
            }
            else
            {
                //Push to home page.
                await DisplayAlert("Bienvendio!", "", "Gracias");
                await Navigation.PushAsync(new HomePage(name.Text));
            }
        }
        #endregion
    }
}
