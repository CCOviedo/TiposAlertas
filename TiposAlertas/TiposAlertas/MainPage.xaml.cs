using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TiposAlertas
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.btnestandar.Clicked += Btnestandar_Clicked;
            this.btnsino.Clicked += Btnsino_Clicked;
            this.btnopciones.Clicked += Btnopciones_Clicked;
            this.btndestroy.Clicked += Btndestroy_Clicked;
		}

        private async void Btndestroy_Clicked(object sender, EventArgs e)
        {
            String res =
            await DisplayActionSheet("ActionSheet: Guardar Foto?"
            , "Cancelar", "Borrar", "Carrete", "Email");
            this.txtrespuesta.Text = res;
        }

        private async void Btnopciones_Clicked(object sender, EventArgs e)
        {
            String op =
                await  DisplayActionSheet("ActionSheet: Enviar por?", 
                "Cancelar", null, "Email", "Twitter", "Facebook");
            this.txtrespuesta.Text = op;
        }

        private async void Btnsino_Clicked(object sender, EventArgs e)
        {
            bool respuesta =
                await DisplayAlert("Pregunta?", "Quieres jugar a un juego", "Si", "No");
            if (respuesta == true)
            {
                this.txtrespuesta.Text = "Has perdido.";
            }
            else
            {
                this.txtrespuesta.Text = "Que pena...";
            }
        }

        private void Btnestandar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje Estándar", "Esto es una alerta estándar", "OK");
        }

        //protected override void OnAppearing()
        //{
        //    DisplayAlert("Mensaje OnAppearing", "Este mensaje aparece al cargar la app", "OK");
        //}
    }
}
