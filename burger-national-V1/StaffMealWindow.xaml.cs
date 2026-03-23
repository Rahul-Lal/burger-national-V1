using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace burger_national_V1
{
    /// <summary>
    /// Interaction logic for StaffMealWindow.xaml
    /// </summary>
    public partial class StaffMealWindow : Window
    {
        private readonly Homepage _home;

        public StaffMealWindow(Homepage home)
        {
            InitializeComponent();
            _home = home;
        }

        private void printStaffMeal(string burger)
        {
            string chosenCombo;

            chosenCombo = burger.ToUpper() + " STAFF COMBO\n" +
                    burger + " Burger \n" +
                    "Medium Fries \n" +
                    "Medium Drink \n";

            _home.txtOutput.Text += chosenCombo;
            _home.txtPrices.Text += "$0.00";
            _home.total += 0.00;
            _home.isStaffMealSelected = true;
            this.Close();
        }

        private void btnSingleOlympian_Click(object sender, RoutedEventArgs e)
        {
            printStaffMeal("Single Olympian");
        }
    }
}
