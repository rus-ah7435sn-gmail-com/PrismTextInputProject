using System.Windows.Controls;
using System.Windows;

namespace PrismTextInputProject.Views
{
    public partial class TextFieldView2 : UserControl
    {
        public TextFieldView2()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SharedFocusManager.LastFocusedField = "TextFieldView2";
        }
    }
}
