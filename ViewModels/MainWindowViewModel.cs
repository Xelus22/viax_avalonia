using Avalonia.Rendering;
using HidApi;
using ReactiveUI;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using viax_avalonia.Backend;

namespace viax_avalonia.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;
    public MainWindowViewModel()
    {
        StartupView = new StartupViewModel();
        _contentViewModel = StartupView;
        // subscribe to the Greeting property of the startupView
        System.Diagnostics.Debug.WriteLine("Startup View Model set");

        // subscribe to the Greeting property of the startupView
        StartupView.WhenAnyValue(x => x.Greeting).Subscribe(async x =>
        {
            System.Diagnostics.Debug.WriteLine("Greeting changed to: " + x);
            if (x == "complete")
            {
                // delay by 2 seconds
                await Task.Delay(500);
                GoToTabView();
            }
        });
    }

    public StartupViewModel StartupView { get; }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public void GoToTabView()
    {
        System.Diagnostics.Debug.WriteLine("Switching to TabView");
        ContentViewModel = new TabsViewModel();
    }
}
