using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gestos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        void OnSwiped(object sender, SwipedEventArgs e)
        {
            string direction = e.Direction.ToString();

            if (direction == "Right")
                this.bvDemo.BackgroundColor = Color.Red;
            if (direction == "Left")
                this.bvDemo.BackgroundColor = Color.Yellow;
            if (direction == "Up")
                this.bvDemo.BackgroundColor = Color.Orange;
            if (direction == "Down")
                this.bvDemo.BackgroundColor = Color.Green;




        }

    }
}