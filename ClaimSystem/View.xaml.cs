using System.Collections.Generic;
using System.Windows;

namespace ClaimSystem
{
    public partial class View : Window
    {
        public View(List<Claim> claims)
        {
            InitializeComponent();

            // Bind the claims data to the controls
            if (claims.Count > 0)
            {
                // Assuming we want to show the first claim for now
                var firstClaim = claims[0];
                ClaimDescriptionTextBlock.Text = firstClaim.Description;
                ClaimDateTextBlock.Text = firstClaim.Date;
            }
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
