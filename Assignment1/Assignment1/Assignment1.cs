using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Assignment1
 * 
 * This program takes user input to calculate an employees sales bonus. For every dollar the store makes
 * in a	four-week period, the employees	receive	2 percent of sales.	The amount	of bonus each employee 
 * receives	is based upon the percentage of hours he or she worked during the bonus	period (a total	of
 * 160 hours).
 * 
 * @author      Jean-Luc Desroches
 * @version     09/10/13
 */
namespace Assignment1
{
    public partial class employeeEarnings : Form
    {
        // initialize the percent that the employee earns from sales and total hours of the store
        private const double PERCENT_SHARED = 0.02; // this is the percent, in decimal format, that the employee earns from the sale
        private const int STORE_HOURS       = 160; // this is the total number of hours the store was open during the sale

        // Initialise error messages for english
        private const string ENG_TOTALHOURS_ERROR = "Error, total hours must be a numeric value, between 0 and 160";
        private const string ENG_TOTALSALES_ERROR = "Error, total hours must be a numeric value, and greater than 0";

        // Initialise error messages for french
        private const string FR_TOTALHOURS_ERROR = "Erreur, le total des heures doit être une valeur numérique entre 0 et 160";
        private const string FR_TOTALSALES_ERROR = "Erreur, le total des heures doit être une valeur numérique, et supérieur à 0";

        // declare variables            
        private double hoursWorked, monthlySales, saleBonus;
        
        public employeeEarnings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set focus on the first name box
            firstName.Focus();
        }
        
        private void englishButton_CheckedChanged(object sender, EventArgs e)
        {
            // Convert labels and button texts to english
            employNameLabel.Text    = "Employee Name";
            firstNameLabel.Text     = "First Name";
            lastNameLabel.Text      = "Last Name";
            employeeIDLabel.Text    = "Employee ID #";
            hoursWorkedLabel.Text   = "Total Hours Worked";
            totalSalesLabel.Text    = "Store's Total Sales";
            salesBonusLabel.Text    = "Employee Sales Bonus";
            printButton.Text        = "Print";
            calculateButton.Text    = "Calculate";
            nextButton.Text         = "Next";
            languageSelection.Text  = "Languages";

            // Convert decimal formats in salesBonus container if not empty
            if (salesBonus.Text != "")
            {
                calculateButton.PerformClick();
            }
        }

        private void frenchButton_CheckedChanged(object sender, EventArgs e)
        {
            // Convert labels and button texts to french
            employNameLabel.Text    = "Nom de l'Employé";
            firstNameLabel.Text     = "Prénom";
            lastNameLabel.Text      = "Nom de Famille";
            employeeIDLabel.Text    = "Identification du Salarié";
            hoursWorkedLabel.Text   = "Total des heures travaillées";
            totalSalesLabel.Text    = "Total des Ventes du Magasin";
            salesBonusLabel.Text    = "Employé Bonus Ventes";
            printButton.Text        = "S'imprimer";
            calculateButton.Text    = "Calculer";
            nextButton.Text         = "Suivant";
            languageSelection.Text  = "Langues";
            
            // Convert decimal formats in salesBonus container if not empty
            if (salesBonus.Text != "")
            {
                calculateButton.PerformClick();
            }
        }
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // check data in text fields, if validation fails, output error and exit function
            if (!validateData(totalHours.Text))
            {
                // set error text to appropriate language, based on selected language
                errorBox.Text = (englishButton.Checked ? ENG_TOTALHOURS_ERROR : FR_TOTALHOURS_ERROR);
                return;
            }
            else
            {
                hoursWorked = double.Parse(totalHours.Text.Trim());
                if (hoursWorked > 160 || hoursWorked < 0)
                {
                    // set error text to appropriate language, based on selected language
                    errorBox.Text = (englishButton.Checked ? ENG_TOTALHOURS_ERROR : FR_TOTALHOURS_ERROR);
                    return;
                }
            }// end of total sales checks

            if (!validateData(totalSales.Text))
            {
                // set error text to appropriate language, based on selected language
                errorBox.Text = (englishButton.Checked ? ENG_TOTALSALES_ERROR : FR_TOTALSALES_ERROR);
                return;
            }
            else
            {
                monthlySales = double.Parse(totalSales.Text.Trim());
                if(monthlySales < 0)
                {
                    // set error text to appropriate language, based on selected language
                    errorBox.Text = (englishButton.Checked ? ENG_TOTALSALES_ERROR : FR_TOTALSALES_ERROR);
                    return;
                }
            }
            
            // clearErrorBox out errors
            clearErrorBox();

            // calculate the sales bonus with provided data
            saleBonus = (hoursWorked / STORE_HOURS) * (monthlySales * PERCENT_SHARED);

            // Output results, format the decimal appropriately for the specified language
            if (englishButton.Checked)
            {
                salesBonus.Text = "$" + saleBonus.ToString("N", System.Globalization.CultureInfo.CreateSpecificCulture("en-CA"));
            }
            else
            {
                salesBonus.Text = "$" + saleBonus.ToString("N", System.Globalization.CultureInfo.CreateSpecificCulture("fr-CA"));
            }// end of if
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // Clear all input and output boxes and set focus on the firstName field
            firstName.Clear();
            lastName.Clear();
            employeeID.Clear();
            totalHours.Clear();
            salesBonus.Clear();

            // clearErrorBox out errors
            clearErrorBox();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // print with print preview the form
            printForm.Print();
        }

        private void clearErrorBox()
        {
            // Clear and hide the error box
            errorBox.Clear();
            errorBox.Visible = false;
        }

        private bool validateData(string data)
        {
            double tempVar;
            /*
             * Try and convert the text field to a double format, triming whitespace from the string, if it fails, or if the value is less than 0 
             * or greater than the total store hours, output error message in selected language and clear the field
             */
            if (!double.TryParse(data.Trim(), out tempVar))
            {
                return false; // exit click function
            }// end of if
            
            return true;
        }

        private void convertSalesToCurrency()
        {
            // check input data
            if (!validateData(totalSales.Text))
            {                
                errorBox.Text = englishButton.Checked ? ENG_TOTALHOURS_ERROR : FR_TOTALHOURS_ERROR;
                errorBox.Visible = true;
                totalSales.Clear();
                return;
            }

            // get the data in the text field of total store sales
            double tempSales = double.Parse(totalSales.Text.Trim());

            // Output results, format the decimal appropriately for the specified language
            if (englishButton.Checked)
            {                
                totalSales.Text = "$" + tempSales.ToString("N", System.Globalization.CultureInfo.CreateSpecificCulture("en-CA"));
            }
            else
            {
                totalSales.Text = "$" + tempSales.ToString("N", System.Globalization.CultureInfo.CreateSpecificCulture("fr-CA"));
            }// end of if
        }
    }
}
