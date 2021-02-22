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

namespace opgave_5_wpf
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

        private void validatePassword_Click(object sender, RoutedEventArgs e)
        {
            bool number = false;
            bool letter = false;
            bool symbol = false;
            bool minimum = false;
            int passwordLength =Password.Password.Length;
            char currentChar;

            if (passwordLength >= 8)
            {
                minimum = true;
            }

            for (int i = 0; i < Password.Password.Length; i++)
            {
                currentChar = Password.Password[i];

                if (char.IsLetter(currentChar))
                {
                    letter = true;
                }
                   
                if (char.IsDigit(currentChar))
                {
                    number = true;
                }
                if (!char.IsLetterOrDigit(currentChar))
                {
                    symbol = true;
                }
            }

            if (symbol && letter && number && minimum)
            {
                validate.Text = "Very strong";
            }
            else if (letter && number && minimum)
            {
                validate.Text = "Strong";
            }
            else if (letter)
            {
                validate.Text = "Weak";
            }
            else if (number)
            {
                validate.Text = "Very weak";
            }
            else
            {
                validate.Text = "sorry password does not fit the requirements";
            }

        }

        
    }
}
