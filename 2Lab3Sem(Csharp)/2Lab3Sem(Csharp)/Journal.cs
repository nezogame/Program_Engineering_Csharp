using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lab3Sem_Csharp_
{
    class Journal
    {
        private List<JournalEntry> journals = new List<JournalEntry>();

        public void CopywritersChanged(object source, CopywritersChangedEventArgs<string> args)
        {
            journals.Add(new JournalEntry(args.CollectionName, args.Act.ToString(), args.Property, args.Key));
        }
        public override string ToString()
        {
            string res = "";
            if (journals.Count != 0)
            {
                res += "Journal content:\n";
                foreach (JournalEntry j in journals)
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
