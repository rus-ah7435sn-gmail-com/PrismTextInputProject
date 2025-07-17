using System.Windows;
using Prism.Mvvm;
using PrismTextInputProject.Views;

namespace PrismTextInputProject.ViewModels
{
    public class TextInputViewModel : BindableBase
    {
        private string _inputText;
        public string Text
        {
            get => _inputText;
            set
            {
                SetProperty(ref _inputText, value);
                if (SharedFocusManager.LastFocusedField == null)
                {
                    SharedTextStore.UpdateMainWindowTitle(null, value);
                }
                else
                {
                    SharedTextStore.UpdateText(SharedFocusManager.LastFocusedField, value);
                }
            }
        }

        public TextInputViewModel()
        {
            SharedFocusManager.FocusChanged += () =>
            {
                Text = string.Empty;
            };
        }
    }
}
