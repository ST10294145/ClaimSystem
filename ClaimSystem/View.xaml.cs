using System.Collections.Generic;
using System.Windows;

namespace ClaimSystem
{
    public partial class View : Window
    {
        public View()
        {
        }

        public View(List<Claim> claims)
        {
            InitializeComponent();

            // Bind the claims data to the ListBox
            ClaimsListBox.ItemsSource = claims;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the window when the button is clicked
            this.Close();
        }
    }

    // Model class for Claim
    public class Claim
    {
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
