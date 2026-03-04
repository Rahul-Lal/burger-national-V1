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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace burger_national_V1
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Page
    {
        public Homepage()
        {
            InitializeComponent();
        }

        bool isDrinkSmall = false;
        bool isDrinkMedium = false;
        bool isDrinkLarge = false;

        public double total = 0.00;

        public void clearOutput()
        {
            txtOutput.Text = "";
            txtPrices.Text = "";
            total = 0.0;
            totalAmount(total);
        }

        private void totalAmount(double amount)
        {
            txtTotal.Text = total.ToString("C");
        }

        private void setDrinkSize()
        {
            if (isDrinkSmall)
            {
                txtOutput.Text += "Small ";
                txtPrices.Text += "$2.50\n";
                total += 2.50;
                totalAmount(total);
                isDrinkSmall = false;
            }
            else if (isDrinkMedium)
            {
                txtOutput.Text += "Medium ";
                txtPrices.Text += "$3.50\n";
                total += 3.50;
                totalAmount(total);
                isDrinkMedium = false;
            }
            else if (isDrinkLarge)
            {
                txtOutput.Text += "Large ";
                txtPrices.Text += "$4.50\n";
                total += 4.50;
                totalAmount(total);
                isDrinkLarge = false;
            }
        }

        private void multiChoiceComboDeal(string title, string burger1, string burger2, string side, string dessert, double price)
        {
            //string finalBurgerChoice = "";

            //BurgerChoiceWindow burgerChoice = new BurgerChoiceWindow();
            //burgerChoice.btnOptionOne.Content = burger1;
            //burgerChoice.btnOptionTwo.Content = burger2;
            //burgerChoice.ShowDialog();

            //if (burgerChoice.isOptionOne == true)
            //{
            //    finalBurgerChoice = burger1;
            //    burgerChoice.isOptionOne = false;
            //}
            //else if (burgerChoice.isOptionTwo == true)
            //{
            //    finalBurgerChoice = burger2;
            //    burgerChoice.isOptionTwo = false;
            //}
            //else
            //{
            //    finalBurgerChoice = burger1;
            //}

            //txtOutput.Text += title + "\n";
            //txtOutput.Text += finalBurgerChoice + "\n";
            //txtOutput.Text += side + "\n";
            //txtOutput.Text += dessert + "\n";
            //txtOutput.Text += "Small Drink\n";
            //total += price;

            //txtPrices.Text += "$" + price.ToString() + "0\n\n\n\n\n";
            //totalAmount(total);
        }

        private void comboOption(string burger, double price)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            makeCombo.ShowDialog();

            if (makeCombo.makeLarge == true)
            {
                txtOutput.Text += burger.ToUpper() + " LARGE COMBO\n" +
                    burger + " Burger \n" +
                    "Large Fries \n" +
                    "Large Drink \n";

                txtPrices.Text += "$" + (price + 7.5).ToString() + ".00\n\n\n\n";
                total += price + 7.5;
                totalAmount(total);

                makeCombo.makeLarge = false;
                makeCombo.Close();
            }
            else if (makeCombo.makeMedium == true)
            {
                txtOutput.Text += burger.ToUpper() + " MEDIUM COMBO\n" +
                    burger + " Burger \n" +
                    "Medium Fries \n" +
                    "Medium Drink \n";

                txtPrices.Text += "$" + (price + 5).ToString() + "0\n\n\n\n";
                total += price + 5;
                totalAmount(total);

                makeCombo.makeMedium = false;
                makeCombo.Close();
            }
            else if (makeCombo.makeJustBurger == true)
            {
                txtOutput.Text += burger + " Burger \n";
                txtPrices.Text += "$" + price + "0\n";
                total += price;
                totalAmount(total);

                makeCombo.makeJustBurger = false;
                makeCombo.Close();
            }
            else
            {
                makeCombo.Close();
            }
        }

        private void printMenuItem(string menuItem, double price)
        {
            txtOutput.Text += menuItem.ToString() + "\n";

            if (price % 1 != 0)
            {
                txtPrices.Text += "$" + price.ToString() + "0\n";
            }
            else
            {
                txtPrices.Text += "$" + price.ToString() + ".00\n";
            }
            total += price;
            totalAmount(total);
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClearOrder_Click(object sender, RoutedEventArgs e)
        {
            clearOutput();
        }

        private void btnSingleOlympian_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Olympian", 12.50);
        }

        private void btnDoubleOlympian_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Olympian", 14.50);
        }

        private void btnSingleParisian_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Parisian", 12.50);
        }

        private void btnDoubleParisian_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Parisian", 14.50);
        }

        private void btnSingleRoma_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Roma", 12.50);
        }

        private void btnDoubleRoma_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Roma", 14.50);
        }

        private void btnSingleMatador_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Matador", 12.50);
        }

        private void btnDoubleMatador_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Matador", 14.50);
        }

        private void btnSingleKaiser_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Kaiser", 12.50);
        }

        private void btnDoubleKaiser_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Kaiser", 14.50);
        }
    }
}
