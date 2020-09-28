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
    /// Interaction logic for PageCollectors.xaml
    /// </summary>
    public partial class PageCollectors : Page
    {
        ObservableCollection<Collector> collectors = new ObservableCollection<Collector>(AppData.Ent.Collectors);
        ObservableCollection<Collection> collections = new ObservableCollection<Collection>(AppData.Ent.Collections);
        ObservableCollection<Mark> marks = new ObservableCollection<Mark>(AppData.Ent.Marks);

        public PageCollectors()
        {
            InitializeComponent();

            CollectorsGrid.ItemsSource = AppData.Ent.Collectors.ToList();
        }

        private void FilterCheckBoxTwo_Checked(object sender, RoutedEventArgs e)
        {
            var time = DateTime.Now.AddYears(-10);

            //CollectorsGrid.ItemsSource = collectors.Where(x => x.Marks.Where(y => y.Price == 200) != null);



            CollectorsGrid.ItemsSource = marks
                .Where(x => x.IssueDate <= time)
                .Select(x => x.Collection)
                .Select(x => x.Collector)
                .Distinct()
                .ToList();
        }

        private void FilterCheckBoxTwo_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectorsGrid.ItemsSource = AppData.Ent.Collectors.ToList();
        }

        private void FilterCheckBoxOne_Checked(object sender, RoutedEventArgs e)
        {
            //CollectorsGrid.ItemsSource = AppData.Ent.Collectors.OrderBy(x => x.Collections.OrderBy(y => y.Marks.Sum(z => z.Price))).ToList();
            CollectorsGrid.ItemsSource = AppData.Ent.Collections.OrderByDescending(x => x.Marks.Sum(y => y.Price)).Select(z => z.Collector).ToList().Distinct();
        }

        private void FilterCheckBoxOne_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectorsGrid.ItemsSource = AppData.Ent.Collectors.ToList();
        }

       
    }
}
