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
            Application.Current.MainPage = new despachePage();
        }

        private void Usuario(object sender, EventArgs args)
        {
            Application.Current.MainPage = new usuarioPage();
        }
        private void Corte(object sender, EventArgs args)
        {
            Application.Current.MainPage = new cortePage();
        }
        private void Acabamento(object sender, EventArgs args)
        {
            Application.Current.MainPage = new acabamentoPage();
        }
        private void Costura(object sender, EventArgs args)
        {
            Application.Current.MainPage = new costuraPage();
        }
        private void Gerente(object sender, EventArgs args)
        {
            Application.Current.MainPage = new gerentePage();
        }
    }
}

