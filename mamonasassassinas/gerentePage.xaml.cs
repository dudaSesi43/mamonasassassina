using Microsoft.Maui.Controls;

namespace mamonasassassinas
{
    public partial class gerentePage : ContentPage
    {
        public gerentePage()
        {
            InitializeComponent();
        }

      private void OnVoltarButtonClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}