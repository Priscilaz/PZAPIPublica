using PZAPIPublica.ViewModels;

namespace PZAPIPublica.Views;

public partial class PZApodPage : ContentPage
{
	public PZApodPage()
	{
        InitializeComponent();
        BindingContext = new PZApodViewModel();

    }
}