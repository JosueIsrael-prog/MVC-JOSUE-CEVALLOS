using System;
using System.IO;

namespace CevallosJosueExamenP2
{
    public partial class RecargaTelefonicaPage : ContentPage
    {
        public RecargaTelefonicaPage()
        {
            InitializeComponent();
        }

        private async void OnRecargarClicked(object sender, EventArgs e)
        {
            string numero = NumeroTelefono.Text;
            string nombre = NombreUsuario.Text;

            if (string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(nombre))
            {
                await DisplayAlert("Error", "Todos los campos son obligatorios.", "OK");
                return;
            }

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RecargaDatos.txt");
            File.WriteAllText(filePath, $"Nombre: {nombre}\nNúmero: {numero}");

            await DisplayAlert("Éxito", "La recarga fue exitosa.", "OK");
            UltimaRecargaLabel.Text = $"Última recarga:\nNombre: {nombre}\nNúmero: {numero}";

            NumeroTelefono.Text = string.Empty;
            NombreUsuario.Text = string.Empty;
        }
    }
}