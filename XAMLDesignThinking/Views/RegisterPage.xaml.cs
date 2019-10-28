using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XAMLDesignThinking.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async void CreateAccount_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.ProfilePage());
        }
    }
}
