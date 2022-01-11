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
using Departmetns.Model;

namespace Departmetns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Departmetns.Model.Department departmetns = new Model.Department("Информационный");
            departmetns.Employees.Add(new Model.Employee("Иванов Иван", 33));
            departmetns.Employees.Add(new Model.Employee("Петров Петр", 35));
            departmetns.Employees.Add(new Model.Employee("Сидоров Андрей", 43));

            //departmetns.WriteToXML("deparments.xml");
            //Department departments = Department.LoadFromXML("deparments.xml");
            lbPeople.ItemsSource = departmetns.Employees;
        }

        private void lbPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbName.Text = (lbPeople.SelectedItem as Employee).Name;
            tbAge.Text = (lbPeople.SelectedItem as Employee).Age.ToString();
        }
    }
}
