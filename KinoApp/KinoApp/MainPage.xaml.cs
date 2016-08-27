using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KinoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void LogInClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FilmasPage());
        }
        async void UzKino(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kinoteatri());
        }
    }
}
