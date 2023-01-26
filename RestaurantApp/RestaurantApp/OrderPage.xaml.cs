using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestaurantApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        
        private void CarouselPositionChanged(object sender, PositionChangedEventArgs e)
        {
            var carousel = sender as CarouselView; //Object carousel is a CarouselView component
            var views = carousel.VisibleViews; //Provides list of all views?

            if (views.Count > 0)
            {
                foreach (var view in views)
                {
                    var img = view.FindByName<Image>("MenuImg"); //Finding the name of images via the x:name in XAML script
                    ViewExtensions.CancelAnimations(img);

                    //Another rotate command, not different animation type using Easing
                    Task.Run(async () => await img.RelRotateTo(360, 5000, Easing.BounceOut));
                }
            } 
        }
        private async void BackCommand()
        {
            await Navigation.PopAsync();
        }

    }


}