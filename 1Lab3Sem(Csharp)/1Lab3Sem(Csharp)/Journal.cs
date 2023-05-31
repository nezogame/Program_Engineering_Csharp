using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab3Sem_Csharp_
{
    class Journal
    {
        private List<JournalEntry> journal = new List<JournalEntry>();



        public void OnCopywritersCountChanged(object source, CopywriterListHandlerEventArgs args)
        {
            journal.Add(new JournalEntry(args.CollectionName, args.ChangeInCollection, args.ChangeObj.ToShortString()));
        }
        public void OnCopywriterReferenceChanged(object source, CopywriterListHandlerEventArgs args)
        {
            journal.Add(new JournalEntry(args.CollectionName, args.ChangeInCollection, args.ChangeObj.ToShortString()));
        }

        public override string ToString()
        {
            string res = "";
            if (journal.Count != 0)
            {
                res += "Journal content:\n";
                foreach (JournalEntry j in journal)
                {
                    res += j.ToString();
                }
            }
            else
            {
                res += "Journal is empty";
            }
            return res;
        }

    }
}
