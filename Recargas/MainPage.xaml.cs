using Microsoft.Maui.Controls;
using System;
using System.IO;
using System.Threading.Tasks;

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

        private async void btnRecargar(object sender, EventArgs e)
        {
            bool confirmacion = await DisplayAlert("Confirmación", "¿Desea confirmar la recarga?", "Sí", "No");

            if (confirmacion)
            {

                string numeroCelular = AGnumeroCelular.Text;
                string valorSeleccionado = AGlabelSeleccion.Text.Replace("Ha seleccionado una recarga de: ", "").Replace(" dólares", "");
                string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                string contenido = $"Se hizo una recarga al numero {numeroCelular} de {valorSeleccionado} en la siguiente fecha: {fecha}";

                await Guardar(numeroCelular, contenido);

                await DisplayAlert("Recarga", "Recarga realizada exitosamente", "OK");
            }

        }
        private async Task Guardar(string nombreArchivo, string contenido)
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, $"{nombreArchivo}.txt");
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                await writer.WriteLineAsync(contenido);
            }
        }

    }

}
