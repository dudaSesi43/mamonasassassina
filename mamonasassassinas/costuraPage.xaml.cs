using System;
using mamonasassassinas;
using Microsoft.Maui.Controls;

namespace mamonasassassinas
{
    public partial class costuraPage : ContentPage
    {
        public costuraPage()
        {
            InitializeComponent(); 
        }

        private void OnVoltarButtonClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage();
        }
        
        
    }
}