using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gestos
{
    public partial class MainPage : ContentPage
    {
        bool isVisible = false;
        int size = 0;
        public MainPage()
        {
            InitializeComponent();

            //Crear mi gesto
            var tap1 = new TapGestureRecognizer();
            //Asigno el evento a mi gesto
            tap1.Tapped += EventoTap;
            //Imagen le agrego mi  gesto
            image1.GestureRecognizers.Add(tap1);


            var tap2 = new TapGestureRecognizer();
            //Asigno el evento a mi gesto
            tap2.Tapped += EventoTap2;
            this.bvExample.GestureRecognizers.Add(tap2);


            var pinch1 = new PinchGestureRecognizer();
            pinch1.PinchUpdated += EventoUpdated;
            image1.GestureRecognizers.Add(pinch1);





        }

        void EventoTap(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            isVisible = !isVisible;
            if (isVisible)
            {
                imageSender.Source = "tapped.jpg";
            }
            else
            {
                imageSender.Source = "tapped2.jpg";
            }

            labelMessage.Text = "Ejemplo";
        }
        void EventoTap2(object sender, EventArgs args)
        {
            
            isVisible = !isVisible;
            if (isVisible)
            {
                image1.Source = "tapped.jpg";
            }
            else
            {
                image1.Source = "tapped2.jpg";
            }

            

        }

        void EventoUpdated(object sender, EventArgs args)
        {
            size++;            
            labelMessage.FontSize = size;
        }



    }
}
