﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KinoApp
{
    public partial class FilmasPage : TabbedPage
    {
        public FilmasPage()
        {
            var navigationPage = new NavigationPage(new JaunasFilmas());
            navigationPage.Title = "Jaunākās";

        }
    }
}
