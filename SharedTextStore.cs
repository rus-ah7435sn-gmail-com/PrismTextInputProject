using System.Collections.Generic;

namespace PrismTextInputProject
{
    public static class SharedTextStore
    {
        private static Dictionary<string, string> _fieldTexts = new();

        public static void UpdateText(string fieldName, string value)
        {
            _fieldTexts[fieldName] = value;
        }

        public static string GetTextFor(string fieldName)
        {
            return _fieldTexts.TryGetValue(fieldName, out var val) ? val : string.Empty;
        }
    }
}
