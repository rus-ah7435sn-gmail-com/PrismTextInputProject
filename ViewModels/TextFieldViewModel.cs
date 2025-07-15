using Prism.Mvvm;

namespace PrismTextInputProject.ViewModels
{
    public class TextFieldViewModel : BindableBase
    {
        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                SetProperty(ref _text, value);
                if (SharedFocusManager.LastFocusedField != null &&
                    SharedFocusManager.LastFocusedField != nameof(TextInputViewModel))
                {
                    SharedTextStore.UpdateText(SharedFocusManager.LastFocusedField, value);
                }
            }
        }

        public TextFieldViewModel()
        {
            _text = SharedTextStore.GetTextFor(GetType().Name.Replace("ViewModel", ""));
        }
    }
}
