using System;
using Microsoft.Maui.Controls;

namespace mamonasassassinas
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnCreateLoginClicked(object sender, EventArgs e)
        {
            // Implementar lógica para criar login
            DisplayAlert("Login", "Login criado com sucesso!", "OK");
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            // Implementar lógica para voltar
            Navigation.PopAsync();
        }
    }
}