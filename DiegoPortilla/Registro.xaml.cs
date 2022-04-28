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
    public partial class Registro : ContentPage
    {
        public Registro(string nombre, string usuario, string cuotas)
        {
            double diferencia = Convert.ToDouble(cuotas) * 5;
            InitializeComponent();
            lblUsuario.Text = "Bienvenidos sistema de Cursos OnLine:" + usuario;
            txtNombre.Text = nombre;
            txtCuotas.Text = cuotas.ToString();
            txtTotal.Text = diferencia.ToString();
        }
    }
}