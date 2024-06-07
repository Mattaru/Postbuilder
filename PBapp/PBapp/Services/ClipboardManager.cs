using System.Windows;

namespace PBapp.Services
{
    class ClipboardManager
    {
        public void CopyIngredients(string IngredientsString)
        {
            if (IngredientsString is not null) Clipboard.SetText(IngredientsString?.Trim());
        }
        public void CopyTags(string TagsString)
        {
            if (TagsString is not null) Clipboard.SetText(TagsString?.Trim());
        }
    }
}
