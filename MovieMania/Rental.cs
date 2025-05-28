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
    public partial class Rental : Form
    {
        List<List<string>> customers = new List<List<string>>() // List to store customer data
        {
            new List<string>() { "1", "Jane", "Smith" },
            new List<string>() { "2", "John", "Doe" },
            new List<string>() { "3", "Alice", "Johnson" },
            new List<string>() { "4", "Bob", "Williams" },
            new List<string>() { "5", "Emily", "Brown" },
            new List<string>() { "6", "Michael", "Davis" },
            new List<string>() { "7", "Sarah", "Miller" },
            new List<string>() { "8", "David", "Wilson" },
            new List<string>() { "9", "Laura", "Moore" },
            new List<string>() { "10", "Chris", "Taylor" }
        }; 

        public Rental()
        {
            InitializeComponent();

            //Populates collection for autocomplete in the search box with customers from list
            AutoCompleteStringCollection customerAutoComplete = new AutoCompleteStringCollection();
            foreach (List<string> customer in customers)
            {
                customerAutoComplete.Add($"{customer[1]} {customer[2]}");
            }

            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = customerAutoComplete;

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer("Add");
            customer.ShowDialog(); // Open Customer form as a dialog
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Clear the search box when it is focused
        }
    }
}
