using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FmgLib.HttpClientHelper;
using HotelProjectMobileApp.Core.Models;
using HotelProjectMobileApp.Maui.Views;

namespace HotelProjectMobileApp.Maui.ViewModels;

public partial class HomeViewModel:BaseViewModel
{
    [ObservableProperty]
    private List<CategoryModel> _category;

    public HomeViewModel()
    {
        GetHomePageDetails();
    }
    private async void GetHomePageDetails()
    {
        Category = await HttpClientHelper.SendAsync<List<CategoryModel>>(App.BaseUrl + "/Category/GetAll",HttpMethod.Get);
        
    }
    [RelayCommand]
    public async Task GoToCategoryDetailPage(string categoryDetail)
    {
        CategoryDetailViewModel.CategoryRoom=int.Parse(categoryDetail);
        await Shell.Current.GoToAsync(nameof(CategoryDetailPage));
        //var category = await HttpClientHelper.SendAsync<List<CategoryDetailViewModel>>(App.BaseUrl + $"/Category/GetAllSearch/{searchText}", HttpMethod.Get);
    }
    [RelayCommand]
    public async Task GoToEventPage(int id)
    {
        EventViewModel.Id = id;
        await Shell.Current.GoToAsync(nameof(EventPage));
    }
}
