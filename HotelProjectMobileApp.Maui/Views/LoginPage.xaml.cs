namespace HotelProjectMobileApp.Maui.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void OnLoginClicked(object sender, EventArgs e)
	{
		// Basit kontrol: kullanıcı adı ve şifre boş değilse giriş başarılı
		if (!string.IsNullOrWhiteSpace(entryUsername.Text) && !string.IsNullOrWhiteSpace(entryPassword.Text))
		{
			labelLoginResult.Text = "Giriş başarılı! Yönlendiriliyorsunuz...";
			labelLoginResult.TextColor = Colors.DarkRed;
			await Task.Delay(700);
			await Shell.Current.GoToAsync("//HomePage");
		}
		else
		{
			labelLoginResult.Text = "Kullanıcı adı veya şifre hatalı.";
			labelLoginResult.TextColor = Colors.DarkRed;
		}
	}

	private async void OnRegisterClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("RegisterPage");
	}
}