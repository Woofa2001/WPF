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
    /// Interaction logic for TypeObjectsPage.xaml
    /// </summary>
    public partial class TypeObjectsPage : Page
    {
        string Name_TYPE;
        public TypeObjectsPage()
        {
            InitializeComponent();
            DataContext = this;
            TypeObjectDataGrid.ItemsSource = SourceCore.DB.TYPE_OBJECTS.ToList();
            
        }

        private void CloseEdChangeClick(object sender, RoutedEventArgs e)
        {
            ChangeColumn.Width = new GridLength(0);
            SplitterColumn.Width = new GridLength(0);
            TypeObjectDataGrid.IsHitTestVisible = true;
        }

        private void ShowButtonTypeObject(object sender, RoutedEventArgs e)
        {
            if (ChangeColumn.Width.Value == 0)
            {
                ChangeColumn.Width = new GridLength(175);
                SplitterColumn.Width = GridLength.Auto;
                if ((sender as Button).Content.ToString() == "Добавить")
                {
                    TypeObjectDataGrid.SelectedItem = null;
                }
                if ((sender as Button).Content.ToString() == "Копировать")
                {
                    Name_TYPE = NameTypeTextBox.Text;
                    TypeObjectDataGrid.SelectedItem = null;
                    NameTypeTextBox.Text = Name_TYPE;
                    TypeObjectDataGrid.IsHitTestVisible = false;
                }
            }
            else
            {
                ChangeColumn.Width = new GridLength(0);
                SplitterColumn.Width = new GridLength(0); 
            }
        }

        private void DeleteButtonTypeObject(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание!", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                SourceCore.DB.TYPE_OBJECTS.Remove((Data.TYPE_OBJECTS)TypeObjectDataGrid.SelectedItem);
                SourceCore.DB.SaveChanges();
            }

        }

        private void CommitButtonTypeObject(object sender, RoutedEventArgs e)
        {
            if (TypeObjectDataGrid.SelectedItem == null)
            {
                if (NameTypeTextBox.Text != "")
                {
                    var A = new Data.TYPE_OBJECTS();
                    A.NAME_TYPE = NameTypeTextBox.Text;
                    SourceCore.DB.TYPE_OBJECTS.Add(A);
                }
            }
            SourceCore.DB.SaveChanges();
            CloseEdChangeClick(sender, e);
        }
    }
}
