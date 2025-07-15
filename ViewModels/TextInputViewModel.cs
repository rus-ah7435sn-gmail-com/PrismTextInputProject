using Prism.Mvvm;

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
                if (!string.IsNullOrEmpty(SharedFocusManager.LastFocusedField) &&
                    SharedFocusManager.LastFocusedField != nameof(TextInputViewModel))
                {
                    SharedTextStore.UpdateText(SharedFocusManager.LastFocusedField, value);
                }
            }
        }

        public TextInputViewModel()
        {
            _inputText = "";
        }
    }
}
