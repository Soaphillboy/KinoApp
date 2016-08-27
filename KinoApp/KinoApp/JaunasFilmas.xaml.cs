﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KinoApp
{
    public partial class JaunasFilmas : ContentPage
    {
        public JaunasFilmas()
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
                    Description = "Item 4",
                    Name = "Item 4"
                }, new Cinema()
                {
                    Description = "Item 5",
                    Name = "Item 5"
                }, new Cinema()
                {
                    Description = "Item 6",
                    Name = "Item 6"
                }, new Cinema()
                {
                    Description = "Item 7",
                    Name = "Item 7"
                }, new Cinema()
                {
                    Description = "Item 8",
                    Name = "Item 8"
                }, new Cinema()
                {
                    Description = "Item 9",
                    Name = "Item 9"
                }, new Cinema()
                {
                    Description = "Item 10",
                    Name = "Item 10"
                }
            };

            JaunasFilmasList.ItemsSource = masterPageItems;
        }
    }

}

