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
        List<Form> submission = new List<Form>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //string userName = name.Text;
            //string userAddress = address.Text;
            int userZipcode = Convert.ToInt32(zipcode.Text);
            Form submission1 = new Form();
            submission1.Name = name.Text;
            submission1.Address = address.Text;
            submission1.ZipCode = userZipcode;

            lst.Items.Add(submission1);

        }
    }
}
