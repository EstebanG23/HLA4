using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HLA4
{
    public partial class StudentOrg : ContentPage
    {
        public StudentOrg()
        {
            InitializeComponent();
            var vList = App.DAUtil.GetAllUndergrad();
            UndergradData.ItemsSource = vList;
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            DisplayAlert("Tapped","Works","Great!");
        }
    }
}
