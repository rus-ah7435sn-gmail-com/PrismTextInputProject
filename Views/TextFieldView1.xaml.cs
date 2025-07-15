using System.Windows.Controls;
using System.Windows;

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
            SharedFocusManager.LastFocusedField = "TextFieldView1";
        }
    }
}
