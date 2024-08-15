using Microsoft.Maui.Controls;

namespace mamonasassassinas
{
    public partial class despachePage : ContentPage
    {
        public despachePage()
        {
            InitializeComponent();

            // Event handler for the BackButton click event
            BackButton.Clicked += OnBackButtonClicked;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Handle the back button click event here
            // For example, navigate to the previous page or perform some action
            Navigation.PopAsync();
        }
    }
}