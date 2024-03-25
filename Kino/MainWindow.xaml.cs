using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KinoAplikace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            for (int i = 0; i < 30; i++)
            {
                gridSedadla.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < 15; i++)
            {
                gridSedadla.RowDefinitions.Add(new RowDefinition());
                for (int j = 0; j < 30; j++)
                {
                    var button = new Button();
                    button.SetValue(Grid.RowProperty, i);
                    button.SetValue(Grid.ColumnProperty, j);
                    button.Click += SeatButton_Click; 
                    gridSedadla.Children.Add(button);
                }
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var button in gridSedadla.Children)
            {
                if (button is Button)
                {
                    ((Button)button).Background = Brushes.Green;
                }
            }
        }

        private void SeatButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                if (button.Background == Brushes.Green)
                    button.Background = Brushes.Red;
                else
                    button.Background = Brushes.Green;
            }
        }
    }
}
