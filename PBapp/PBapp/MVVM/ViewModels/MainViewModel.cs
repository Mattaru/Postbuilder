using PBapp.Core;
using PBapp.Infrastructure.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace PBapp.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        #region Tittle

        private string _title = "";

        public string Title { get => _title; set => Set(ref _title, value); }

        #endregion

        private List<string> _ingredients = new List<string>();

        public List<string> Ingredients
        {
            get => _ingredients;
            
            set => Set(ref _ingredients, value);
        }

        private string _result;

        public string Result
        {
            get => _result;

            set => Set(ref _result, value);
        }

        // Commands

        #region AddIngredientCommand

        public ICommand AddIngredientCommand { get;  }

        private bool CanAddIngredientCommandExecute(object p) => true;

        private void OnAddIngredientCommandExecuted(object p)
        {
            var values = (object[])p;

            string ingredient = (string)values[0];

            bool check = (bool)values[1];

            if (check)
            {
                Ingredients.Add(ingredient);
                Console.WriteLine(ingredient);
            }
            else
            {
                Ingredients.Remove(ingredient);
            }

        }

        #endregion

        #region CopyToClipBoardCommand

        public ICommand CopyToClipBoardCommand { get; }

        private bool CanCopyToClipBoardCommandExecute(object p) => true;

        private void OnCopyToClipBoardCommandExecuted(object p)
        {
            foreach (var item in Ingredients)
            {
                Result = Result + " " + item;
            }

            Clipboard.SetText(Result.Trim());
            Result = string.Empty;
        }

        #endregion

        #region CloseAppCommand

        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecute(object p) => true;

        private void OnCloseAppCommandExecuted(object p) => Application.Current.Shutdown();

        #endregion

        public MainViewModel()
        { 
            AddIngredientCommand = new LambdaCommand(OnAddIngredientCommandExecuted, CanAddIngredientCommandExecute);
            CopyToClipBoardCommand = new LambdaCommand(OnCopyToClipBoardCommandExecuted, CanCopyToClipBoardCommandExecute);
            CloseAppCommand = new LambdaCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);

            Ingredients.Add("");
        }
    }
}
