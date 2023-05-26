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
    /// Логика взаимодействия для Lab1Window.xaml
    /// </summary>
    public partial class Lab1Window : Window
    {
        private int randomValue;
        private int countTry;

        public Lab1Window()
        {
            InitializeComponent();
            Restart();
        }

        private void ValueTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsTextNumeric(e.Text);
        }

        public bool IsTextNumeric(string str)
        {
            Regex regex = new Regex("[^0-9]");
            return regex.IsMatch(str);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int value = Convert.ToInt32(ValueTextBox1.Text);
            double currentValue = 1;
            double result = currentValue;
            for (int i = 1; i < value; i++)
            {
                currentValue /= -2;
                result += currentValue;
            }

            MessageBox.Show(result.ToString());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int firstValue = 1;
            int secondValue = 2;
            int n = Convert.ToInt32(ValueTextBox2.Text);
            string result = "1 2";

            for (int i = 2; i < n; i++)
            {
                int currentValue = firstValue + secondValue;
                result += $" {currentValue}";
                firstValue = secondValue;
                secondValue = currentValue;
            }

            MessageBox.Show(result.ToString());
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            string value = ValueTextBox3.Text;

            string even = "";
            string odd = "";

            foreach (char s in value)
            {
                if (Convert.ToInt32(s.ToString()) % 2 == 0)
                    even += $" {s}";
                else
                    odd += $" {s}";
            }

            MessageBox.Show($"Четные: {even}\nНечетные: {odd}");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            string value = ValueTextBox4.Text;

            int sum = 0;
            int mul = 1;

            foreach (char s in value)
            {
                sum += Convert.ToInt32(s.ToString());
                mul *= Convert.ToInt32(s.ToString());
            }

            MessageBox.Show($"Сумма: {sum}\nПроизведение: {mul}");

        }

        private void Restart()
        {
            Random random = new Random();
            this.randomValue = random.Next(0, 100);
            this.countTry = 10;
            ResultLabel.Content = "Подсказка: Нажмите Check чтобы проверить число.";
            CountTryLabel.Content = $"У вас осталось: {this.countTry}";

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            int checkValue = Convert.ToInt32(ValueTextBox5.Text);

            if (checkValue == this.randomValue)
            {
                MessageBox.Show("Победа!");
                return;
            }
            if (this.countTry > 1)
            {
                if (checkValue > this.randomValue)
                    ResultLabel.Content = "Подсказка: Загаданное число меньше!";
                else
                    ResultLabel.Content = "Подсказка: Загаданное число больше!";
                this.countTry -= 1;
                CountTryLabel.Content = $"У вас осталось: {this.countTry}";
            }
            else
            {
                MessageBox.Show($"Поражение!\nЗагаданное число: {this.randomValue}!");
                Restart();
            }
        }
    }
}
