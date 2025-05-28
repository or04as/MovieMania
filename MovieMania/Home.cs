using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMania
{
    public partial class Home : Form
    {
        //List<List<string>> movieList = new List<List<string>>() { new List<string>() { } }; // List to store movie data

        public Home()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tcOptions.SelectedIndex = 0; // Switch to Home tab
            btnBrowse.ForeColor = Color.FromArgb(208, 217, 222); // Reset Browse button color
            btnRentals.ForeColor = Color.FromArgb(208, 217, 222); // Reset Rentals button color
            btnStatistics.ForeColor = Color.FromArgb(208, 217, 222); // Reset Statistics button color
            btnHome.ForeColor = Color.FromArgb(131, 186, 230); // Highlight Home button
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            tcOptions.SelectedIndex = 1; // Switch to Browse tab
            btnHome.ForeColor = Color.FromArgb(208, 217, 222); // Reset Home button color
            btnRentals.ForeColor = Color.FromArgb(208, 217, 222); // Reset Rentals button color
            btnStatistics.ForeColor = Color.FromArgb(208, 217, 222); // Reset Statistics button color
            btnBrowse.ForeColor = Color.FromArgb(131, 186, 230); // Highlight Browse button
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            tcOptions.SelectedIndex = 2; // Switch to Rentals tab
            btnHome.ForeColor = Color.FromArgb(208, 217, 222); // Reset Home button color
            btnBrowse.ForeColor = Color.FromArgb(208, 217, 222); // Reset Browse button color   
            btnStatistics.ForeColor = Color.FromArgb(208, 217, 222); // Reset Statistics button color
            btnRentals.ForeColor = Color.FromArgb(131, 186, 230); // Highlight Rentals button
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            tcOptions.SelectedIndex = 3; // Switch to Statistics tab
            btnHome.ForeColor = Color.FromArgb(208, 217, 222); // Reset Home button color
            btnBrowse.ForeColor = Color.FromArgb(208, 217, 222); // Reset Browse button color
            btnRentals.ForeColor = Color.FromArgb(208, 217, 222); // Reset Rentals button color
            btnStatistics.ForeColor = Color.FromArgb(131, 186, 230); // Highlight Statistics button
        }

        private void ShowRentalDialog(object sender, EventArgs e)
        {
            Rental rentalForm = new Rental();
            rentalForm.ShowDialog(); // Open Rental form as a dialog
        }
    }
}
