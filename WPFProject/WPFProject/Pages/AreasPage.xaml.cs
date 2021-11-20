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
    /// Interaction logic for AreasPage.xaml
    /// </summary>
    public partial class AreasPage : Page
    {
        string TYPE_AREA;
        public AreasPage()
        {
            InitializeComponent();
            DataContext= this;
            AreasDataGrid.ItemsSource = SourceCore.DB.AREAS.ToList();
        }

        private void ShowButtonAreas(object sender, RoutedEventArgs e)
        {
            if (ChangeColumn.Width.Value == 0)
            {
                ChangeColumn.Width = new GridLength(250);
                SplitterColumn.Width = GridLength.Auto;
                if ((sender as Button).Content.ToString() == "Добавить")
                {
                    AreasDataGrid.SelectedItem = null;
                }
                if (((sender as Button).Content.ToString() == "Копировать")&&(AreasDataGrid.SelectedItem!=null))
                {
                    TYPE_AREA = AreaTypeTextBox.Text;
                    AreasDataGrid.SelectedItem = null;
                    AreaTypeTextBox.Text = TYPE_AREA;
                    AreasDataGrid.IsHitTestVisible = false;
                }
            }
            else
            {
                ChangeColumn.Width = new GridLength(0);
                SplitterColumn.Width = new GridLength(0);
            }
        }

        private void CloseEdChangeClick(object sender, RoutedEventArgs e)
        {
            ChangeColumn.Width = new GridLength(0);
            SplitterColumn.Width = new GridLength(0);
            AreasDataGrid.IsHitTestVisible = true;
        }

        private void CommitButtonAreas(object sender, RoutedEventArgs e)
        {
            if (AreasDataGrid.SelectedItem == null)
            {
                if(AreaTypeTextBox.Text != "")
                {
                    var A = new Data.AREAS();
                    A.TYPE_AREA = AreaTypeTextBox.Text;
                    SourceCore.DB.AREAS.Add(A);
                }
            }
            SourceCore.DB.SaveChanges();
            CloseEdChangeClick(sender, e);
        }

        private void DeleteButtonAreas(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Удалить запись?","Внимание!",MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                SourceCore.DB.AREAS.Remove((Data.AREAS)AreasDataGrid.SelectedItem);
                SourceCore.DB.SaveChanges();
            }
        }
    }
}
