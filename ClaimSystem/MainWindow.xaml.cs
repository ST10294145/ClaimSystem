using System.Windows;

namespace ClaimSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Submit window
            Submit submitWindow = new Submit();

            // Show the Submit window
            submitWindow.Show();

            // Optionally, close the current window if you don't want to keep it open
            // this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            View viewWindow = new();
            viewWindow.Show();
        }
    }
}
