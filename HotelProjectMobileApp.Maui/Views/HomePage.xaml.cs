using HotelProjectMobileApp.Maui.ViewModels;

namespace HotelProjectMobileApp.Maui.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomeViewModel();
    }

    private async void OnMountainRoomTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"CategoryDetailPage?roomType=mountain");
    }
    private async void OnSeaRoomTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"CategoryDetailPage?roomType=sea");
    }
    private async void OnSuiteRoomTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"CategoryDetailPage?roomType=suite");
    }
    private async void OnHomeTitleTapped(object sender, EventArgs e)
    {
        if (Shell.Current.CurrentPage is HotelProjectMobileApp.Maui.Views.HomePage)
            return;
        await Shell.Current.GoToAsync("///HomePage");
    }
}