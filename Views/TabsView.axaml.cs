using Avalonia.Controls;
using FluentAvalonia.Core;
using FluentAvalonia.UI.Controls;
using viax_avalonia.ViewModels;
using System;

namespace viax_avalonia.Views;

public partial class TabsView : UserControl
{
    public TabsView()
    {
        InitializeComponent();

        NavPanel.SelectionChanged += NavPanelOnSelectionChanged;
        NavPanel.SelectedItem = NavPanel.MenuItems.ElementAt(0);
    }

    private void NavPanelOnSelectionChanged(object sender, NavigationViewSelectionChangedEventArgs e)
    {
        if (e.SelectedItem is NavigationViewItem navItem && navItem.Tag is not null)
        {
            System.Diagnostics.Debug.WriteLine(navItem.Tag.ToString());
            switch (navItem.Tag.ToString())
            {
                case "SettingsPage":
                    NavPanel.Content = new SettingsView();
                    break;
                case "ConfigurePage":
                    NavPanel.Content = new SettingsView();
                    break;
                case "TesterPage":
                    NavPanel.Content = new SettingsView();
                    break;
            }
        }
    }
}
