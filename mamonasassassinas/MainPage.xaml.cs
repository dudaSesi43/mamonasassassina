using Microsoft.Maui.Controls;

namespace mamonasassassinas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Despache(object sender, EventArgs args)
        {
            Application.Current.MainPage = new despache();
        }

        private void Usuario(object sender, EventArgs args)
        {
            Application.Current.MainPage = new usuario();
        }
        private void Corte(object sender, EventArgs args)
        {
            Application.Current.MainPage = new corte();
        }
        private void Acabamento(object sender, EventArgs args)
        {
            Application.Current.MainPage = new acabamento();
        }
        private void Costura(object sender, EventArgs args)
        {
            Application.Current.MainPage = new costura();
        }
        private void Gerente(object sender, EventArgs args)
        {
            Application.Current.MainPage = new gerente();
        }
    }
}

