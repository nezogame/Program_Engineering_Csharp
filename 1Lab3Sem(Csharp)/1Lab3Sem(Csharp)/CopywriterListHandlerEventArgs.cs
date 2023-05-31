using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1Lab 3Sem
namespace _1Lab3Sem_Csharp_
{
    class CopywriterListHandlerEventArgs: EventArgs
    {

        public string CollectionName { get; set; }
        public string ChangeInCollection { get; set; }
        //?
        public Copywriter ChangeObj { get; set; }

        public CopywriterListHandlerEventArgs(string CollectionName, string ChangeInCollection, Copywriter ChangeObj)
        {
            this.CollectionName = CollectionName;
            this.ChangeInCollection = ChangeInCollection;
            this.ChangeObj = ChangeObj;
        }
        public CopywriterListHandlerEventArgs()
        {
            this.CollectionName = "Some Collection";
            this.ChangeInCollection = "Some change";
            this.ChangeObj = new Copywriter() ;
        }
        public override string ToString()
        {
            return $"Collection name: {CollectionName}, change in collection: {ChangeInCollection}, Object that was changed: {ChangeObj.ToShortString()}.";
        }
            // end  1Lab 3Sem
    }
}
