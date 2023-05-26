using lab5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

namespace lab5
{
    /// <summary>
    /// Логика взаимодействия для StatusAgrementPage.xaml.xaml
    /// </summary>
    public partial class StatusAgreementPage : Page
    {

        private bool isDirty = true;
        private bool isReadOnly = true;

        public StatusAgreementPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = ContractDbContext.Instance.StatusAgrements.ToList();
        }

        private void Undo_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = true;
            SearchField.Text = "";
            DataGrid.IsReadOnly = isReadOnly;
            ContractDbContext.Instance.ChangeTracker.Clear();
            DataGrid.ItemsSource = ContractDbContext.Instance.StatusAgrements.ToList();
            DataGrid.Items.Refresh();

        }
        private void Undo_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }

        private void New_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = false;
            DataGrid.CanUserAddRows = true;
            DataGrid.IsReadOnly = !isReadOnly;
        }
        private void New_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void Save_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = true;
            DataGrid.IsReadOnly = isReadOnly;

            var itemsSource = (List<StatusAgrement>)DataGrid.ItemsSource;
            var newAddItems = itemsSource.Except(ContractDbContext.Instance.StatusAgrements.ToList()).ToList();

            if (newAddItems.Count > 0)
                foreach (var newItem in newAddItems)
                    ContractDbContext.Instance.StatusAgrements.Add(newItem);

            var newRemoveItems = ContractDbContext.Instance.StatusAgrements.ToList().Except(itemsSource).ToList();
            if (newRemoveItems.Count > 0)
                foreach (var newItem in newRemoveItems)
                    ContractDbContext.Instance.StatusAgrements.Remove(newItem);

            ContractDbContext.Instance.SaveChanges();
            DataGrid.CanUserAddRows = false;
            DataGrid.Items.Refresh();
        }
        private void Save_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }

        private void Find_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = false;
            DataGrid.ItemsSource = ContractDbContext.Instance.StatusAgrements.Where(s => s.Status.StartsWith(SearchField.Text)).ToList();
            DataGrid.Items.Refresh();
        }
        private void Find_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void Edit_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = false;
            DataGrid.IsReadOnly = !isReadOnly;
        }
        private void Edit_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void Delete_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = false;
            ((List<StatusAgrement>)DataGrid.ItemsSource).Remove((StatusAgrement)DataGrid.SelectedItem);
            DataGrid.Items.Refresh();
        }
        private void Delete_CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
