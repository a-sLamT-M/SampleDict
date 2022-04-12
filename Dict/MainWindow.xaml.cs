using SourceChord.FluentWPF;
using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Dict
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : AcrylicWindow
    {
        private static readonly Regex _regex = new Regex("[^0-9]+");

        public MainWindow()
        {
            InitializeComponent();
            ResultTextBox.Text = RandomNumberGenerator.GetInt32(99).ToString();
        }

        private void minTextBox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.minTextBoxBorder.BorderBrush = SystemColors.DesktopBrush;
        }

        private void MAXTextBox_OnMouseEnter(object sender, MouseEventArgs e)
        {
            this.minTextBoxBorder.BorderBrush = SystemColors.DesktopBrush;
        }

        private void GenButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResultTextBox.Text = RandomNumberGenerator.GetInt32(int.Parse(minTextBox.Text), int.Parse(MAXTextBox.Text)).ToString();
            }
            catch (Exception exception)
            {
                ResultTextBox.Text = "N/A";
            }
        }
    }
}