using PBapp.Core;
using PBapp.Infrastructure.Commands;
using PBapp.Services;
using System;
using System.Windows.Input;

namespace PBapp.MVVM.ViewModels
{
    class TagsViewModel : ObservableObject
    {
        #region AddTagFormVisibility

        private string _addTagFormVisibility;

        public string AddTagFormVisibility { get => _addTagFormVisibility; set => Set(ref _addTagFormVisibility, value); }

        #endregion

        #region MainGridVisibility

        private string _mainGridVisibility;

        public string MainGridVisibility { get => _mainGridVisibility; set => Set(ref _mainGridVisibility, value); }

        #endregion

        #region CBManager

        private ClipboardManager? _cbManager;

        public ClipboardManager? CBManager { get => _cbManager; set => Set(ref _cbManager, value); }

        #endregion

        #region TManager

        private TagsManager? _tManager;

        public TagsManager? TManager { get => _tManager; set => Set(ref _tManager, value); }

        #endregion

        // Commands

        #region AddNewTagCommand

        public ICommand AddNewTagCommand { get; }

        private bool CanAddNewTagCommandExecute(object p) => true;

        private void OnAddNewTagCommandExecuted(object p)
        {
            var props = (object[])p;
            string name = (string)props[0];
            string visibility = props[1].ToString();

            bool added = TManager.AddNewTag(name);
            if (added && visibility == "Visible") HideForm();
        }

        #endregion

        #region AddTagCommand

        public ICommand AddTagCommand { get; }

        private bool CanAddTagCommandExecute(object p) => true;

        private void OnAddTagCommandExecuted(object p)
        {
            var props = ((object[])p);
            string tag = (string)props[0];
            bool check = (bool)props[1];

            TManager.AddToCheckedIfActive(tag, check);
            TManager.MakeTagString();
            CBManager.CopyTags(TManager.TagsString);
            TManager.TagsString = string.Empty;
        }

        #endregion

        #region BackToTagsCommand

        public ICommand BackToTagsCommand { get; }

        private bool CanBackToTagsCommandExecute(object p) => true;

        private void OnBackToTagsCommandExecuted(object p)
        {
            var visibility = p.ToString();

            if (visibility == "Visible") HideForm();
        }

        #endregion

        #region OpenTagFormCommand

        public ICommand OpenTagFormCommand { get; }

        private bool CanOpenTagFormCommandExecute(object p) => true;

        private void OnOpenTagFormCommandExecuted(object p)
        {
            if (p.ToString() == "Visible") ShowForm();
        }

        #endregion

        #region RemoveTagCommand

        public ICommand RemoveTagCommand { get; }

        private bool CanRemoveTagCommandExecute(Object p) => true;

        private void OnRemoveTagCommandExecuted(Object p)
        {
            var props = (object[])p;
            string name = (string)props[0];
            bool check = (bool)props[1];

            if (check) TManager.RemoveTag(name);
        }

        #endregion

        public TagsViewModel()
        {
            AddNewTagCommand = new LambdaCommand(OnAddNewTagCommandExecuted, CanAddNewTagCommandExecute);
            AddTagCommand = new LambdaCommand(OnAddTagCommandExecuted, CanAddTagCommandExecute);
            BackToTagsCommand = new LambdaCommand(OnBackToTagsCommandExecuted, CanBackToTagsCommandExecute);
            OpenTagFormCommand = new LambdaCommand(OnOpenTagFormCommandExecuted, CanOpenTagFormCommandExecute);
            RemoveTagCommand = new LambdaCommand(OnRemoveTagCommandExecuted, CanRemoveTagCommandExecute);

            CBManager = new ClipboardManager();
            TManager = new TagsManager();

            _addTagFormVisibility = "Collapsed";
            _mainGridVisibility = "Visible";
        }

        private void ShowForm()
        {
            MainGridVisibility = "Collapsed";
            OnPropertyChanged(nameof(MainGridVisibility));
            AddTagFormVisibility = "Visible";
            OnPropertyChanged(nameof(AddTagFormVisibility));
        }
        private void HideForm()
        {
            MainGridVisibility = "Visible";
            OnPropertyChanged(nameof(MainGridVisibility));
            AddTagFormVisibility = "Collapsed";
            OnPropertyChanged(nameof(AddTagFormVisibility));
        }
    }
}
