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

namespace WPFProject.Pages
{
    /// <summary>
    /// Interaction logic for PeoplePage.xaml
    /// </summary>
    public partial class PeoplesPage : Page
    {
        string SURNAME;
        string NAME;
        string MIDNAME;
        public PeoplesPage()
        {
            InitializeComponent();
            DataContext = this;
            PeopleDataGrid.ItemsSource = SourceCore.DB.PEOPLE.ToList();
        }

        private void CommitButtonPeople(object sender, RoutedEventArgs e)
        {
            if (PeopleDataGrid.SelectedItem == null)
            {
                if ((PeopleFTextBox.Text != "") && (PeopleITextBox.Text != "") && (PeopleOTextBox.Text != ""))
                {
                    var A = new Data.PEOPLE();
                    A.SURNAME = PeopleFTextBox.Text;
                    A.NAME = PeopleITextBox.Text;
                    A.MIDNAME= PeopleOTextBox.Text;
                    SourceCore.DB.PEOPLE.Add(A);
                }
            }
            SourceCore.DB.SaveChanges();
            CloseEdChangeClick(sender, e);
        }

        private void CloseEdChangeClick(object sender, RoutedEventArgs e)
        {
            ChangeColumn.Width = new GridLength(0);
            SplitterColumn.Width = new GridLength(0);
            PeopleDataGrid.IsHitTestVisible = true;
        }

        private void ShowButtonPeople(object sender, RoutedEventArgs e)
        {
            if (ChangeColumn.Width.Value == 0)
            {
                ChangeColumn.Width = new GridLength(175);
                SplitterColumn.Width = GridLength.Auto;
                if ((sender as Button).Content.ToString() == "Добавить")
                {
                    PeopleDataGrid.SelectedItem = null;
                    PeopleDataGrid.IsHitTestVisible = false;
                }
                if ((sender as Button).Content.ToString() == "Копировать")
                {
                    SURNAME = PeopleFTextBox.Text;
                    NAME = PeopleITextBox.Text;
                    MIDNAME = PeopleOTextBox.Text;
                    PeopleDataGrid.SelectedItem = null;
                    PeopleFTextBox.Text = SURNAME;
                    PeopleITextBox.Text = NAME;
                    PeopleOTextBox.Text = MIDNAME;
                    PeopleDataGrid.IsHitTestVisible = false;
                }
            }
            else
            {
                ChangeColumn.Width = new GridLength(0);
                SplitterColumn.Width = new GridLength(0);
            }
        }

        private void DeleteButtonPeople(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание!", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                SourceCore.DB.PEOPLE.Remove((Data.PEOPLE)PeopleDataGrid.SelectedItem);
                SourceCore.DB.SaveChanges();
            }
        }
    }
}
