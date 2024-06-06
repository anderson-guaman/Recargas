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

        private async void OnRechargeButtonClicked(object sender, EventArgs e)
        {
            bool confirmacion = await DisplayAlert("Confirmación", "¿Desea confirmar la recarga?", "Sí", "No");

            if (confirmacion)
            {
                // Lógica de recarga
                await DisplayAlert("Recarga", "Recarga realizada exitosamente", "OK");
            }
        }
    }

}
