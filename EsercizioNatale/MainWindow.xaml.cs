using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EsercizioNatale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int Pari;
        int Dispari;
        private void btnON_Checked(object sender, RoutedEventArgs e)
        {
            btnON.Content = $"ON";
            txtnum1.IsEnabled = true;
            txtnum2.IsEnabled = true;
            txtnum3.IsEnabled = true;
            txtnum4.IsEnabled = true;
            txtnum5.IsEnabled = true;
            txtnum6.IsEnabled = true;
            btnCalcola.IsEnabled = true;
            btnReset.IsEnabled = true;

        }

        private void btnON_Unchecked(object sender, RoutedEventArgs e)
        {
            btnON.Content = $"OFF";
            txtnum1.IsEnabled = false;
            txtnum2.IsEnabled = false;
            txtnum3.IsEnabled = false;
            txtnum4.IsEnabled = false;
            txtnum5.IsEnabled = false;
            txtnum6.IsEnabled = false;
            btnCalcola.IsEnabled = false;
            btnReset.IsEnabled = false;
            lblRisultato.Content = "";
            lblRisultato_.Content = "";
        }
        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                int num1 = int.Parse(txtnum1.Text);
                if (num1%2==0)
                {
                    Pari++;
                    lblRisultato.Content = $"{Pari}";
                }
                else
                {
                    Dispari++;
                    lblRisultato_.Content = $"{Dispari}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si Può calcolare solo una volta; Non si puo inserire una lettere o valori diversi dai numeri,");
                txtnum1.Text = "";
            }


            try
            {


                int num2 = int.Parse(txtnum2.Text);
                if (num2%2==0)
                {
                    Pari++;
                    lblRisultato.Content = $"{Pari}";
                }
                else
                {
                    Dispari++;
                    lblRisultato_.Content = $"{Dispari}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Non si puo inserire una lettere o valori diversi dai numeri,numero massimo che si può mettere è 9");
                txtnum2.Text = "";


            }
            try
            {


                int num3 = int.Parse(txtnum3.Text);
                if (num3%2==0)
                {
                    Pari++;
                    lblRisultato.Content = $"{Pari}";
                }
                else
                {
                    Dispari++;
                    lblRisultato_.Content = $"{Dispari}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Non si puo inserire una lettere o valori diversi dai numeri,numero massimo che si può mettere è 9");
                txtnum3.Text = "";
            }
            try
            {


                int num4 = int.Parse(txtnum4.Text);
                if (num4%2==0)
                {
                    Pari++;
                    lblRisultato.Content = $"{Pari}";
                }
                else
                {
                    Dispari++;
                    lblRisultato_.Content = $"{Dispari}";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Non si puo inserire una lettere o valori diversi dai numeri,numero massimo che si può mettere è 9");
                txtnum4.Text = "";
            }
            try
            {


                int num5 = int.Parse(txtnum5.Text);
                if (num5%2==0)
                {
                    Pari++;
                    lblRisultato.Content = $"{Pari}";
                }
                else
                {
                    Dispari++;
                    lblRisultato_.Content = $"{Dispari}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Non si puo inserire una lettere o valori diversi dai numeri,numero massimo che si può mettere è 9");
                txtnum5.Text = "";

            }
            try
            {


                int num6 = int.Parse(txtnum6.Text);
                if (num6%2==0)
                {
                    Pari++;
                    lblRisultato.Content = $"{Pari}";
                }
                else
                {
                    Dispari++;
                    lblRisultato_.Content = $"{Dispari}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Non si puo inserire una lettere o valori diversi dai numeri,numero massimo che si può mettere è 9");
                txtnum6.Text = "";
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Pari = 0;
            Dispari = 0;
            txtnum1.Clear();
            txtnum2.Clear();
            txtnum3.Clear();
            txtnum4.Clear();
            txtnum5.Clear();
            txtnum6.Clear();
            lblRisultato.Content = "";
            lblRisultato_.Content = "";
        }
    }
}
