using System.Windows.Controls;
using System.Windows;

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
            SharedFocusManager.LastFocusedField = "TextFieldView4";
        }
    }
}
