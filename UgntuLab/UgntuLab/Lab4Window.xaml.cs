using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using System.Windows.Shapes;

namespace UgntuLab
{

    public static class EnumExtensions
    {
        public static TAttribute GetAttribute<TAttribute>(this Enum value)
            where TAttribute : Attribute
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            return type.GetField(name)
                .GetCustomAttributes(false)
                .OfType<TAttribute>()
                .SingleOrDefault();
        }

        public static String GetDescription(this Enum value)
        {
            var description = GetAttribute<DescriptionAttribute>(value);
            return description != null ? description.Description : null;
        }
    }

    public enum Actions
    {
        [Description("+")] Plus,
        [Description("-")] Minus,
        [Description("*")] Multiply,
        [Description("/")] Division,
        Null
}

    /// <summary>
    /// Логика взаимодействия для Lab5Window.xaml
    /// </summary>
    public partial class Lab4Window : Window
    {
        public string firstValue = "";
        public string secondValue = "";
        public string resultValue = "";
        public Actions action = Actions.Null;

        public Lab4Window()
        {
            InitializeComponent();
        }

        public static Actions GetActionFromText(string value) => value switch
        {
            "+" => Actions.Plus,
            "-" => Actions.Minus,
            "*" => Actions.Multiply,
            "÷" => Actions.Division
        };

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            string value = ((Button)sender).Content.ToString();

            if (action == Actions.Null)
            {
                try
                {
                    double tryParse = double.Parse(firstValue + value);
                    if (firstValue == "0")
                        firstValue = value;
                    else
                        firstValue += value;
                }
                catch { }
            }
            else
            {
                if (firstValue == "0")
                    secondValue = value;
                else
                    secondValue += value;
            }
            UpdateText();
        }


        private void Action_Click(object sender, RoutedEventArgs e)
        {
            string value = ((Button)sender).Content.ToString();
            if (action == Actions.Null)
            {
                action = GetActionFromText(value);
                UpdateText();
            }
            else
            {
                action = GetActionFromText(value);
                CalcelateResult();
            }
        }

        private void UpdateText()
        {
            if (action == Actions.Null)
            {
                CurrentText.Text = firstValue;
            }
            else
            {
                Text.Text = firstValue + $" {action.GetDescription()} ";

                CurrentText.Text = secondValue;
            }
        }

        private void CalcelateResult()
        {
            try
            {
                string result = new DataTable().Compute($"{Text.Text}{CurrentText.Text}".Replace(',', '.'), null).ToString();
                firstValue = result;
                secondValue = "";
                UpdateText();
            }
            catch
            {
                MessageBox.Show("Вы добились исключения.");
                ClearData();
            }
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            action = Actions.Null;
            CalcelateResult();
            Text.Text = "";
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (action == Actions.Null)
            {
                if (!string.IsNullOrEmpty(firstValue))
                    firstValue = firstValue.Remove(firstValue.Length - 1);
                else
                    firstValue = "0";
            }
            else
            {
                if (!string.IsNullOrEmpty(secondValue))
                    secondValue = secondValue.Remove(secondValue.Length - 1);
                else
                    secondValue = "0";
            }
            UpdateText();
        }

        private string UseFunc(string operation, string value)
        {
            return operation switch
            {
                "+/-" => (double.Parse(value) * -1).ToString(),
            };
        }

        private void Func_Click(object sender, RoutedEventArgs e)
        {
            string value = ((Button)sender).Content.ToString();

            if (action == Actions.Null)
            {
                firstValue = UseFunc(value, firstValue);
            }
            else
            {
                secondValue = UseFunc(value, secondValue);
            }

            UpdateText();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            firstValue = "";
            secondValue = "";
            Text.Text = "";
            CurrentText.Text = "";
            action = Actions.Null;
            UpdateText();
        }
    }
}
