using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lab3Sem_Csharp_
{
    public class CopywritersChangedEventArgs<TKey> : EventArgs
    {
        public string CollectionName { get; set; }
        public Action Act { get; set; }
        public string Property { get; set; }
        public TKey Key { get; set; }
        public CopywritersChangedEventArgs (string collectionName, Action act, string property, TKey key){
            CollectionName = collectionName;
            Act = act;
            Property = property;
            Key = key;
        }
        public override string ToString()
        {
            return $"Name of collection: {CollectionName}, ACtion type: {Act}, Property type:{Property}, Key: {Key} ";
        }
    }
}
