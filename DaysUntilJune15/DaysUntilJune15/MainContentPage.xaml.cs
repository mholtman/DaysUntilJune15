using Xamarin.Forms;

namespace DaysUntilJune15
{
	public partial class MainContentPage : ContentPage
	{
		public MainContentPage()
		{
			InitializeComponent();
			this.BindingContext = new MainContentPageViewModel();
        }
	}
}
