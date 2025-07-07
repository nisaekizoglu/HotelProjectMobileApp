namespace HotelProjectMobileApp.Maui.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

	private async void OnRegisterClicked(object sender, EventArgs e)
	{
		labelRegisterResult.Text = "Kayıt başarılı! Giriş yapabilirsiniz.";
		labelRegisterResult.TextColor = Colors.DarkRed;
	}

	private async void OnLoginClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//LoginPage");
	}
}