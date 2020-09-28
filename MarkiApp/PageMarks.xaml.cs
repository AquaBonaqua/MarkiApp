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

namespace MarkiApp
{
    /// <summary>
    /// Interaction logic for PageMarks.xaml
    /// </summary>
    public partial class PageMarks : Page
    {
        public PageMarks()
        {
            InitializeComponent();
            MarksGrid.ItemsSource = AppData.Ent.Marks.ToList();
        }

        public void Update()
        {
            MarksGrid.ItemsSource = AppData.Ent.Marks.ToList();
        }

        private void PriceCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var max = AppData.Ent.Marks.Max(x => x.Price);
            MarksGrid.ItemsSource = AppData.Ent.Marks.Where(x => x.Price == max).ToList();

        }

        private void PriceCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowAddMark addMark = new WindowAddMark(this);
            addMark.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MarksGrid.SelectedItems.Count > 0)
            {
                /// удаление марки
                for (int i = 0; i < MarksGrid.SelectedItems.Count; i++)
                {

                    Mark mark = MarksGrid.SelectedItems[i] as Mark;

                    AppData.Ent.Marks.Remove(mark);
                }

                AppData.Ent.SaveChanges();
                /// вывод информации на экран
                MessageBox.Show("Марка удалена");
                Update();
            }
        }
    }
}
