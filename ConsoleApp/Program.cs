using Business.Interfaces;
using Business.Services;
using ConsoleApp.Dialogs;
using Microsoft.Extensions.DependencyInjection;



var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IFileService>(new FileService(@"C:\Users\bassi\OneDrive\Desktop", "contacts.json"));
serviceCollection.AddSingleton<IContactService, ContactService>();
serviceCollection.AddSingleton<MenuDialogs>();

var serviceProvider = serviceCollection.BuildServiceProvider();
var menuDialogs = serviceProvider.GetRequiredService<MenuDialogs>();
menuDialogs.MainMenu();