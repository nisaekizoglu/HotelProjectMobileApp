using HotelProjectMobileApp.Maui.ViewModels;

namespace HotelProjectMobileApp.Maui.Views;

public partial class EventPage : ContentPage
{
	public EventPage(EventViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}