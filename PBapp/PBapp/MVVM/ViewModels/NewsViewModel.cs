using PBapp.Core;
using PBapp.Data;
using PBapp.MVVM.Models;
using PBapp.Services;
using PBapp.Infrastructure.Commands;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PBapp.MVVM.ViewModels
{
    internal class NewsViewModel : ObservableObject
    {
        #region ParcingSources

        public string Sum37 { get => Sources.SUM37; }

        public string Ohui { get => Sources.OHUI; }

        public string Medipeel { get => Sources.MEDIPEEL; }

        public string Iope { get => Sources.IOPE; }

        public string Labonita { get => Sources.LABONITA; }

        #endregion

        #region For links

        public string whoo = "https://www.whoo.co.kr";
        public string snpmall = "https://snpmall.net/product/list_new.html?cate_no=293";

        #endregion

        #region SelectedSource

        private SourceModel _SelectedSource;

        public SourceModel SelectedSource { get => _SelectedSource; set => Set(ref _SelectedSource, value); }

        #endregion

        #region LoadingSpinner visibility

        private string _spinnerVisibility = "Collapsed";

        public string SpinnerVisibility { get => _spinnerVisibility; set => Set(ref _spinnerVisibility, value); }

        #endregion

        #region NewsList visibility

        private string _newsListVisibility = "Collapsed";

        public string NewsListVisibility { get => _newsListVisibility; set => Set(ref _newsListVisibility, value); }

        #endregion

        #region NewsLoaded

        private bool _newsLoaded = false;

        public bool NewsLoaded { get => _newsLoaded; set => Set(ref _newsLoaded, value); }

        #endregion

        // Commands

        #region GetSourceDataCommand

        public ICommand GetSourceDataCommand { get; }

        private bool CanGetResourceDataCommandExecute(object p) => true;

        private void OnGetResourceDataCommandExecuted(object p)
        {
            GetSource((string)p);
        }

        #endregion

        public NewsViewModel()
        {
            GetSourceDataCommand = new LambdaCommand(OnGetResourceDataCommandExecuted, CanGetResourceDataCommandExecute);
        }

        private async void GetSource(string url)
        {
            await Task.Run(() =>
            {
                if (NewsListVisibility != "Collapsed") NewsListVisibility = "Collapsed";
                if (SpinnerVisibility != "Visible") SpinnerVisibility = "Visible";

                SelectedSource = HTTPRequest.GetSourceData(url);
                OnPropertyChanged(nameof(SelectedSource));

                NewsListVisibility = "Visible";
                SpinnerVisibility = "Collapsed";
            });
        }
    }
}
