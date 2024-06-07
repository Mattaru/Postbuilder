using PBapp.Core;
using PBapp.Infrastructure.Commands;
using PBapp.Services;
using System.Windows.Input;

namespace PBapp.MVVM.ViewModels
{
    internal class CompositionsViewModel : ObservableObject
    {
        #region CBManager

        private ClipboardManager? _cbManager;

        public ClipboardManager? CBManager { get => _cbManager; set => Set(ref _cbManager, value); }

        #endregion

        #region IManager

        private IngredientsManager? _iManager;

        public IngredientsManager? IManager { get => _iManager; set => Set(ref _iManager, value); }

        #endregion

        #region TManager

        private TagsManager? _tManager;

        public TagsManager? TManager { get => _tManager; set => Set(ref _tManager, value); }

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

            IManager.AddToCheckedIfActive(ingredient,check);
            IManager.MakeIngredientsString();
            CBManager.CopyIngredients(IManager.IngredientsString);
            IManager.IngredientsString = string.Empty;
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

            TManager.AddToCheckedIfActive(tag,check);
            TManager.MakeTagString();
            CBManager.CopyTags(TManager.TagsString);
            TManager.TagsString = string.Empty;
        }

        #endregion

        public CompositionsViewModel()
        {
            AddIngredientCommand = new LambdaCommand(OnAddIngredientCommandExecuted, CanAddIngredientCommandExecute);
            AddTagCommand = new LambdaCommand(OnAddTagCommandExecuted, CanAddTagCommandExecute);

            CBManager = new ClipboardManager();
            IManager = new IngredientsManager();
            TManager = new TagsManager();
        }
    }
}
