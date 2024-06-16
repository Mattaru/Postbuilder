using System.Collections.ObjectModel;

namespace PBapp.Data.Collections
{
    class ModelPrioritys : ObservableCollection<int>
    {
       public ModelPrioritys()
        {
            Add(0);
            Add(1);
            Add(2);
            Add(3);
            Add(4);
        }
    }
}
