using PBapp.Core;
using PBapp.Infrastructure.Commands;
using PBapp.Services;
using System;
using System.Windows.Input;

namespace PBapp.MVVM.ViewModels
{
    internal class CompositionsViewModel : ObservableObject
    {
        #region AddIngredientFormVisibility

        private string? _addIngredientFormVisibility;

        public string? AddIngredientFormVisibility { get => _addIngredientFormVisibility; set => Set(ref _addIngredientFormVisibility, value); }

        #endregion

        #region MainGridVisibility

        private string? _mainGridVisibility;

        public string? MainGridVisibility { get => _mainGridVisibility; set => Set(ref _mainGridVisibility, value); }

        #endregion

        #region CBManager

        private ClipboardManager? _cbManager;

        public ClipboardManager? CBManager { get => _cbManager; set => Set(ref _cbManager, value); }

        #endregion

        #region IManager

        private IngredientsManager? _iManager;

        public IngredientsManager? IManager { get => _iManager; set => Set(ref _iManager, value); }

        #endregion

        #region SelectedPriority

        private int _selectedPriority;

        public int SelectedPriority { get => _selectedPriority; set => Set(ref _selectedPriority, value); }

        #endregion

        // Commands

        #region AddNewIngredientCommand

        public ICommand AddNewIngredientCommand { get; }

        private bool CanAddNewIngredientCommandExecute(object p) => true;

        private void OnAddNewIngredientCommandExecuted(object p)
        {
            var props = (object[])p;
            string name = (string)props[0];
            string description = (string)props[1];
            string visibility = props[2].ToString();
            int priority = SelectedPriority;

            bool added = IManager.AddNewIngredient(name, description, priority);
            if (added && visibility == "Visible") HideForm();
        }

        #endregion

        #region AddIngredientCommand

        public ICommand AddIngredientCommand { get; }

        private bool CanAddIngredientCommandExecute(object p) => true;

        private void OnAddIngredientCommandExecuted(object p)
        {
            var props = (object[])p;
            string ingName = (string)props[0];
            bool check = (bool)props[1];

            IManager.AddToCheckedIfActive(ingName, check);
            IManager.MakeIngredientsString();
            CBManager.CopyIngredients(IManager.IngredientsString);
            IManager.IngredientsString = string.Empty;
        }

        #endregion

        #region BackToIngredientsCommand

        public ICommand BackToIngredientsCommand { get; }

        private bool CanBackToIngredientsCommandExecute(object p) => true;

        private void OnBackToIngredientsCommandExecuted(object p)
        {
            var visibility = p.ToString();

            if (visibility == "Visible") HideForm();
        }

        #endregion

        #region OpenIngredientFormCommand

        public ICommand OpenIngredientFormCommand { get; }

        private bool CanOpenIngredientFormCommandExecute(object p) => true;

        private void OnOpenIngredientFormCommandExecuted(object p)
        {
            if (p.ToString() == "Visible") ShowForm();
        }

        #endregion

        #region RemoveIngredientCommand

        public ICommand RemoveIngredientCommand { get; }

        private bool CanRemoveIngredientCommandExecute(Object p) => true;

        private void OnRemoveIngredientCommandExecuted(Object p)
        {
            var props = (object[])p;
            string name = (string)props[0];
            bool check = (bool)props[1];

            if (check) IManager.RemoveIngredient(name);
        }

        #endregion

        public CompositionsViewModel()
        {
            AddNewIngredientCommand = new LambdaCommand(OnAddNewIngredientCommandExecuted, CanAddNewIngredientCommandExecute);
            AddIngredientCommand = new LambdaCommand(OnAddIngredientCommandExecuted, CanAddIngredientCommandExecute);
            BackToIngredientsCommand = new LambdaCommand(OnBackToIngredientsCommandExecuted, CanBackToIngredientsCommandExecute);
            OpenIngredientFormCommand = new LambdaCommand(OnOpenIngredientFormCommandExecuted, CanOpenIngredientFormCommandExecute);
            RemoveIngredientCommand = new LambdaCommand(OnRemoveIngredientCommandExecuted, CanRemoveIngredientCommandExecute);

            CBManager = new();
            IManager = new();

            AddIngredientFormVisibility = "Collapsed";
            MainGridVisibility = "Visible";
        }

        private void ShowForm()
        {
            MainGridVisibility = "Collapsed";
            OnPropertyChanged(nameof(MainGridVisibility));
            AddIngredientFormVisibility = "Visible";
            OnPropertyChanged(nameof(AddIngredientFormVisibility));
        }
        private void HideForm()
        {
            MainGridVisibility = "Visible";
            OnPropertyChanged(nameof(MainGridVisibility));
            AddIngredientFormVisibility = "Collapsed";
            OnPropertyChanged(nameof(AddIngredientFormVisibility));
        }
    }
}
