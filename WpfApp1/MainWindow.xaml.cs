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
using Lib_13;

namespace WpfApp1
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

        private void GetSqrtOrSquare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = Practice.GetSqrtOrSquare();

                AllNumbers.Text = result.allNumbers;

                Result.Text = result.calculations;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Золотарев М.А ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
