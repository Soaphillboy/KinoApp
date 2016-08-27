using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KinoApp
{
    public partial class CitiKinoteatri : ContentPage
    {
        public CitiKinoteatri()
        {
            InitializeComponent();
            var masterPageItems2 = new List<AllCinema>
            {
                new AllCinema()
                {
                    Name = "Gaisma",
                    Description = "Valmiera"
                },
                new AllCinema()
                {
                    Name = "Silver screen",
                    Description = "Daugavpils"
                },
                new AllCinema()
                {
                    Name = "Silver screen",
                    Description = "Rezekne"
                },
                new AllCinema()
                {
                    Name = "Lora",
                    Description = "Sigulda"
                },
                new AllCinema()
                {
                    Name = "Balle",
                    Description = "Liepaja"
                },
            };

            VisiKinoList.ItemsSource = masterPageItems2;

        }
    }
}
