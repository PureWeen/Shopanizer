using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Shopanizer
{
    public partial class StoreItems : ContentPage
    {
        public StoreItems()
        {
            InitializeComponent();
            cvStoreItems.ItemsSource = new[] { "Item1", "Item2" };
        }
    }
}
