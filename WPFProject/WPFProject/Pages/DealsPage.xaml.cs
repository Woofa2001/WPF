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
    /// Interaction logic for DealsPage.xaml
    /// </summary>
    public partial class DealsPage : Page
    {
        bool Copy;
        public DealsPage()
        {
            InitializeComponent();
            DataContext = this;
            DealsDataGrid.ItemsSource = SourceCore.DB.DEALS.ToList();
            RealComboBox.ItemsSource = SourceCore.DB.PEOPLE.ToList();
            SellerComboBox.ItemsSource = SourceCore.DB.PEOPLE.ToList();
            ProposalsComboBox.ItemsSource = SourceCore.DB.PROPOSALS.ToList();
            RealComboBoxCopy.ItemsSource = SourceCore.DB.PEOPLE.ToList();
            SellerComboBoxCopy.ItemsSource = SourceCore.DB.PEOPLE.ToList();
            ProposalsComboBoxCopy.ItemsSource = SourceCore.DB.PROPOSALS.ToList();
        }

        private void CommitButtonProposals(object sender, RoutedEventArgs e)
        {
            if (DealsDataGrid.SelectedItem == null)
            {
                var A = new Data.DEALS();
                A.PEOPLE = (Data.PEOPLE)RealComboBox.SelectedItem;
                A.PEOPLE = (Data.PEOPLE)SellerComboBox.SelectedItem;
                A.PROPOSALS = (Data.PROPOSALS)ProposalsComboBox.SelectedItem;
                A.DATA_DEALS = Convert.ToDateTime(DealsDatePicker.Text);
                A.COMM_REAL = Convert.ToDecimal(ProposalsCommRealTextBox.Text);
                SourceCore.DB.DEALS.Add(A);
            }
            if(Copy)
            {
                var A = new Data.DEALS();
                A.PEOPLE = (Data.PEOPLE)RealComboBoxCopy.SelectedItem;
                A.PEOPLE = (Data.PEOPLE)SellerComboBoxCopy.SelectedItem;
                A.PROPOSALS = (Data.PROPOSALS)ProposalsComboBoxCopy.SelectedItem;
                A.DATA_DEALS = Convert.ToDateTime(DealsDatePickerCopy.Text);
                A.COMM_REAL = Convert.ToDecimal(ProposalsCommRealTextBoxCopy.Text);
                SourceCore.DB.DEALS.Add(A);
            }
            SourceCore.DB.SaveChanges();
            CloseEdChangeClick(sender, e);
        }

        private void CloseEdChangeClick(object sender, RoutedEventArgs e)
        {
            ChangeColumn.Width = new GridLength(0);
            SplitterColumn.Width = new GridLength(0);
            ChangeColumnTwo.Width = new GridLength(0);
            SplitterColumnTwo.Width = new GridLength(0);
            Copy = false;
        }

        private void ShowButtonDeals(object sender, RoutedEventArgs e)
        {
            Copy = false;
            if (ChangeColumn.Width.Value == 0)
            {
                ChangeColumn.Width = new GridLength(250);
                SplitterColumn.Width = GridLength.Auto;
                if ((sender as Button).Content.ToString() == "Добавить")
                {
                    DealsDataGrid.SelectedItem = null;
                }
                if ((sender as Button).Content.ToString() == "Копировать")
                {
                    Copy = true;
                    ChangeColumnTwo.Width = new GridLength(150);
                    SplitterColumnTwo.Width = GridLength.Auto;
                    ChangeColumn.Width = new GridLength(0);
                    SplitterColumn.Width = new GridLength(0);
                }
            }
            else
            {
                ChangeColumn.Width = new GridLength(0);
                SplitterColumn.Width = new GridLength(0);
                ChangeColumnTwo.Width = new GridLength(0);
                SplitterColumnTwo.Width = new GridLength(0);
            }
        }

        private void DeleteButtonDeals(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание!", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                SourceCore.DB.DEALS.Remove((Data.DEALS)DealsDataGrid.SelectedItem);
                SourceCore.DB.SaveChanges();
            }
        }
    }
}
