using HotelProjectMobileApp.Maui.ViewModels;
using Microsoft.Maui.Controls;

namespace HotelProjectMobileApp.Maui.Views;

public partial class CategoryDetailPage : ContentPage, IQueryAttributable
{
	public CategoryDetailPage()
	{
		InitializeComponent();
	}

	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		if (query.TryGetValue("roomType", out var value))
		{
			string roomType = value as string;
			if (roomType == "mountain")
			{
				roomImage.Source = "dagmanzara.jpg";
				roomTitle.Text = "Dağ Manzaralı Oda";
				roomDesc.Text = "Dağ manzaralı odada huzurlu bir tatil sizi bekliyor. Doğayla iç içe, ferah ve konforlu bir ortam.";
				roomPrice.Text = "2500 TL / Tek Gece";
				roomCapacity.Text = "2 Kişi";
			}
			else if (roomType == "sea")
			{
				roomImage.Source = "denizoda.jpg";
				roomTitle.Text = "Deniz Manzaralı Oda";
				roomDesc.Text = "Geniş ve ferah deniz manzaralı odamızda huzurlu bir tatil sizi bekliyor. Modern dekorasyon ve konfor bir arada.";
				roomPrice.Text = "2500 TL / Tek Gece";
				roomCapacity.Text = "2 Kişi";
			}
			else if (roomType == "suite")
			{
				roomImage.Source = "suitoda.jpg";
				roomTitle.Text = "Suit Oda";
				roomDesc.Text = "Lüks ve konforlu suit odamızda ayrıcalıklı bir tatil deneyimi yaşayın. Geniş yaşam alanı ve özel hizmetler.";
				roomPrice.Text = "2500 TL / Tek Gece";
				roomCapacity.Text = "4 Kişi";
			}
		}
	}

	private async void OnARButtonClicked(object sender, EventArgs e)
	{
		string roomType = "sea"; // Varsayılan
		
		// Oda tipini belirle
		if (roomTitle.Text.Contains("Dağ"))
			roomType = "mountain";
		else if (roomTitle.Text.Contains("Deniz"))
			roomType = "sea";
		else if (roomTitle.Text.Contains("Suit"))
			roomType = "suite";
		
		await Navigation.PushAsync(new ARRoomViewPage(roomType));
	}

	private async void OnReservationButtonClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("ReservationPage");
	}
}