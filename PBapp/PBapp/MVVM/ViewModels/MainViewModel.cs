using PBapp.Core;
using PBapp.Infrastructure.Commands;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace PBapp.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        #region Tittle

        private string _title = "";

        public string Title { get => _title; set => Set(ref _title, value); }

        #endregion

        private ObservableCollection<string> _ingredients;

        public ObservableCollection<string> Ingredients
        {
            get => _ingredients;

            set => Set(ref _ingredients, value);
        }

        // Commands

        #region AddIngredient

        public ICommand AddIngredient { get;  }

        private bool CanAddIngredientCommandExecute(object p) => true;

        private void OnAddIngredientCommandExecuted(object p)
        {
            var values = (object[])p;

            string ingredient = (string)values[0];

            bool check = (bool)values[1];

            if (check)
            {
                Ingredients.Add(ingredient);
            }
            else
            {
                Ingredients.Remove(ingredient);
            }

        }

        #endregion

        #region CopyToClipBoard

        public ICommand CopyToClipBoard { get; }

        private bool CanCopyToClipBoardCommandExecute(object p) => true;

        private void OnCopyToClipBoardCommandExecuted(object p)
        {
            

        }

        #endregion

        #region CloseAppCommand

        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecute(object p) => true;

        private void OnCloseAppCommandExecuted(object p) => Application.Current.Shutdown();

        #endregion

        public MainViewModel() 
        {
            CloseAppCommand = new LambdaCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);
        }
    }
}
