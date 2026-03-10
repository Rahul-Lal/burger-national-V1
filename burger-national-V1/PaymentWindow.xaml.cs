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
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        private double amountOwed;
        private readonly Homepage _home;

        public PaymentWindow(Homepage home, double total)
        {
            InitializeComponent();
            _home = home;
            amountOwed = total;
            txtTotalPrice.Text = amountOwed.ToString("0.00");
        }

        private void clearOutput()
        {
            _home.txtOutput.Text = "";
            _home.txtPrices.Text = "";
            _home.total = 0.0;
            _home.subTotal = 0.0;
            _home.GST = 0.0;
            _home.txtSubTotal.Text = _home.subTotal.ToString("C");
            _home.txtGST.Text = _home.GST.ToString("C");
            _home.txtTotal.Text = _home.total.ToString("C");
        }

        private void btnExactAmount_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(amountOwed);
        }

        private void ApplyPayment(double amount)
        {
            if (amount <= 0)
                return;

            amountOwed -= amount;

            if (amountOwed > 0)
            {
                // Still money left to pay
                txtTotalPrice.Text = amountOwed.ToString("0.00");
                
            }
            else
            {
                // Payment complete (or overpaid)
                double change = Math.Abs(amountOwed);

                MessageBox.Show($"Payment Complete. Change: ${change:0.00}");

                amountOwed = 0;
                txtTotalPrice.Text = "0.00";

                clearOutput();
                this.Close();
            }
        }

        private void btnCash_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtCash.Text, out double cashInput))
            {
                MessageBox.Show("Invalid cash amount.");
                return;
            }

            ApplyPayment(cashInput);
        }

        private void btnFiveDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(5);
        }

        private void btnTenDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(10);
        }

        private void btnTwentyDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(20);
        }

        private void btnFiftyDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(50);
        }

        private void btnHundredDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(100);
        }

        private void btnEftpos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("EFTPOS Accepted!");
            ApplyPayment(amountOwed);
        }

    }
}
