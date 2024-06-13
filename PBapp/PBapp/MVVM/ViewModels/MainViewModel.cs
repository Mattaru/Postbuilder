using PBapp.Core;
using PBapp.Infrastructure.Commands;
using System;
using PBapp.MVVM.Views;
using System.Windows.Input;

namespace PBapp.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private readonly NewsView? NewsV;

        private readonly TagsView? TagsV;

        private readonly CompositionsView? CompositionsV;

        #region Current view

        static object? _currentView;

        public object? CurrentView { get => _currentView; set => Set(ref _currentView, value); }

        #endregion

        // Commands

        #region SelectCompositionsViewCommand

        public ICommand SelectCompositionsViewCommand { get; }

        private bool CanSelectCompositionsViewCommandExecute(object p)
        {
            if (CurrentView is CompositionsView)
                return false;
            return true;
        }

        private void OnSelectCompositionsViewCommandExecuted(object p)
        {
            CurrentView = CompositionsV;
            OnPropertyChanged(nameof(CurrentView));
        }

        #endregion

        #region SelectTagsViewCommand

        public ICommand SelectTagsViewCommand { get; }

        private bool CanSelectTagsViewCommandExecute(object p)
        {
            if (CurrentView is TagsView)
                return false;
            return true;
        }

        private void OnSelectTagsViewCommandExecuted(Object p)
        {
            CurrentView = TagsV;
            OnPropertyChanged(nameof(CurrentView));
        }

        #endregion

        #region SelectNewsViewCommand

        public ICommand SelectNewsViewCommand { get; }

        private bool CanSelectNewsViewCommandExecute(object p)
        {
            if (CurrentView is NewsView)
                return false;
            return true;
        }

        private void OnSelectNewsViewCommandExecuted(object p)
        {
            CurrentView = NewsV;
            OnPropertyChanged(nameof(CurrentView));
        }

        #endregion

        public MainViewModel()
        {
            SelectCompositionsViewCommand = new LambdaCommand(OnSelectCompositionsViewCommandExecuted, CanSelectCompositionsViewCommandExecute);
            SelectTagsViewCommand = new LambdaCommand(OnSelectTagsViewCommandExecuted, CanSelectTagsViewCommandExecute);
            SelectNewsViewCommand = new LambdaCommand(OnSelectNewsViewCommandExecuted, CanSelectNewsViewCommandExecute);

            CompositionsV = new CompositionsView();
            TagsV = new TagsView();
            NewsV = new NewsView();

            CurrentView = CompositionsV;
        }
    }
}
