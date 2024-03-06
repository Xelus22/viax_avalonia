using Avalonia.Rendering;
using HidApi;
using ReactiveUI;
using System.Threading;
using System.Threading.Tasks;
using viax_avalonia.Backend;

namespace viax_avalonia.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public string _greeting = "Searching for devices...";
        public string Greeting
        {
            get => _greeting;
            set => this.RaiseAndSetIfChanged(ref _greeting, value);
        }

        public SettingsViewModel()
        {
        }
    }

}

