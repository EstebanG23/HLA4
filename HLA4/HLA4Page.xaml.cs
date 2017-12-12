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
            Navigation.PushAsync(new Calendar());
        }
        private void CheckInButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CheckIn());
        }
        private void StudentOrgButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StudentOrg());
        }
        private void GradOrgButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GradOrg());
        }
        private void GainButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Gainesville());
        }
        private void MCDAButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MCDA());
        }

        void Handle_Activated(object sender, System.EventArgs e)
            {
                Navigation.PushAsync(new UserProfile());
            }
        }
    
}
