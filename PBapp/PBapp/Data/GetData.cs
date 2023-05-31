using Newtonsoft.Json;
using PBapp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PBapp.Data
{
    internal class GetData
    {
        public static List<IngredientModel> GetListFromJson<IngredientModel>(List<IngredientModel> list)
        {
            using (StreamReader r = new StreamReader("Data/ingredients.json"))
            {
                string json = r.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<IngredientModel>>(json);
            }

            return list;
        }
    }
}

