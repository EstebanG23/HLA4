using Xamarin.Forms;

namespace HLA4
{
    public partial class HLA4Page : ContentPage
    {
        public HLA4Page()
        {
            InitializeComponent();

        }

<<<<<<< HEAD
        private void CalendarButton_Clicked(object sender, System.EventArgs e)
        {

        }
        private void CheckInButton_Clicked(object sender, System.EventArgs e)
        {

        }
        private void StudentOrgButton_Clicked(object sender, System.EventArgs e)
        {

        }
        private void GradOrgButton_Clicked(object sender, System.EventArgs e)
        {

        }
        private void GainButton_Clicked(object sender, System.EventArgs e)
        {

        }
        private void MCDAButton_Clicked(object sender, System.EventArgs e)
        {

=======
        void Handle_Activated(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UserProfile());
>>>>>>> 9de342e4680c72b314499b427addd45a077ec321
        }
    }
}
