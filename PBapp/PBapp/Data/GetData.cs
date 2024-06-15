using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace PBapp.Data
{
    internal class GetData
    {
        public const string INGREDIENTSPATH = "./Data/ingredients.json";
        public const string TAGSPATH = "./Data/tags.json";

        public static ObservableCollection<T> GetListFromJson<T>(ObservableCollection<T> list, string jsonPath)
        {
            using (StreamReader r = new StreamReader(jsonPath))
            {
                string json = r.ReadToEnd();
                list = JsonConvert.DeserializeObject<ObservableCollection<T>>(json);
            }

            return list;
        }

        public static void WriteToJson<T>(ObservableCollection<T> list, string jsonPath)
        {
            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(list));
        }
    }
}

