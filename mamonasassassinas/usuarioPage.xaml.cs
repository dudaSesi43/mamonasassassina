using System;
using Microsoft.Maui.Controls;

namespace mamonasassassinas
{
    public partial class usuarioPage : ContentPage
    {
        public usuarioPage()
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
        } private void OnVoltarButtonClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}