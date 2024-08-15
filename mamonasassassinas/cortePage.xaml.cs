using System;
using Microsoft.Maui.Controls;

namespace mamonasassassinas
{
    public partial class cortePage : ContentPage
    {
        public cortePage()
        {
            InitializeComponent();
        }
        // Event handler for the button click event
        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage = new acabamentoPage();
        }
    }
}

