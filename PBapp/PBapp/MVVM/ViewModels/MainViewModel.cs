﻿using PBapp.Core;
using PBapp.Data;
using PBapp.Infrastructure.Commands;
using PBapp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace PBapp.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        #region Ingredients

        private List<IngredientModel> _ingredients = new List<IngredientModel>();

        public List<IngredientModel> Ingredients { get => _ingredients; set => Set(ref _ingredients, value); }

        #endregion

        #region Tittle

        private string _title = "";

        public string Title { get => _title; set => Set(ref _title, value); }

        #endregion

        #region CheckedIngredients

        private List<IngredientModel> _checkedIngredients = new List<IngredientModel>();

        public List<IngredientModel> CheckedIngredients { get => _checkedIngredients; set => Set(ref _checkedIngredients, value); }

        #endregion

        #region Result

        private string? _result;

        public string? Result { get => _result; set => Set(ref _result, value); }

        #endregion

        // Commands

        #region AddIngredientCommand

        public ICommand AddIngredientCommand { get;  }

        private bool CanAddIngredientCommandExecute(object p) => true;

        private void OnAddIngredientCommandExecuted(object p)
        {
            var values = (object[])p;

            string ingredient = (string)values[0];

            bool check = (bool)values[1];

            foreach (var item in Ingredients)
            {
                if (item.Name == ingredient)
                {
                    if (check) CheckedIngredients.Add(item);
                    else CheckedIngredients.RemoveAt(CheckedIngredients.IndexOf(item));

                    break;
                }
            }
        }

        #endregion

        #region CopyToClipBoardCommand

        public ICommand CopyToClipBoardCommand { get; }

        private bool CanCopyToClipBoardCommandExecute(object p) => true;

        private void OnCopyToClipBoardCommandExecuted(object p)
        {
            var i = CheckedIngredients.OrderBy(x => x.Priority);

            foreach (var item in i)
            {
                Result = Result + $"\n\n" + item.Description;
            }

            if (Result is not null) Clipboard.SetText(Result.Trim());

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

            Ingredients = GetData.GetListFromJson(Ingredients);
            CheckedIngredients.Add(new IngredientModel
            {
                Name = string.Empty,
                Description = string.Empty,
                Priority = 4,
            });
        }
    }
}
