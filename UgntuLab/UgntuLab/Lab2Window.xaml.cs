using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UgntuLab
{
    /// <summary>
    /// Логика взаимодействия для Lab2Window.xaml
    /// </summary>
    public partial class Lab2Window : Window
    {
        private double N;
        private double K;
        private double x;
        private double y;
        private double t;
        private double f;

        private Regex numberRegex = new Regex(@"^-?[0-9]*(?:\,[0-9]*)?$");

        public Lab2Window()
        {
            InitializeComponent();
        }

        private void ValidateTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string proposedText = textBox.Text.Insert(textBox.CaretIndex, e.Text);

            // Проверка, является ли запятая уже введенным символом
            if (e.Text == "," && textBox.Text.Contains(","))
            {
                e.Handled = true;
                return;
            }

            if (!numberRegex.IsMatch(proposedText))
            {
                e.Handled = true;
            }
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            N = Convert.ToDouble(nTextBox.Text);
            K = Convert.ToDouble(kTextBox.Text);
            x = Convert.ToDouble(xTextBox.Text);
            y = Convert.ToDouble(yTextBox.Text);
            t = Convert.ToDouble(tTextBox.Text);
            f = Convert.ToDouble(fTextBox.Text);
            double result = 1;

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < K; j++)
                {
                    result *= (Math.Pow(t, i) * Math.Pow(x, i) + Math.Pow(f, j) * Math.Pow(y, j)) / (t * i * j);
                }
            }

            ResultTextBox.Text = result.ToString();

        }
    }
}
