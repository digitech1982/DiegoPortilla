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
    public partial class Loggin : ContentPage
    {
        public Loggin()
        {
            InitializeComponent();
        }

        private async void btnlogin_Clicked(object sender, EventArgs e)
        {
            string dato1 = "diego2022";
            string dato2 = "diego2022";
            string nota1 = Convert.ToString(valUser.Text);
            string nota2 = Convert.ToString(valPasswd.Text);

            try
            {
                if (nota1 == dato1 && nota2 == dato2)
                {
                    await Navigation.PushAsync(new Resumen(dato1,dato2));

                }
                else
                {
                    string mensaje = " Usuario o contraseña no validos.";
                    await DisplayAlert("Advertencia", mensaje, "Aceptar");
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Mensaje de Alerta", ex.Message, "Aceptar");
            }
        }
    }
}