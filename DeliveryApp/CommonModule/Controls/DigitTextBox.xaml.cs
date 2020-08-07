using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace CommonModule.Controls
{
    /// <summary>
    /// Логика взаимодействия для NumberBox.xaml
    /// </summary>
    public partial class DigitTextBox : TextBox
    {
        public DigitTextBox()
        {
            InitializeComponent();
        }
        private void NumberBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}