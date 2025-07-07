namespace HotelProjectMobileApp.Maui
{
    public partial class App : Application
    {
        public static string BaseUrl { get; private set; }
        public App()
        {
            BaseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5119/api" : "http://localhost:5119/api";

            InitializeComponent();

            MainPage = new AppShell();

            // Uygulama başlatıldığında LoginPage'e yönlendir
            Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
