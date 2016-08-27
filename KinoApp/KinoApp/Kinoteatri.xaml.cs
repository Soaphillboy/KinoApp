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
                    Description = "Item 1",
                    Name = "Forum Cinemas"
                },
                new Cinema()
                {
                    Description = "Item 2",
                    Name = "Cinamon"
                },
                new Cinema()
                {
                    Description = "Item 3",
                    Name = "Kino suns"
                }, new Cinema()
                {
                    Description = "Item 4",
                    Name = "Gaisma"
                }, new Cinema()
                {
                    Description = "Item 5",
                    Name = "Gaisma"
                }, new Cinema()
                {
                    Description = "Item 6",
                    Name = "Rio"
                }, new Cinema()
                {
                    Description = "Item 7",
                    Name = "Multikino"
                }, new Cinema()
                {
                    Description = "Item 8",
                    Name = "Item 8"
                }, new Cinema()
                {
                    Description = "Item 9",
                    Name = "Item 9"
                }
            };

            AllPlacesListView.ItemsSource = masterPageItems;
        }
    }
    
}
