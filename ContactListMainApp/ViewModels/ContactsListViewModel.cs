using System.Collections.ObjectModel;
using Business.Interfaces;
using Business.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace ContactListMainApp.ViewModels;

public partial class ContactsListViewModel(IContactService contactService, IServiceProvider serviceProvider) : ObservableObject
{
    private readonly IContactService _contactService = contactService;
    private readonly IServiceProvider _serviceProvider = serviceProvider;

    [ObservableProperty]
    private ObservableCollection<Contact> _contacts = [];


    [RelayCommand]
    private void GoToAddContact()
    {
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<ContactAddViewModel>();
    }

}
