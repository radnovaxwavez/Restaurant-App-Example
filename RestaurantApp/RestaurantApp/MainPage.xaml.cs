using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestaurantApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Task.Run(RotateImage); 
        }

        //Rotates the image
        private async void RotateImage()
        {
            while (true)
            {      
                                    
                await BannerImg.RelRotateTo(360, 5000, Easing.Linear);
            }
        }
    }
}
