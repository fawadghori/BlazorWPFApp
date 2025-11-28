//using System.Text;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace BlazorWPFApp
//{
//    /// <summary>
//    /// Interaction logic for MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();
//        }
//    }
//}


//using Microsoft.Extensions.DependencyInjection;
//using System.Windows;
//using Microsoft.AspNetCore.Components.WebView.Wpf;

//namespace BlazorWPFApp
//{
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            //InitializeComponent();

//            var serviceCollection = new ServiceCollection();
//            serviceCollection.AddWpfBlazorWebView();
//#if DEBUG
//            serviceCollection.AddBlazorWebViewDeveloperTools();
//#endif

//            Resources.Add("services", serviceCollection.BuildServiceProvider());
//        }
//    }
//}

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