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

namespace tilitoli
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

        private void btnGenerateMap_Click(object sender, RoutedEventArgs e)
        {

            static void Shuffle(ComboBox cbDropdown)
            {
                Random rnd = new Random();
                int[] numbers = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = i + 1;
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    int randomIndex = rnd.Next(i, numbers.Length);
                    int temp = numbers[randomIndex];
                    numbers[randomIndex] = numbers[i];
                    numbers[i] = temp;
                }
            }

            //+2 index!!!!!
            int num = cbDropdown.SelectedIndex + 2;
            int index = 0;

            while (index < num)
            {
                RowDefinition row = new RowDefinition();
                ColumnDefinition column = new ColumnDefinition();

                spWindow.Children.Add(row);
                spWindow.Children.Add(column);

                Button newButton = new Button();
                newButton.Content = num;
                newButton.Click += newButton_Click;
                spWindow.Children.Add(newButton);

                index++;
            }
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            if ()
            {

            }
        }

        private void btnKesz_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
