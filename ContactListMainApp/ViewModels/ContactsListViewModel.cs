﻿using System.Collections.ObjectModel;
using Business.Interfaces;
using Business.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace ContactListMainApp.ViewModels;

public partial class ContactsListViewModel : ObservableObject
{
    private readonly IContactService _contactService;
    private readonly IServiceProvider _serviceProvider;

    [ObservableProperty]
    private ObservableCollection<Contact> _contacts = [];

    public ContactsListViewModel(IContactService contactService, IServiceProvider serviceProvider)
    {
        _contactService = contactService;
        _serviceProvider = serviceProvider;

        _contacts = new ObservableCollection<Contact>(_contactService.GetAll());
    }

    [RelayCommand]
    private void GoToAddContact()
    {
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<ContactAddViewModel>();
    }

    [RelayCommand]
    private void GoToDetailsView(Contact contact)
    {
        var contactDetailsViewModel = _serviceProvider.GetRequiredService<ContactDetailsViewModel>();
        contactDetailsViewModel.Contact = contact;


        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = contactDetailsViewModel;
    }

}
