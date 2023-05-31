using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab3Sem_Csharp_
{
    //1Lab 3Sem
    class JournalEntry
    {

        public string CollectionWhereEvent { get; set; }
        public string ChangesType { get; set; }
        public string CopywriterData { get; set; }
        public JournalEntry() {
            CollectionWhereEvent = "Some collection";
            ChangesType = "Some change";
            CopywriterData = "Some data";
        }
        public JournalEntry(string CollectionWhereEvent, string ChangesType, string CopywriterData) {
            this.CollectionWhereEvent = CollectionWhereEvent;
            this.ChangesType = ChangesType;
            this.CopywriterData = CopywriterData;
        }
        public override string ToString()
        {
            return $"Collection where are event occurred: {CollectionWhereEvent}, a type of changes: {ChangesType}, the object of Copywriter with which changes in the collection are linked: {CopywriterData}";
        }
    }
}
