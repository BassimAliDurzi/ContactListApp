using Business.Dtos;
using Business.Interfaces;
using Business.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace ContactListMainApp.ViewModels;

public partial class ContactEditViewModel(IContactService contactService, IServiceProvider serviceProvider) : ObservableObject
{

    private readonly IServiceProvider _serviceProvider = serviceProvider;
    private readonly IContactService _contactService = contactService;


    [ObservableProperty]
    private Contact _contact = new();


    [RelayCommand]
    private void Save()
    {
        var result = _contactService.Update(Contact);
        if (result)
        {
            var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
            mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<ContactsListViewModel>();
        }
    }


    [RelayCommand]
    private void Cancel()
    {
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<ContactsListViewModel>();
    }
}
