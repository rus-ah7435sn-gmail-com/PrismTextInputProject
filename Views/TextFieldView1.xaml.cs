using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PrismTextInputProject.Views
{
    public partial class TextFieldView1 : UserControl
    {
        public TextFieldView1()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SharedFocusManager.LastFocusedField != null)
            {
                SharedFocusManager.LastFocusedField.ClearValue(Control.BackgroundProperty);
            }
            var currentTextBox = sender as TextBox;
            currentTextBox.Background = Brushes.LightGreen;
            SharedFocusManager.LastFocusedField = currentTextBox;

            SharedFocusManager.OnFocusChanged();
        }
    }
}
