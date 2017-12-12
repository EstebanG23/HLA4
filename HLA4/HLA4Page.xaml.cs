using Xamarin.Forms;

namespace HLA4
{
    public partial class HLA4Page : ContentPage
    {
        public HLA4Page()
        {
            InitializeComponent();
        }

        void Handle_Activated(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UserProfile());
        }
    }
}
