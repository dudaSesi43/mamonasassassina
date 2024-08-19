using Microsoft.Maui.Controls;

namespace mamonasassassinas
{
    public partial class despachePage : ContentPage
    {
        public despachePage()
        {
            InitializeComponent();

            // Event handler for the BackButton click event
           
        }

         private void OnVoltarButtonClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
    }
