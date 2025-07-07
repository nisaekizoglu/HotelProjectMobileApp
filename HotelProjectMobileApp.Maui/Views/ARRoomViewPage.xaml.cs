using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace HotelProjectMobileApp.Maui.Views;

public partial class ARRoomViewPage : ContentPage, IQueryAttributable
{
    private double _imageRotation = 0;
    private double _imageScale = 1;
    private string _roomType = "sea";
    private bool _disposed = false;

    public double ImageRotation
    {
        get => _imageRotation;
        set
        {
            _imageRotation = value;
            OnPropertyChanged(nameof(ImageRotation));
        }
    }

    public double ImageScale
    {
        get => _imageScale;
        set
        {
            _imageScale = value;
            OnPropertyChanged(nameof(ImageScale));
        }
    }

    public ARRoomViewPage(string roomType)
    {
        InitializeComponent();
        BindingContext = this;
        _roomType = roomType;
        if (_roomType == "mountain")
        {
            arImage.Source = "dagmanzara.jpg";
            roomInfoLabel.Text = "Dağ Manzaralı Oda";
        }
        else if (_roomType == "sea")
        {
            arImage.Source = "denizoda.jpg";
            roomInfoLabel.Text = "Deniz Manzaralı Oda";
        }
        else if (_roomType == "suite")
        {
            arImage.Source = "suitoda.jpg";
            roomInfoLabel.Text = "Suit Oda";
        }
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (_disposed || arImage == null || roomInfoLabel == null)
            return;

        if (query.TryGetValue("roomType", out var value))
        {
            _roomType = value as string ?? "sea";
            if (_roomType == "mountain")
            {
                arImage.Source = "dagmanzara.jpg";
                roomInfoLabel.Text = "Dağ Manzaralı Oda";
            }
            else if (_roomType == "sea")
            {
                arImage.Source = "denizoda.jpg";
                roomInfoLabel.Text = "Deniz Manzaralı Oda";
            }
            else if (_roomType == "suite")
            {
                arImage.Source = "suitoda.jpg";
                roomInfoLabel.Text = "Suit Oda";
            }
        }
    }

    private void OnRotateClicked(object sender, EventArgs e)
    {
        ImageRotation += 90;
    }

    private void OnZoomInClicked(object sender, EventArgs e)
    {
        ImageScale = Math.Min(ImageScale * 1.2, 3.0);
    }

    private void OnZoomOutClicked(object sender, EventArgs e)
    {
        ImageScale = Math.Max(ImageScale / 1.2, 0.5);
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        try
        {
            BindingContext = null;
            await Shell.Current.GoToAsync("///HomePage", true);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Hata", $"Geri dönülemedi: {ex.Message}", "Tamam");
        }
    }

    private void OnBedClicked(object sender, EventArgs e)
    {
        // Yatak butonuna tıklanınca yapılacaklar
    }

    private void OnTableClicked(object sender, EventArgs e)
    {
        // Masa butonuna tıklanınca yapılacaklar
    }

    private void OnSofaClicked(object sender, EventArgs e)
    {
        // Koltuk butonuna tıklanınca yapılacaklar
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _disposed = true;
        BindingContext = null;
    }

    private void UpdateImage()
    {
        if (_disposed || arImage == null || !arImage.IsVisible)
            return;
        // Görsel güncelleme işlemleri burada
    }
} 
