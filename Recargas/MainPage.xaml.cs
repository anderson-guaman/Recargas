namespace Recargas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SeleccionValorRecarga(object sender, CheckedChangedEventArgs e)
        {
            var valorSeleccionado = ((RadioButton)sender).Content.ToString();
            AGlabelSeleccion.Text = $"Ha seleccionado una recarga de: {valorSeleccionado} dólares";
        }

        
    }

}
