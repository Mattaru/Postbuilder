using PBapp.Core;
using PBapp.Data;
using PBapp.MVVM.Models;
using System.Collections.Generic;
using System.Linq;

namespace PBapp.Services
{
    internal class IngredientsManager : ObservableObject
    {
        #region Ingredients

        private List<IngredientModel> _ingredients;

        public List<IngredientModel> Ingredients { get => _ingredients; set => Set(ref _ingredients, value); }

        #endregion

        #region IngredientsString

        private string? _ingredientsString = string.Empty;

        public string? IngredientsString { get => _ingredientsString; set => Set(ref _ingredientsString, value); }

        #endregion

        #region CheckedIngredients

        private List<IngredientModel> _checkedIngredients = new();

        public List<IngredientModel> CheckedIngredients { get => _checkedIngredients; set => Set(ref _checkedIngredients, value); }

        #endregion

        public IngredientsManager() 
        {
            Ingredients = GetData.GetListFromJson(Ingredients, GetData.INGREDIENTSPATH);
            CheckedIngredients.Add(new IngredientModel
            {
                Name = string.Empty,
                Description = string.Empty,
                Priority = 100,
            });
            
        }

        public List<IngredientModel> GetOrderedChechedIngredients()
        {
            return CheckedIngredients.OrderBy(x => x.Priority).ToList();
        }

        private void AddToCheckedIngredients(IngredientModel ingredientName)
        {
            CheckedIngredients.Add(ingredientName);
        }

        private void RemoveFromCheckedIngredients(IngredientModel ingredientName)
        {
            CheckedIngredients.RemoveAt(CheckedIngredients.IndexOf(ingredientName));
        }

        public void AddToCheckedIfActive(string ingredientName, bool check)
        {
            foreach (var item in Ingredients)
            {
                if (item.Name == ingredientName)
                {
                    if (check) AddToCheckedIngredients(item);
                    else RemoveFromCheckedIngredients(item);

                    break;
                }
            }
        }

        public void MakeIngredientsString()
        {
            foreach (var item in GetOrderedChechedIngredients())
            {
                IngredientsString += $"\n\n" + item.Description;
            }
        }
    }
}
