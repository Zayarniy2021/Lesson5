using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WPF.Model;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Man> list = new ObservableCollection<Man>();

        public ObservableCollection<Man> List { get => list; private set
            {
                list = value;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            List.Add(new Man());
            List.Add(new Man());
            List.Add(new Man());
            List.Add(new Man());
            this.DataContext = this;
            //peopleDataGrid.ItemsSource = List;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Man man = new Man();

            man = (Man)peopleDataGrid.SelectedItem;
            if (man == null) return;
            EditWindow editWindow = new EditWindow(man);
            editWindow.ShowDialog();
            if (editWindow.DialogResult.HasValue && editWindow.DialogResult.Value == true)
            {
                List[man.ID] = editWindow.Man;
            }

        }
    }
}
