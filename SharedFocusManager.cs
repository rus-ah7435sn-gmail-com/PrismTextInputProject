using System;
using System.Windows.Controls;

namespace PrismTextInputProject
{
    public static class SharedFocusManager
    {
        public static TextBox LastFocusedField { get; set; }

        public static event Action FocusChanged;

        public static void OnFocusChanged()
        {
            FocusChanged?.Invoke();
        }
    }
}
