using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MarkiApp
{
    /// <summary>
    /// Interaction logic for PageCollections.xaml
    /// </summary>
    public partial class PageCollections : Page
    {
        ObservableCollection<Collector> collectors = new ObservableCollection<Collector>(AppData.Ent.Collectors);
        ObservableCollection<Collection> collections = new ObservableCollection<Collection>(AppData.Ent.Collections);
        ObservableCollection<Mark> marks = new ObservableCollection<Mark>(AppData.Ent.Marks);

        int id;
        string name;

        public PageCollections()
        {
            InitializeComponent();
            CollectorComboBox.ItemsSource = collectors.ToList();
            CollectionsGrid.ItemsSource = collections;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            id = ((sender as Button).DataContext as Collection).CollectionID;
            name = ((sender as Button).DataContext as Collection).Name;
            CollectionNameStack.Visibility = Visibility.Visible;
            CollectionName2.Text = name;

            if (FilterCheckBox2.IsChecked == true)
            {
                MarksGrid.ItemsSource = marks.Where(x => x.CollectionID == id & x.Feature == "Редкая");
            }

            else
            {
                MarksGrid.ItemsSource = marks.Where(x => x.CollectionID == id);
            }


        }

        private void CollectorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                CollectionsGrid.ItemsSource = collections.Where(x => x.CollectorID == (int)CollectorComboBox.SelectedValue);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
                FilterCheckBox3.IsChecked = false;
                FilterCheckBox3.IsEnabled = false;
                CollectorComboBox.IsEnabled = true;
                CollectionsGrid.ItemsSource = collections.Where(x => x.CollectorID == (int)CollectorComboBox.SelectedValue);
           
        }


        private void FilterCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

                FilterCheckBox3.IsEnabled = true;
                CollectorComboBox.IsEnabled = false;
                CollectionsGrid.ItemsSource = collections;

        }

        private void FilterCheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            if (FilterCheckBox2.IsChecked == true)
            {
                MarksGrid.ItemsSource = marks.Where(x => x.CollectionID == id & x.Feature == "Редкая");
            }

            else
            {
                MarksGrid.ItemsSource = marks.Where(x => x.CollectionID == id);
            }
        }

        private void FilterCheckBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            if (FilterCheckBox2.IsChecked == true)
            {
                MarksGrid.ItemsSource = marks.Where(x => x.CollectionID == id & x.Feature == "Редкая");
            }

            else
            {
                MarksGrid.ItemsSource = marks.Where(x => x.CollectionID == id);
            }
        }

        private void FilterCheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            var countt = collections.Max(x => x.Marks.Count(y => y.Feature == "Редкая"));
            CollectionsGrid.ItemsSource = collections.Where(x => x.Marks.Count(y => y.Feature == "Редкая") == countt);

        }


        private void FilterCheckBox3_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectionsGrid.ItemsSource = collections;
        }
    }
}
