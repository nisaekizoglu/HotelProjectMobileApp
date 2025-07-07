namespace HotelProjectMobileApp.Maui.Views;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class ReservationPage : ContentPage
{
	public ReservationPage()
	{
		InitializeComponent();
		entryCheckIn.MinimumDate = DateTime.Today;
		entryCheckOut.MinimumDate = DateTime.Today;
	}

	private void OnCalculateClicked(object sender, EventArgs e)
	{
		// Giriş ve çıkış tarihleriyle gece sayısı hesapla
		var checkIn = entryCheckIn.Date;
		var checkOut = entryCheckOut.Date;
		int pricePerNight = 2500;
		int totalNights = (int)(checkOut - checkIn).TotalDays;
		if (string.IsNullOrWhiteSpace(entryName.Text) || string.IsNullOrWhiteSpace(entrySurname.Text) ||
			string.IsNullOrWhiteSpace(entryPhone.Text) || totalNights <= 0)
		{
			labelResult.Text = "Lütfen tüm alanları doğru doldurun ve geçerli tarih seçin.";
			labelResult.TextColor = Colors.DarkRed;
			return;
		}
		int total = totalNights * pricePerNight;
		labelResult.Text = $"Toplam Ücret: {total} TL ({totalNights} gece)";
		labelResult.TextColor = Colors.DarkRed;
	}

	private async void OnReservationClicked(object sender, EventArgs e)
	{
		// Hesaplanan ücreti ve diğer bilgileri al
		var checkIn = entryCheckIn.Date;
		var checkOut = entryCheckOut.Date;
		int pricePerNight = 2500;
		int totalNights = (int)(checkOut - checkIn).TotalDays;
		int total = totalNights * pricePerNight;
		string room = roomPicker.SelectedItem?.ToString() ?? "";

		// Tarih ve oda çakışma kontrolü
		bool isConflict = ReservationStore.Reservations.Any(r =>
			r.Room == room &&
			((checkIn < r.CheckOut) && (checkOut > r.CheckIn))
		);
		if (isConflict)
		{
			await DisplayAlert("Uyarı", "Bu tarihlerde seçilen oda için rezervasyon yapılamaz.", "Tamam");
			return;
		}

		ReservationStore.Reservations.Add(new ReservationInfo
		{
			Name = entryName.Text,
			Surname = entrySurname.Text,
			Phone = entryPhone.Text,
			Room = room,
			CheckIn = checkIn,
			CheckOut = checkOut,
			TotalPrice = total
		});

		await DisplayAlert("Başarılı", "Rezervasyon başarıyla oluşturuldu!", "Tamam");
	}
}

public class ReservationInfo
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public string Phone { get; set; }
	public string Room { get; set; }
	public DateTime CheckIn { get; set; }
	public DateTime CheckOut { get; set; }
	public int TotalPrice { get; set; }
}

public static class ReservationStore
{
	public static List<ReservationInfo> Reservations { get; } = new();
}