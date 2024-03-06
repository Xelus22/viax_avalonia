using Avalonia.Rendering;
using HidApi;
using ReactiveUI;
using System.Threading;
using System.Threading.Tasks;
using viax_avalonia.Backend;

namespace viax_avalonia.ViewModels
{
    public class TabsViewModel : ViewModelBase
    {
        public string _greeting = "TabsView Model";
        public string Greeting
        {
            get => _greeting;
            set => this.RaiseAndSetIfChanged(ref _greeting, value);
        }

        object content = new SettingsViewModel();
        public object Content
        {
            get => content;
            set => this.RaiseAndSetIfChanged(ref content, value);
        }
        public TabsViewModel()
        { 
            content = new SettingsViewModel();
        }
    }
}
