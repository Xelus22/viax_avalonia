using Avalonia;
using Avalonia.Controls;

namespace viax_avalonia.Views;

public partial class MainWindowView : Window
{
    public MainWindowView()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }
}
