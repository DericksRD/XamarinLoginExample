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
                await DisplayAlert("Action can't be completed",
                                   "Need to fill all the entries to log in", "Ok");
            }
            else if (!password.Text.Equals(newPassword.Text))
            {
                await DisplayAlert("Action can't be completed",
                                   "The password need to be equal in both entries.",
                                   "OK");
            }
            else
            {
                //Push to home page.
                await Navigation.PushAsync(new HomePage());
            }
        }
        #endregion
    }
}
