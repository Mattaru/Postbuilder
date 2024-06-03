using PBapp.Core;
using PBapp.Data;
using PBapp.Infrastructure.Commands;
using PBapp.MVVM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Windows;
using System.Diagnostics.Eventing.Reader;

namespace PBapp.MVVM.ViewModels
{
    internal class CompositionsViewModel : ObservableObject
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

        #region CheckedTags

        private List<string> _checkedTags = new List<string>();

        public List<string> CheckedTags { get => _checkedTags; set => Set(ref _checkedTags, value); }

        #endregion

        #region IngredientsResult

        private string? _ingredientsResult;

        public string? IngredientsResult { get => _ingredientsResult; set => Set(ref _ingredientsResult, value); }

        #endregion

        #region TagsResult

        private string? _tagsResult;

        public string? TagsResult { get => _tagsResult; set => Set(ref _tagsResult, value); }

        #endregion

        // Commands

        #region AddIngredientCommand

        public ICommand AddIngredientCommand { get; }

        private bool CanAddIngredientCommandExecute(object p) => true;

        private void OnAddIngredientCommandExecuted(object p)
        {
            var props = (object[])p;

            string ingredient = (string)props[0];

            bool check = (bool)props[1];

            foreach (var item in Ingredients)
            {
                if (item.Name == ingredient)
                {
                    if (check) CheckedIngredients.Add(item);
                    else CheckedIngredients.RemoveAt(CheckedIngredients.IndexOf(item));

                    break;
                }
            }

            foreach (var item in CheckedIngredients.OrderBy(x => x.Priority))
            {
                IngredientsResult = IngredientsResult + $"\n\n" + item.Description;
            }

            if (Ingredients is not null)
            {
                Clipboard.SetText(IngredientsResult?.Trim());
                IngredientsResult = string.Empty;
            }
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

            if (check && tag == Tags.ABBDISCLAIMER) CheckedTags.Add(Tags.DISCLAIMER);
            else if (check) CheckedTags.Add(tag);
            else
            {
                if (tag == Tags.ABBDISCLAIMER) CheckedTags.RemoveAt(CheckedTags.IndexOf(Tags.DISCLAIMER));
                else CheckedTags.RemoveAt(CheckedTags.IndexOf(tag));
            }

            foreach (var item in CheckedTags)
            {
                TagsResult = TagsResult + " " + item;
            }

            if (TagsResult is not null)
            {
                Clipboard.SetText(TagsResult?.Trim());
                TagsResult = string.Empty;
            }
        }

        #endregion

        public CompositionsViewModel()
        {
            AddIngredientCommand = new LambdaCommand(OnAddIngredientCommandExecuted, CanAddIngredientCommandExecute);
            AddTagCommand = new LambdaCommand(OnAddTagCommandExecuted, CanAddTagCommandExecute);

            Ingredients = GetData.GetListFromJson(Ingredients);
            CheckedIngredients.Add(new IngredientModel
            {
                Name = string.Empty,
                Description = string.Empty,
                Priority = 100,
            });
            CheckedTags.Add(string.Empty);
        }

        private void CopyResultsToClipboard()
        {
             
            
        }
    }
}
