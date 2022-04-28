using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiegoPortilla
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string dato1, string nota1)
        {
            string datoa = nota1;
            InitializeComponent();

            lblUsuario.Text = nota1;
            
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double montoInicial = Convert.ToDouble(txtMonto.Text);
            double subCuota = 0;
            double cuota = 0;

            if (montoInicial > 0 && montoInicial < 3000)
            {
                subCuota = 3000 - montoInicial;
                cuota = ((subCuota * .05) + subCuota) / 3;
                txtMensual.Text = cuota.ToString();
            }
            else
            {
                txtMonto.Text = "";
                await DisplayAlert(" Alerta", "El monto inicial es mayor a 3000 o inferior a 0, Proceda a Cambiar", "Aceptar");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string cuotas = txtMensual.Text;
            string usuario = lblUsuario.Text;

            if (txtMonto.Text == "" || txtNombre.Text == "" || txtMensual.Text == "")
            {
                await DisplayAlert("Alerta", "Faltan datos", "Aceptar");
            }
            else
            {
                await DisplayAlert(" Alerta", "Datos guardados satisfactoriamente", "Aceptar");
                await Navigation.PushAsync(new Registro(nombre, usuario, cuotas));
            }


        }
    }
}