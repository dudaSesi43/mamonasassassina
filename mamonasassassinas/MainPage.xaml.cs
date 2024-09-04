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
            Application.Current.MainPage = new Despache();
        }

        private void Usuario(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Usuario();
        }
        private void Corte(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Corte();
        }
        private void Acabamento(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Acabamento();
        }
        private void Costura(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Costura();
        }
        private void Gerente(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Gerente();
        }
    }
}

