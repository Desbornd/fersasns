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

namespace fersrans
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but_Click_1(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(first.Text, out double a) ||
            !double.TryParse(second.Text, out double b) ||
            !double.TryParse(third.Text, out double c))
            {
                MessageBox.Show("Пожалуйста, введите корректные числа во все поля.", "Ошибка ввода", MessageBoxButton.OK);
                return;
            }

            if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                MessageBox.Show("Такие стороны не могут образовать треугольник.", "Геометрическая ошибка", MessageBoxButton.OK);
                return;
            }

            string sideType = (a == b || b == c) ? "Равносторонний" :
                             (a == b || b == c || a == c) ? "Равнобедренный" : "Разносторонний";

            string resultMessage = $"Анализ завершен успешно!\n\nТип:{sideType} треугольник.";
            MessageBox.Show(resultMessage, "Результат", MessageBoxButton.OK);
        }
    }
}
