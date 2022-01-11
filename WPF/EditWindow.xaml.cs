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
using System.Windows.Shapes;
using WPF.Model;

namespace WPF
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {

        public Man Man { get; private set; } = new Man();
        public EditWindow(Man man)
        {
            InitializeComponent();
            phoneTextBox.Text = man.Phone;
            emailTextBox.Text = man.EMail;
            fIOTextBox.Text = man.FIO;
            birthdayTextBox.Text = man.BirthDay;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Man.Phone = phoneTextBox.Text;
            Man.EMail = emailTextBox.Text;
            Man.FIO = fIOTextBox.Text;
            Man.BirthDay = birthdayTextBox.Text;
            this.DialogResult = true;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
