using Avalonia.Rendering;
using HidApi;
using ReactiveUI;
using System.Threading;
using System.Threading.Tasks;
using viax_avalonia.Backend;

namespace viax_avalonia.ViewModels;

public class StartupViewModel : ViewModelBase
{
    public string _greeting = "Searching for devices...";
    public string Greeting
    {
        get => _greeting;
        set => this.RaiseAndSetIfChanged(ref _greeting, value);
    }

    public StartupViewModel()
    {
        Hid.Init();
        HIDcheck hidCheck = new HIDcheck();
        foreach (DeviceInfo deviceInfo in Hid.Enumerate())
        {
            using var device = deviceInfo.ConnectToDevice();
            if (hidCheck.GetProtocolType(device.GetDeviceInfo()) == ProtocolName.VIA)
            {
                System.Diagnostics.Debug.WriteLine("Found a VIA device");
                //System.Diagnostics.Debug.WriteLine(device.GetManufacturer());
                //System.Diagnostics.Debug.WriteLine(" ");
                //System.Diagnostics.Debug.Write(device.GetDeviceInfo());
            }
        }
        Hid.Exit();

        Greeting = "complete";
    }
}
