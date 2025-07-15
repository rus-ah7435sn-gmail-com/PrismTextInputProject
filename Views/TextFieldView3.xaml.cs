using System.Windows.Controls;
using System.Windows;

namespace PrismTextInputProject.Views
{
    public partial class TextFieldView3 : UserControl
    {
        public TextFieldView3()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SharedFocusManager.LastFocusedField = "TextFieldView3";
        }
    }
}
