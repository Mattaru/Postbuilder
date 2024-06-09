using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace PBapp.Data
{
    internal class GetData
    {
        public const string INGREDIENTSPATH = "./Data/ingredients.json";
        public const string TAGSPATH = "./Data/tags.json";

        public static List<T> GetListFromJson<T>(List<T> list, string jsonPath)
        {
            using (StreamReader r = new StreamReader(jsonPath))
            {
                string json = r.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<T>>(json);
            }

            return list;
        }
    }
}

