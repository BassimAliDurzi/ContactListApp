using System.Configuration;
using System.Data;
using System.Windows;
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
                services.AddSingleton<MainViewModel>();
                services.AddSingleton<MainWindow>();

                services.AddSingleton<ContactsViewModel>();
                services.AddSingleton<ContactsView>();

                services.AddSingleton<AddContactViewModel>();
                services.AddSingleton<AddContactView>();
            })
            .Build();
    }

    protected override void  OnStartup(StartupEventArgs e)
    {
        var mainWindow = _host.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}
