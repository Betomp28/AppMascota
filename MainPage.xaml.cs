using AppMascota.vista;

namespace AppMascota
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btIngresar_Clicked(object sender, EventArgs e)
        {

           
        }

        private void btregistrarse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagRegistro());
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {

        }
    }

}
/// prueva 