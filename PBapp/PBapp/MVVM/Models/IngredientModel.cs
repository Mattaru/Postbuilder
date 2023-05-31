using PBapp.Core;

namespace PBapp.MVVM.Models
{
    internal class IngredientModel : ObservableObject
    {

        public string Name { get; set; }


        public string Description { get; set; }

        
        public int Priority { get; set; }

    }
}
