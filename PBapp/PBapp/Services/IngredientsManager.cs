using PBapp.Core;
using PBapp.Data;
using PBapp.MVVM.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PBapp.Services
{
    internal class IngredientsManager : ObservableObject
    {
        #region Ingredients

        private ObservableCollection<IngredientModel> _ingredients;

        public ObservableCollection<IngredientModel> Ingredients { get => _ingredients; set => Set(ref _ingredients, value); }

        #endregion

        #region IngredientsString

        private string? _ingredientsString = string.Empty;

        public string? IngredientsString { get => _ingredientsString; set => Set(ref _ingredientsString, value); }

        #endregion

        #region CheckedIngredients

        private ObservableCollection<IngredientModel> _checkedIngredients = new();

        public ObservableCollection<IngredientModel> CheckedIngredients { get => _checkedIngredients; set => Set(ref _checkedIngredients, value); }

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

        public bool AddNewIngredient(string name, string description, int priority)
        {
            if (CheckIngredient(name,description,priority))
            {
                Ingredients.Add(new IngredientModel { Name = name, Description = description, Priority = priority });
                OnPropertyChanged(nameof(Ingredients));
                return true;
            }
            return false;
        }

        private void AddToCheckedIngredients(IngredientModel ingredientName)
        {
            CheckedIngredients.Add(ingredientName);
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

        private bool CheckIngredientName(string name)
        {
            if (name == string.Empty) return false;
            return true;
        }

        private bool CheckIngredientDescription(string description)
        {
            if (description == string.Empty) return false;
            return true;
        }

        private bool CheckIngredientPriority(int priority)
        {
            { if (priority < 0 || priority > 4) return false; }
            return true;
        }

        private bool CheckIngredient(string name, string description, int priority)
        {
            if (CheckIngredientName(name) && CheckIngredientDescription(description) && CheckIngredientPriority(priority)) return true;
            return false;
        }

        public void RemoveIngredient(string ingredientName)
        {
            foreach (var item in Ingredients)
            {
                if (item.Name == ingredientName)
                {
                    Ingredients.Remove(item);
                    OnPropertyChanged(nameof(Ingredients));
                    break;
                }
            }
        }

        private void RemoveFromCheckedIngredients(IngredientModel ingredientName)
        {
            CheckedIngredients.RemoveAt(CheckedIngredients.IndexOf(ingredientName));
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
