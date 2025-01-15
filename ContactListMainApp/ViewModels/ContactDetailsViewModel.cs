using Business.Dtos;
using Business.Interfaces;
using Business.Models;
using Business.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace ContactListMainApp.ViewModels;

public partial class ContactDetailsViewModel(IServiceProvider serviceProvider, IContactService contactService) : ObservableObject
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;
    private readonly IContactService _contactService = contactService;


    [ObservableProperty]
    private Contact _contact = new();


    [RelayCommand]
    private void GoToEditView()
    {
        var contactEditViewModel = _serviceProvider.GetRequiredService<ContactEditViewModel>();
        contactEditViewModel.Contact = Contact;

        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = contactEditViewModel;
    }


    [RelayCommand]
    private void DeleteContact()
    {
        var result = _contactService.Delete(Contact);

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
