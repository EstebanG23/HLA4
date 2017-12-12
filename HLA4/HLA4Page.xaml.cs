using Xamarin.Forms;

namespace HLA4
{
    public partial class HLA4Page : ContentPage
    {
        public HLA4Page()
        {
            InitializeComponent();

        }

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
        }

        void Handle_Activated(object sender, System.EventArgs e)
            {
                Navigation.PushAsync(new UserProfile());
            }
        }
    
}
