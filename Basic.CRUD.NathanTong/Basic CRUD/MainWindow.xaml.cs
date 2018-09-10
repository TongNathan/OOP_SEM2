using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Basic_CRUD
{

    public partial class MainWindow : Window
    {

        public ObservableCollection<string> Tasks { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<string>();
            this.ListBoxTasks.ItemsSource = Tasks;
        }

        public void AddTask(object sender, RoutedEventArgs e)
        {
            Tasks.Add(TextBoxTasks.Text);
            this.ListBoxTasks.ItemsSource = Tasks;
            TextBoxTasks.Clear();
        }

        private void DeleteTask(object sender, RoutedEventArgs e)
        {
            Tasks.Remove(TextBoxTasks.Text);

        }
        private void EditTask(object sender, RoutedEventArgs e)
        {

        }
        private void TextBoxTasks_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ListBoxTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
