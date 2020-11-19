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

        async private void ButtonClicked(object sender, EventArgs e)
        {
            if(CheckIfNull(name.Text, email.Text, password.Text, newPassword.Text))
            {
                await DisplayAlert("Action can't be completed",
                                   "Need to fill all the entries to log in", "Ok");
            }
            else
            {
                //Push to home page.
            }
        }


        #region CheckIfNull
        /// <summary>
        /// Check if any of the entries is empty.
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="paramEmail"></param>
        /// <param name="paramPassword"></param>
        /// <param name="paramNewPassword"></param>
        /// <returns></returns>
        private bool CheckIfNull(string paramName, string paramEmail,
                                 string paramPassword, string paramNewPassword)
        {
            bool empty = false;
            string[] entries = { paramName, paramEmail, paramPassword, 
                                 paramNewPassword };

            for (int i = 0; i < entries.Length; i++)
                empty = string.IsNullOrEmpty(entries[i]) ? true : false;

            return empty;
        }
        #endregion
    }
}
