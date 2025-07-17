using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PrismTextInputProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource == this || e.OriginalSource is not TextBox)
            {
                if (SharedFocusManager.LastFocusedField != null)
                {
                    SharedFocusManager.LastFocusedField.ClearValue(Control.BackgroundProperty);
                }
                SharedFocusManager.LastFocusedField = null;

                SharedFocusManager.OnFocusChanged();
            }
        }
    }
}
