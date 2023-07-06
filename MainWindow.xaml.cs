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

namespace Passwardprogram
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtusername.Text == "Rock" && pwdpassword.Password == "Rock")
            {
                MessageBox.Show("Hi welcome");
            }
            if (txtusername.Text != "" && pwdpassword.Password != "")
            {
                lblusername.Content = "";
                lblpassword.Content = "";
            }
            if(txtusername.Text==""&& pwdpassword.Password == "")
            {
                lblusername.Content = "Invalid username";
                lblpassword.Content = "Invalid password";
            }
            else if (txtusername.Text == "")
            {
                lblusername.Content = "Invalid username";
                lblusername.Content = "";
            }
            else if (pwdpassword.Password == "")
            {
                lblpassword.Content = "Invalid password";
                lblusername.Content = "";
            }
            else
            {
                MessageBox.Show("Invalid username and password");
            }
            if (txtusername.Text != "Rock")
            {
                lblusername.Content = " Username Invalid";
            }
            if (pwdpassword.Password != "Rock")
                lblpassword.Content = "Incorrect password";
        } private void pwtpassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtusername.Text != "" && pwdpassword.Password != "")
            {
                btnlogin.IsEnabled = true;
            }
            else
            {
                btnlogin.IsEnabled = false;
            }

        }
    } }
    


    
