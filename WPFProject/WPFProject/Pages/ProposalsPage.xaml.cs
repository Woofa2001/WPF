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
    /// Логика взаимодействия для ProposalPage.xaml
    /// </summary>
    /// 

    

    public partial class ProposalPage : Page
    {

        private int _numValue = 0;

        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                txtNum.Text = value.ToString();
            }
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue))
                txtNum.Text = _numValue.ToString();
        }


        bool Copy;
        public ProposalPage()
        {
            InitializeComponent();
            DataContext = this;
            ProposalsDataGrid.ItemsSource = SourceCore.DB.PROPOSALS.ToList();
            PeopleComboBox.ItemsSource = SourceCore.DB.PEOPLE.ToList();
            TypeObjectComboBox.ItemsSource = SourceCore.DB.TYPE_OBJECTS.ToList();
            AreasComboBox.ItemsSource = SourceCore.DB.AREAS.ToList();
            PeopleComboBoxCopy.ItemsSource = SourceCore.DB.PEOPLE.ToList();
            TypeObjectComboBoxCopy.ItemsSource = SourceCore.DB.TYPE_OBJECTS.ToList();
            AreasComboBoxCopy.ItemsSource = SourceCore.DB.AREAS.ToList();
            ProposalsDataGridCopy.ItemsSource = SourceCore.DB.PROPOSALS.ToList();
        }

        private void CommitButtonProposals(object sender, RoutedEventArgs e)
        {
            if (ProposalsDataGrid.SelectedItem == null)
            {
                var A = new Data.PROPOSALS();
                A.PEOPLE = (Data.PEOPLE)PeopleComboBox.SelectedItem;
                A.AREAS = (Data.AREAS)AreasComboBox.SelectedItem;
                A.TYPE_OBJECTS = (Data.TYPE_OBJECTS)TypeObjectComboBox.SelectedItem;
                A.STREET = ProposalsStreetTextBox.Text;
                A.FLAT = Int32.Parse(ProposalsFlatTextBox.Text);
                A.FLOOR = Int32.Parse(ProposalsFloorTextBox.Text);
                A.COUNT_FLOORS = Int32.Parse(ProposalsCFloorTextBox.Text);
                A.COUNT_ROOMS = Int32.Parse(ProposalsRoomsTextBox.Text);
                A.TOTAL_AREA = Int32.Parse(ProposalsTAreaTextBox.Text);
                A.LIVING_AREA = Int32.Parse(ProposalsLAreaTextBox.Text);
                A.COST = (decimal)double.Parse(ProposalsCostTextBox.Text.Replace(".", ","));
                A.DESCRIPTION = ProposalsDiscriptionTextBox.Text;
                SourceCore.DB.PROPOSALS.Add(A);
            }
            if (Copy)
            {
                var A = new Data.PROPOSALS();
                A.PEOPLE = (Data.PEOPLE)PeopleComboBoxCopy.SelectedItem;
                A.AREAS = (Data.AREAS)AreasComboBoxCopy.SelectedItem;
                A.TYPE_OBJECTS = (Data.TYPE_OBJECTS)TypeObjectComboBoxCopy.SelectedItem;
                A.STREET = ProposalsStreetTextBoxCopy.Text;
                A.FLAT = Int32.Parse(ProposalsFlatTextBoxCopy.Text);
                A.FLOOR = Int32.Parse(ProposalsFloorTextBoxCopy.Text);
                A.COUNT_FLOORS = Int32.Parse(ProposalsCFloorTextBoxCopy.Text);
                A.COUNT_ROOMS = Int32.Parse(ProposalsRoomsTextBoxCopy.Text);
                A.TOTAL_AREA = Int32.Parse(ProposalsTAreaTextBoxCopy.Text);
                A.LIVING_AREA = Int32.Parse(ProposalsLAreaTextBoxCopy.Text);
                A.COST = (decimal)double.Parse(ProposalsCostTextBoxCopy.Text.Replace(".",",")) ;
                A.DESCRIPTION = ProposalsDiscriptionTextBoxCopy.Text;
                SourceCore.DB.PROPOSALS.Add(A);
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

        private void ShowButtonProposals(object sender, RoutedEventArgs e)
        {
            Copy = false;
            if ((ChangeColumnTwo.Width.Value == 0) && (ChangeColumn.Width.Value == 0))
            {
                ChangeColumn.Width = new GridLength(250);
                SplitterColumn.Width = GridLength.Auto;
                DataGridColumnOne.Width = new GridLength(1d, GridUnitType.Star);
                ChangeColumnTwo.Width = new GridLength(0);
                DataGridColumnTwo.Width = new GridLength(0);
                SplitterColumnTwo.Width = new GridLength(0);
                ProposalsDataGridCopy.Visibility = Visibility.Hidden;
                ProposalsLabelName.Content = "Изменение предложения";
                if ((sender as Button).Content.ToString() == "Добавить")
                {
                    ProposalsLabelName.Content = "Добавление предложения";
                    ProposalsDataGrid.SelectedItem = null;
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

        private void DeleteButtonProposals(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание!", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                SourceCore.DB.PROPOSALS.Remove((Data.PROPOSALS)ProposalsDataGrid.SelectedItem);
                SourceCore.DB.SaveChanges();
            }
        }



        private void ShowCopyButtonProposals(object sender, RoutedEventArgs e)
        {
            if ((ChangeColumnTwo.Width.Value == 0) && (ChangeColumn.Width.Value == 0))
            {
                Copy = true;
                ChangeColumnTwo.Width = new GridLength(250);
                SplitterColumnTwo.Width = GridLength.Auto;
                DataGridColumnTwo.Width = new GridLength(1d, GridUnitType.Star);
                ChangeColumn.Width = new GridLength(0);
                DataGridColumnOne.Width = new GridLength(0);
                SplitterColumn.Width = new GridLength(0);
                ProposalsDataGridCopy.Visibility = Visibility.Visible;
                ProposalsDataGridCopy.SelectedItem = ProposalsDataGrid.SelectedItem;
            }
            else
            {
                ChangeColumnTwo.Width = new GridLength(0);
                SplitterColumnTwo.Width = new GridLength(0);
                ChangeColumn.Width = new GridLength(0);
                SplitterColumn.Width = new GridLength(0);
            }
        }

        private void ShowCopyChange(object sender, SelectionChangedEventArgs e)
        {
            ProposalsDataGrid.SelectedItem = ProposalsDataGridCopy.SelectedItem;
        }
    }

}
