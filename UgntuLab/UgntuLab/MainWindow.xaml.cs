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
using lab5;

namespace UgntuLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lab1Button_Click(object sender, RoutedEventArgs e)
        {
            Lab1Window lab1Window = new Lab1Window();
            lab1Window.ShowDialog();
        }

        private void Lab2Button_Click(object sender, RoutedEventArgs e)
        {
            Lab2Window lab2Window = new Lab2Window();
            lab2Window.ShowDialog();
        }

        private void Lab4Button_Click(object sender, RoutedEventArgs e)
        {
            Lab4Window lab4Window = new Lab4Window();
            lab4Window.ShowDialog();
        }

        private void Lab5Button_Click(object sender, RoutedEventArgs e)
        {
            lab5.MainWindow lab5Window = new lab5.MainWindow();
            lab5Window.ShowDialog();
        }
    }
}
