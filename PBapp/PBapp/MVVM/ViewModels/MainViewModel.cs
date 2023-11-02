using PBapp.Core;
using PBapp.Data;
using PBapp.Infrastructure.Commands;
using PBapp.MVVM.Models;
using System;
using System.Collections.Generic;
using PBapp.MVVM.Views;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace PBapp.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private readonly NewsView? NewsV;

        private readonly CompositionsView? CompositionsV;

        #region Tittle

        private string _title = "";

        public string Title { get => _title; set => Set(ref _title, value); }

        #endregion

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
            SelectNewsViewCommand = new LambdaCommand(OnSelectNewsViewCommandExecuted, CanSelectNewsViewCommandExecute);

            CompositionsV = new CompositionsView();
            NewsV = new NewsView();

            CurrentView = CompositionsV;
        }
    }
}
