using System;
using Microsoft.Maui.Controls;


namespace mamonasassassinas
{
    public partial class acabamentoPage : ContentPage
    {
        public acabamentoPage()
        {
            InitializeComponent();
        }

        // Event handler for the button click event
        private void OnVoltarButtonClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}