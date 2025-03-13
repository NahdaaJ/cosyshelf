using CosyShelf.WPF.Pages;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CosyShelf.WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var fontFamily = (FontFamily)Application.Current.Resources["NunitoFont"];
        this.FontFamily = fontFamily;

        MainFrame.Navigate(new Homepage());
    }

    private void Home_Click(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new Homepage());
    }

    private void TBR_Click(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new TbrPage());
    }

    private void Currently_Reading_Click(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new CurrentlyReadingPage());
    }

    private void Read_Click(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new ReadPage());
    }
}