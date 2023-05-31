using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab3Sem_Csharp_
{

    class CopywriterCollection
    {
        private List<Copywriter> writer;
        // 1Lab 3Sem 
        //delegate 
        public delegate void CopywriterListHandler(object source, CopywriterListHandlerEventArgs args);
        //delegate end
        public string CollectionName { get; set; }

        public Copywriter this[int index]
        {
            get => writer[index];
            set {
                writer[index] = value;
                CopywriterReferenceChanged?.Invoke(this, new CopywriterListHandlerEventArgs(this.CollectionName, "a refernce was changed", writer[index]));
            }
        }
        // event need to finalize and event thtoweeng should be do
        public event CopywriterListHandler CopywritersCountChanged;
        public event CopywriterListHandler CopywriterReferenceChanged;


        protected virtual void OnCopywriterReferenceChanged(string collectionName, string ChangeInCollection, Copywriter changeObj)
        {
           
        }
        public bool remove(int j)
        {

            if (writer.Count< j)
            {
                return false;
            }
            else
            {
                writer.RemoveAt(j);
                CopywritersCountChanged?.Invoke(this, new CopywriterListHandlerEventArgs(this.CollectionName, "At collection was removed elemnt", writer[j]));

            }

            return true;
        }
        //
        // end  1Lab 3Sem

        public void addDefaults()
        {
            writer = new List<Copywriter>();
            writer.Add(new Copywriter());

            CopywritersCountChanged?.Invoke(this, new CopywriterListHandlerEventArgs(this.CollectionName, "At collection was added elemnt", new Copywriter()));
        }
        public void addCopywriter(params Copywriter[] writers)
        {
            writer = new List<Copywriter>();
            foreach (Copywriter copWrit in writers)
            {
                writer.Add(copWrit);
                CopywritersCountChanged?.Invoke(this, new CopywriterListHandlerEventArgs(this.CollectionName, "At collection was added elemnt", copWrit));

            }

        }
        public override string ToString()
        {
            string res = "";
            if (writer.Count != 0)
            {
                res += "Added articles are:\n";
                foreach (Copywriter w in writer)
                {
                    res += w.ToString();
                }
            }
            else
            {
                res += "Any article was adding";
            }
            return res;
        }
        public string ToShortString()
        {
            string res = "";
            if (writer.Count != 0)
            {
                res += "Added articles are: ";
                foreach (Copywriter w in writer)
                {
                    res += w.ToShortString();
                }
            }
            else
            {
                res += "Any article was adding";
            }
            return res;
        }
        public void sortByLastName()
        {
            writer.Sort();
        }
        public void sortByDateOfBirth()
        {
            writer.Sort(new Person());
        }
        public void sortByRating()
        {
            writer.Sort(new Copywriter());
        }

        public void sortByAverageCherecters()
        {
            writer.Sort(new AverageComparer());

        }
    }
}
