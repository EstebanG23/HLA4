using System;

using Xamarin.Forms;

namespace HLA4
{
    public class Gainsville : ContentPage
    {
        public Gainsville()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

