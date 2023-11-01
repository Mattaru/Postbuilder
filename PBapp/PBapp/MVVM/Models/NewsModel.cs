using PBapp.Core;

namespace PBapp.MVVM.Models
{
    class NewsModel : ObservableObject
    {
        #region Text

        private string _text;

        public string Text { get => _text; set => Set(ref _text, value); }

        #endregion

        #region Url

        private string _url;

        public string Url { get => _url; set => Set(ref _url, value); }

        #endregion

        #region ImageUrl

        private string _imageUrl;

        public string ImageUrl { get => _imageUrl; set => Set(ref _imageUrl, value); }

        #endregion
    }
}
