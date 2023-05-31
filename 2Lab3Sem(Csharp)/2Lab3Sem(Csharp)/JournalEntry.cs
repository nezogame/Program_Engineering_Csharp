using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lab3Sem_Csharp_
{

    class JournalEntry
    {
        public string CollectionWhereEvent { get; set; }
        public string ActionType { get; set; }
        public string PropertyType { get; set; }
        public string Key { get; set; }
        public JournalEntry(string collectionWhereEvent, string actionType, string propertyType, string key)
        {
            CollectionWhereEvent = collectionWhereEvent;
            ActionType = actionType;
            PropertyType = propertyType;
            Key = key;
        }
        public override string ToString()
        {
            return $"Collection where are event occurred: {CollectionWhereEvent}, a type of action: {ActionType}, Property type:{PropertyType}, Key: {Key} ";
        }
    }
}
