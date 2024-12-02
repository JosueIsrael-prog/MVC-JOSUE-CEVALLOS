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
            // Obtén los valores de los campos
            string numero = NumeroTelefono.Text;
            string nombre = NombreUsuario.Text;

            // Validación básica
            if (string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(nombre))
            {
                await DisplayAlert("Error", "Todos los campos son obligatorios.", "OK");
                return;
            }

            // Ruta del archivo para guardar la información
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RecargaDatos.txt");

            // Guardar la información en el archivo
            File.WriteAllText(filePath, $"Nombre: {nombre}\nNúmero: {numero}");

            // Mostrar un mensaje de confirmación
            await DisplayAlert("Éxito", "La recarga fue exitosa.", "OK");

            // Actualizar el resultado en la interfaz
            UltimaRecargaLabel.Text = $"Última recarga:\nNombre: {nombre}\nNúmero: {numero}";

            // Limpiar los campos
            NumeroTelefono.Text = string.Empty;
            NombreUsuario.Text = string.Empty;
        }
    }
}