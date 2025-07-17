using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;

namespace PrismTextInputProject
{
    public static class SharedTextStore
    {
        private static Dictionary<TextBox, string> _textMap = new Dictionary<TextBox, string>();

        private static TextBox _nullKey = new TextBox();

        public static event Action<TextBox, string> TextUpdated;

        public static event Action<TextBox, string> TitleUpdated; 

        public static void UpdateMainWindowTitle(TextBox viewKey, string newText)
        {
            if (viewKey == null)
            {
                _textMap[_nullKey] = newText;
            }
            else
            {
                _textMap[viewKey] = newText;
            }
            TitleUpdated?.Invoke(viewKey, newText);
        }

        public static void UpdateText(TextBox viewKey, string newText)
        {
            if (viewKey.DataContext?.GetType().Name.ToString() == "TextFieldView4ViewModel")
            {
                UpdateMainWindowTitle(null, newText);
            }
            else
            {
                _textMap[viewKey] = newText;
                TextUpdated?.Invoke(viewKey, newText);
            }
        }

        public static string GetTextFor(TextBox viewKey)
        {
            _textMap.TryGetValue(viewKey, out var value);
            return value ?? "";
        }
    }
}
