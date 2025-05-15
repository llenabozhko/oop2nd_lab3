using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace block1
{
    public partial class MainWindow : Window
    {
        private Random _random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NoButton_MouseEnter(object sender, MouseEventArgs e)
        {
            double maxX = Math.Max(0, ActualWidth - NoButton.ActualWidth - 40);
            double maxY = Math.Max(0, ActualHeight - NoButton.ActualHeight - 100);

            double newX = _random.NextDouble() * maxX;
            double newY = _random.NextDouble() * maxY;

            Canvas.SetLeft(NoButton, newX);
            Canvas.SetTop(NoButton, newY);
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("А ми і не сумнівалися ;)", "Відповідь", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Який ви настирний!", "Відповідь", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.FocusedElement == YesButton)
            {
                NoButton.Focus();
            }
        }
    }
}
