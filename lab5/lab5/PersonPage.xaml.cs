using lab5.Models;
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

namespace lab5
{
    /// <summary>
    /// Логика взаимодействия для PersonPage.xaml
    /// </summary>
    public partial class PersonPage : Page
    {
        private bool isDirty = true;
        private bool isReadOnly = true;

        public PersonPage()
        {
            InitializeComponent();
            DataGrid.ItemsSource = ContractDbContext.Instance.People.ToList();
        }

        private void Undo_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = true;
            SearchField.Text = "";
            DataGrid.IsReadOnly = isReadOnly;
            ContractDbContext.Instance.ChangeTracker.Clear();
            DataGrid.ItemsSource = ContractDbContext.Instance.People.ToList();
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

            var itemsSource = (List<Person>)DataGrid.ItemsSource;
            var newAddItems = itemsSource.Except(ContractDbContext.Instance.People.ToList()).ToList();

            if (newAddItems.Count > 0)
                foreach (var newItem in newAddItems)
                    ContractDbContext.Instance.People.Add(newItem);

            var newRemoveItems = ContractDbContext.Instance.People.ToList().Except(itemsSource).ToList();
            if (newRemoveItems.Count > 0)
                foreach (var newItem in newRemoveItems)
                    ContractDbContext.Instance.People.Remove(newItem);

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
            string text = SearchField.Text;
            DataGrid.ItemsSource = ContractDbContext.Instance.People.Where(p => p.Inn.StartsWith(text) || p.Type.StartsWith(text) || p.Shifer.StartsWith(text)).ToList();
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
            ((List<Person>)DataGrid.ItemsSource).Remove((Person)DataGrid.SelectedItem);
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
