using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalPhotos.LegacyProject
{
    public class LegacyClass
    {
        public void AppendItem<Tkey, TValue>(Dictionary<Tkey, TValue> fromDictionary,
            Dictionary<Tkey, TValue> toDictionary)
        {
            Dictionary<Tkey, TValue> validItems = GetValidItems(toDictionary, fromDictionary);
            foreach (var item in validItems)
            { 
                if(!toDictionary.ContainsKey(item.Key))
                 toDictionary.Add(item.Key,item.Value); 
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

        }

        public Dictionary<Tkey, TValue> GetValidItems<Tkey, TValue>( Dictionary<Tkey, TValue> fromDictionary, Dictionary<Tkey, TValue> toDictionary)
        {
            var result = new Dictionary<Tkey, TValue>();
            foreach (var item in fromDictionary)
            {
                if(!toDictionary.ContainsKey(item.Key))
                    result.Add(item.Key,item.Value);
            }

            return result;
        }
    }
}
