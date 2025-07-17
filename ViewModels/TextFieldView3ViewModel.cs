using Prism.Mvvm;

namespace PrismTextInputProject.ViewModels
{
    public class TextFieldView3ViewModel : BindableBase
    {
        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                if (_text != value)
                {
                    SetProperty(ref _text, value);
                    if (SharedFocusManager.LastFocusedField != null)
                    {
                        SharedTextStore.UpdateText(SharedFocusManager.LastFocusedField, value);
                    }
                }
            }
        }

        public TextFieldView3ViewModel()
        {
            SharedTextStore.TextUpdated += (viewKey, newText) =>
            {
                if (viewKey.DataContext?.GetType().Name.ToString() == GetType().Name.ToString())
                {
                    Text = newText;
                }
            };
        }
    }
}
