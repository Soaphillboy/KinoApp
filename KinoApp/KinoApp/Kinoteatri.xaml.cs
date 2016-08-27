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
                    Name = "Item 1"
                },
                new Cinema()
                {
                    Description = "Item 2",
                    Name = "Item 2"
                },
                new Cinema()
                {
                    Description = "Item 3",
                    Name = "Item 3"
                } new Cinema()
                {
                    Description = "Item 3",
                    Name = "Item 3"
                } new Cinema()
                {
                    Description = "Item 3",
                    Name = "Item 3"
                } new Cinema()
                {
                    Description = "Item 3",
                    Name = "Item 3"
                } new Cinema()
                {
                    Description = "Item 3",
                    Name = "Item 3"
                } new Cinema()
                {
                    Description = "Item 3",
                    Name = "Item 3"
                } new Cinema()
                {
                    Description = "Item 3",
                    Name = "Item 3"
                }
            };

            AllPlacesListView.ItemsSource = masterPageItems;
        }
    }
    
}
