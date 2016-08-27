using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KinoApp
{
    public partial class Kinoteatri : ContentPage
    {
        public Kinoteatri()
        {
            InitializeComponent();

            var masterPageItems = new List<Cinema>
            {
                new Cinema()
                {
                    Name = "ForumCinemas"
                },
                new Cinema()
                {
                    Name = "Cinamon"
                },
                new Cinema()
                {
                    Name = "Multikino"
                },
                new Cinema()
                {
                    Name = "Splendid Palace"
                },
                new Cinema()
                {
                    Name = "Kino Suns"
                },
            };
            var masterPageItems2 = new List<AllCinema>
            {
                new AllCinema()
                {
                    Name = "",
                    Description = ""
                },
                new AllCinema()
                {
                    Name = "",
                    Description = ""
                },
                new AllCinema()
                {
                    Name = "",
                    Description = ""
                },
                new AllCinema()
                {
                    Name = "",
                    Description = ""
                },
                new AllCinema()
                {
                    Name = "",
                    Description = ""
                },
            };


            AllPlacesListView.ItemsSource = masterPageItems;
            VisiKinoList.ItemsSource = masterPageItems2;
        }
    }
    
}
