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

namespace Wen_Participation1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Form> submissions = new List<Form>();
        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string userName = name.Text;
            string userAddress = address.Text;
            int ZipCode = Convert.ToInt32(zipcode.Text);
            Form submission1 = new Form();

            //for (int i = 1; i < 8; i++)
            //{
            //    int userZipcode = Convert.ToInt32(zipcode.Text);
            //    Form submission1 = new Form();
            //    submission1.Name = name.Text;
            //    submission1.Address = address.Text;
            //    submission1.ZipCode = userZipcode; //Convert.ToInt32(zipcode.Text);
            //    submission1.one = 10;
            //    submission1.two = rand.Next(1, 6);
            //    submissions.Add(submission1);
            //}

            //foreach(Form submission in submissions)
            //{
            //    lst.Items.Add(submission);
            //}

            bool IsFormValid = true;
            if(name.Text==" " || name.Text == string.Empty)
            {
                MessageBox.Show("Please input your name");
                name.Focus();
                // return;
                IsFormValid = false;
            }
            if (address.Text == "")
            {
                MessageBox.Show("Please input your name");
                address.Focus();
                // return;
                IsFormValid = false;
            }
            if (IsFormValid = false)
            {
                return;
            }

            submissions.Add(submission1);
        }

        //private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string count = lst.SelectedItem.ToString();

        //    double total = count.Length;
           

        //    Form submission1 = new Form();
        //    submission1.Name = name.Text;
        //    submission1.Address = address.Text;
        //    submission1.ZipCode = Convert.ToInt32(zipcode.Text); //Convert.ToInt32(zipcode.Text);
        //    submission1.one = total;
        //    submission1.two = rand.Next(1, 6);
        //    lst.Items.Add($"{submission1.one} {submission1.two} {submission1.qwe()}");
        //    lst.Items.Add(submission1.two);
        //    lst.Items.Add(submission1.qwe());

        //    double i = 1;

        }
    }

