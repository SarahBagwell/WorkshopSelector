// Programmer: S. Bagwell
// Class: CIS 3000 OL1 Summer 2023
/* Program Purpose: Displays the registration cost, lodging cost,
and total cost for a workshop based on type and location. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopSelector_BagwellS
{
    public partial class Form1 : Form
    {

        // To hold variables
        double numberOfDays;
        double pricePerDay;
        double registrationFee;
        double lodgingCost;
        double totalCost;
        string selectedLocation;
        string selectedWorkshop;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {

            /* Determine the workshop selected with associated
               registration fee and number of days */
            if (typeOfWorkshopListBox.SelectedIndex != -1)
            {
                selectedWorkshop = typeOfWorkshopListBox.SelectedItem.ToString();

                    switch (selectedWorkshop)
                    {
                        case "Handling Stress\t3 days\t$1,000":
                            registrationCostOutputLabel.Text = "REGISTRATION: $1,000";
                            numberOfDays = 3;
                            registrationFee = 1000;
                            break;

                        case "Time Management\t3 days\t$800":
                            registrationCostOutputLabel.Text = "REGISTRATION: $800";
                            numberOfDays = 3;
                            registrationFee = 800;
                            break;

                        case "Supervision Skills\t3 days\t$1,500":
                            registrationCostOutputLabel.Text = "REGISTRATION: $1,500";
                            numberOfDays = 3;
                            registrationFee = 1500;
                            break;

                        case "Negotiation\t5 days\t$1,300":
                            registrationCostOutputLabel.Text = "REGISTRATION: $1,300";
                            numberOfDays = 5;
                            registrationFee = 1300;
                            break;

                        case "How to Interview\t1 days\t$500":
                            registrationCostOutputLabel.Text = "REGISTRATION: $500";
                            numberOfDays = 1;
                            registrationFee = 500;
                            break;

                    }
            }

            else
            {
                /* If no workshop was selected, prompt the user to
                make a selection */
                MessageBox.Show("Select a workshop to calculate cost.");
            }

            // Determine the location selected with associated lodging cost
            if (workshopLocationListBox.SelectedIndex != -1)
            {
                selectedLocation = workshopLocationListBox.SelectedItem.ToString();

                    switch (selectedLocation)
                    {
                        case "Austin\t$150":
                            pricePerDay = 150;
                            break;

                        case "Chicago\t$225":
                            pricePerDay = 225;
                            break;

                        case "Dallas\t$175":
                            pricePerDay = 175;
                            break;

                        case "Orlando\t$300":
                            pricePerDay = 300;
                            break;

                        case "Phoenix\t$175":
                            pricePerDay = 175;
                            break;

                        case "Raleigh\t$150":
                            pricePerDay = 150;
                            break;
                    }
            }

            else
            {

                /* If no location was selected, prompt the user to
                make a selection */
                MessageBox.Show("Select a location to calculate cost.");
            }

            // Calculate the lodging cost and display in lodgingCostOutputLabel
                lodgingCost = numberOfDays * pricePerDay;
                lodgingCostOutputLabel.Text = "LODGING: " + lodgingCost.ToString("c");

            // Calculate the total cost and display in totalCostOutputLabel
                totalCost = registrationFee + lodgingCost;
                totalCostOutputLabel.Text = "TOTAL: " + totalCost.ToString("c");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the form
                registrationCostOutputLabel.Text = "";
                lodgingCostOutputLabel.Text = "";
                totalCostOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}