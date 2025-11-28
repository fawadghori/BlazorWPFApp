using Microsoft.AspNetCore.Components.WebView.Wpf;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BlazorWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();

            #if DEBUG
            serviceCollection.AddBlazorWebViewDeveloperTools();
            #endif

            // Set services to the BlazorWebView
            blazorWebView.Services = serviceCollection.BuildServiceProvider();
        }
    }
}