using Prism.Mvvm;
using PrismTextInputProject.Views;

namespace PrismTextInputProject.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    SetProperty(ref _title, value);
                    if (SharedFocusManager.LastFocusedField == null)
                    {
                        SharedTextStore.UpdateMainWindowTitle(null, value);
                    }
                }
            }
        }

        public MainWindowViewModel()
        {
            SharedTextStore.TitleUpdated += (viewKey, newText) =>
            {
                if (viewKey == null || (viewKey.DataContext?.GetType().Name.ToString() == "TextFieldView4ViewModel"))
                {
                    Title = newText;
                }
            };
        }
    }
}
