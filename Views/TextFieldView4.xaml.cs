using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using PrismTextInputProject.ViewModels;

namespace PrismTextInputProject.Views
{
    public partial class TextFieldView4 : UserControl
    {
        public TextFieldView4()
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
            currentTextBox.Background = Brushes.LightPink;
            SharedFocusManager.LastFocusedField = currentTextBox;

            SharedFocusManager.OnFocusChanged();
        }
    }
}
