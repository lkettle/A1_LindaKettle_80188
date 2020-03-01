using System;
using System.Windows.Forms;

/// <remarks>
/// BONUS CALCULATOR: by Linda Kettle, Feb.11/20
/// Takes employee name, id and saves for printing
/// Takes employee hours worked in 4 week period & store sales in 4 week period
/// Program calculates a 2% bonus of 4 week store sales * employeeHours/160.
/// User has choice of English, French and Portuguese.
/// </remarks>

namespace A1_LindaKettle_80188
{
    public partial class Form_BonusCalculator : Form
    {
        // constant values
        private const double PERCENT = 0.02;
        private const int HOURS = 160;

        // class variables
        private string employeeName;
        private string employeeID;
        private double employeeHours = 0.0;
        private double storeSales = 0.0;
        private double bonusResult;
        private string printMessage;
        private string errorCaption = "Entry Error";

        public Form_BonusCalculator() { InitializeComponent(); }

        private void Form_BonusCalculator_Load(object sender, EventArgs e)
        {
            // Creating the RadioButton for English on form load
            // the CheckChanged fxn doesn't work on load 

            RadioButton rb_english = sender as RadioButton;
            this.Controls.Add(rb_english);
            ClearForm();
        }

        // CUSTOM METHODS 

        // calculates bonus from employeeHours & storeSales input
        private void CalculateBonus()
        {
            employeeHours = CheckHours(txt_hours.Text);
            storeSales = CheckSales(txt_storeSales.Text);
            // bonus = (employeeHours/160)*(storeSales*2%)
            bonusResult = employeeHours * storeSales * PERCENT / HOURS;
            txt_bonusResult.Text = bonusResult.ToString("C");
        }

        // prints input & output to message box
        private void PrintInfo()
        {
            CalculateBonus();
            string my_caption = "Bonus Info To Print/Imprimer/Imprimir";
            employeeName = txt_name.Text;
            employeeID = txt_ID.Text;
            printMessage = $"Employee:\t{employeeName}\nID:\t\t{employeeID}\nHours:\t\t{employeeHours}\nStore Sales:\t${storeSales}\nBonus:\t\t${bonusResult}";
            MessageBox.Show(printMessage, my_caption);
        }

        // resets form to default values
        private void ClearForm()
        {
            txt_name.Clear();
            txt_ID.Clear();
            txt_hours.Clear();
            //txt_storeSales.Clear();
            txt_bonusResult.Clear();
        }

        // check hours are 0 - 160
        public double CheckHours(string userInput)
        {
            try
            {
                employeeHours = Convert.ToDouble(userInput);
            }
            catch
            {
                MessageBox.Show("Incorrect Entry in Hours, must enter a number.", errorCaption);
            }

            if (employeeHours >= 0.0 && employeeHours <= 160.0)
            {
                return employeeHours;
            }
            else
            {
                MessageBox.Show("Incorrect Entry in Hours, please enter a number between 0 and 160.", errorCaption);
                return 0.0;
            }
        }

        // check store sales are 0+
        public double CheckSales(string userInput)
        {
            try
            {
                storeSales = Convert.ToDouble(userInput);
            }
            catch
            {
                MessageBox.Show("Incorrect Entry in Store Sales, must enter a positive number: ", errorCaption);
            }

            if (storeSales >= 0.0)
            {
                return storeSales;
            }
            else
            {
                MessageBox.Show("Incorrect Entry in Store Sales, please enter positive numbers only.", errorCaption);
                return 0.0;
            }
        }

        // BUTTONS
        private void btn_Calculate_Click(object sender, EventArgs e) { CalculateBonus(); }

        private void btn_Next_Click(object sender, EventArgs e) { ClearForm(); }

        private void btn_Print_Click(object sender, EventArgs e) { PrintInfo(); }

        // Radio Buttons to change language of labels
        private void rbtn_english_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_english.Checked)
            {
                lbl_name.Text = "Employee Name:";
                lbl_ID.Text = "Employee ID:";
                lbl_hours.Text = "Hours Worked:";
                lbl_storeSales.Text = "Store Sales:";
                lbl_bonusResult.Text = "Bonus:";
                btn_Calculate.Text = "Calculate";
                btn_Print.Text = "Print";
                btn_Clear.Text = "Clear";
                printMessage = $"Employee:\t{employeeName}\nID:\t\t{employeeHours}\nHours:\t\t{employeeHours}\nStore Sales:\t${storeSales}\nBonus:\t\t${bonusResult}";
            }
        }

        private void rbtn_french_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb_french = sender as RadioButton;

            if (rb_french.Checked)
            {
                lbl_name.Text = "Nom de l'employe(e):";
                lbl_ID.Text = "ID de l'employe(e):";
                lbl_hours.Text = "Heures travaillées:";
                lbl_storeSales.Text = "Ventes par magasin:";
                lbl_bonusResult.Text = "Bonus:";
                btn_Calculate.Text = "Calculer";
                btn_Print.Text = "Imprimer";
                btn_Clear.Text = "Suivant";
                //printMessage = $"Employe(e):\t\t{employeeName}\nID:\t\t\t{employeeID}\nHeures:\t\t\t{employeeHours}\nVentes par magasin:\t${storeSales}\nBonus:\t\t\t${bonusResult}";
            }
        }

        private void rbtn_portuguese_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb_portuguese = sender as RadioButton;

            if (rb_portuguese.Checked)
            {
                lbl_name.Text = "Nome do Empregado(a) :";
                lbl_ID.Text = "Empregado(a) ID:";
                lbl_hours.Text = "Horas Trabalhadas:";
                lbl_storeSales.Text = "Vendas de Loja:";
                lbl_bonusResult.Text = "Bonus:";
                btn_Calculate.Text = "Calcular";
                btn_Print.Text = "Imprimir";
                btn_Clear.Text = "Proximo";
                //printMessage = $"Empregado(a):\t{employeeName}\nID:\t\t{employeeID}\nHoras:\t\t{employeeHours}\nVendas de Loja:\t${storeSales}\nBonus:\t\t${bonusResult}";
            }
        }

         // are these TextChanged necessary?
        public void txt_name_TextChanged(object sender, EventArgs e) { }

        private void txt_ID_TextChanged(object sender, EventArgs e) { }

        private void txt_hours_TextChanged(object sender, EventArgs e)
            {
                //CheckHours here gets very annoying when form clears
                //CheckHours(txt_hours.Text); 
            }

        private void txt_storeSales_TextChanged(object sender, EventArgs e)
            {
                //CheckSales here gets very annoying when form clears
                //CheckSales(txt_storeSales.Text); }
            }
        
    }
}


