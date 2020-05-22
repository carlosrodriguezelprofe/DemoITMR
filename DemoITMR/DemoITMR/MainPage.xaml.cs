using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoITMR
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            DatosJSON informe = new DatosJSON();

            informe = Newtonsoft.Json.JsonConvert.DeserializeObject<DatosJSON>(obtenerDatos());
            apellido.Text = informe.apellido;
            nombre.Text = informe.nombre;
            edad.Text = informe.edad.ToString();

        }

        private string obtenerDatos()
        {

            string url = "https://profesorcarlosrodriguez.com/json/estadistica.php";

            string cadenaJSON = (new WebClient()).DownloadString(url);


            return cadenaJSON;

        }

    }
}
