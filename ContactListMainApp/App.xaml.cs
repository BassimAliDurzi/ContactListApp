﻿using System.Configuration;
using System.Data;
using System.Windows;
using Business.Interfaces;
using Business.Services;
using ContactListMainApp.ViewModels;
using ContactListMainApp.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ContactListMainApp;


public partial class App : Application
{
    private IHost _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<IFileService>(new FileService(@"C:\Users\bassi\OneDrive\Desktop", "contacts.json"));
                services.AddSingleton<IContactService, ContactService>();

                

                services.AddTransient<ContactsListViewModel>();
                services.AddTransient<ContactAddViewModel>();
                services.AddTransient<ContactDetailsViewModel>();
                services.AddTransient<ContactEditViewModel>();

                services.AddTransient<ContactsView>();
                services.AddTransient<AddContactView>();
                services.AddTransient<ContactDetailsView>();
                services.AddTransient<ContactEditView>();

                services.AddSingleton<MainViewModel>();
                services.AddSingleton<MainWindow>();
            })
            .Build();
    }

    protected override void  OnStartup(StartupEventArgs e)
    {
        var mainViewModel = _host.Services.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _host.Services.GetRequiredService<ContactsListViewModel>();

        var mainWindow = _host.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}
