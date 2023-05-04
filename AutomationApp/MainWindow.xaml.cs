using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace AutomationApp
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

        private string? input = "";
        private int countFive = 0, countTwo = 0;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            input = text;
            //MessageBox.Show(text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add_To_Label();
        }

        private void Add_To_Label()
        {
            int temp = Convert.ToInt32(input);
            label_out_put.Text += input + "\n";
            if(input == "5") 
            {
                countFive++;
                countTwo = 0;
            }
            if(input == "2")
            {
                countTwo++;
                countFive = 0;
            }
            if(input == "2" || input == "5") 
            {
                MessageBox.Show(countTwo.ToString() + " " + countFive.ToString());
                if (countTwo > 3)
                {
                    label_out_put.Text += "подзатыльник" + "\n";
                }
                else if (countTwo == 3)
                {
                    label_out_put.Text += "ругает" + "\n";
                }
                else if (countTwo == 2)
                {
                    label_out_put.Text += "беседует" + "\n";
                }
                else if (countTwo == 1)
                {
                    label_out_put.Text += "успакаивает" + "\n";
                }
                else if (countFive > 2)
                {
                    label_out_put.Text += "ликует" + "\n";
                }
                else if (countFive == 2)
                {
                    label_out_put.Text += "поощряет" + "\n";
                }
                else if (countFive == 1)
                {
                    label_out_put.Text += "радуется" + "\n";
                }
            }
        
    }
}
