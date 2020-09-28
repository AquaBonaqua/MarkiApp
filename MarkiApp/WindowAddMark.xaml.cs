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

namespace MarkiApp
{
    /// <summary>
    /// Interaction logic for WindowAddMark.xaml
    /// </summary>
    public partial class WindowAddMark : Window
    {
        PageMarks pageMarks;

        public WindowAddMark(PageMarks page)
        {
            InitializeComponent();
            CollectionCB.ItemsSource = AppData.Ent.Collections.ToList();
            CollectionCB.DisplayMemberPath = "Name";
            CollectionCB.SelectedValuePath = "CollectionID";
            pageMarks = page;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTB.Text) || string.IsNullOrEmpty(ThemeTB.Text) || string.IsNullOrEmpty(CountryTB.Text) || string.IsNullOrEmpty(FeatureTB.Text) || string.IsNullOrEmpty(EditionTB.Text) || string.IsNullOrEmpty(PriceTB.Text) || IssueDate.SelectedDate.Value == null || PurchaseDate.SelectedDate.Value == null)
            {
                MessageBox.Show("keks");
            }

            else
            {
                Mark mark = new Mark()
                {
                    Name = NameTB.Text,
                    Theme = ThemeTB.Text,
                    Country = CountryTB.Text,
                    Feature = FeatureTB.Text,
                    IssueDate = IssueDate.SelectedDate.Value,
                    Edition = Convert.ToInt32(EditionTB.Text),
                    PurchaseDate = PurchaseDate.SelectedDate.Value,
                    Price = Convert.ToDecimal(PriceTB.Text),
                    CollectionID = Convert.ToInt32(CollectionCB.SelectedValue),
                };
                AppData.Ent.Marks.Add(mark);
                AppData.Ent.SaveChanges();
                MessageBox.Show("Добавлено");
                pageMarks.Update();
                this.Close();
            }


        }

        private void Window_Closed(object sender, EventArgs e)
        {
            pageMarks.Update();
        }
    }
}
