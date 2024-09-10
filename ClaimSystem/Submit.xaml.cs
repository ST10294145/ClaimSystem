using System;
using System.Windows;

namespace ClaimSystem
{
    public partial class Submit : Window
    {
        public Submit()
        {
            InitializeComponent();
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            string description = ClaimDescriptionTextBox.Text;
            DateTime? date = ClaimDatePicker.SelectedDate;

            // Add code here to process the claim submission
            MessageBox.Show($"Claim submitted!\nDescription: {description}\nDate: {date}");
        }
    }
}
