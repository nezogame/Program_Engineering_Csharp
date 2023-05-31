using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Lab2Sem_Csharp_
{

    class CopywriterCollection 
    {
        private List<Copywriter> writer;
        public void addDefaults()
        {
            writer = new List<Copywriter>();
            writer.Add(new Copywriter());
        }
        public void addCopywriter(params Copywriter[] writers)
        {

            foreach (Copywriter copWrit in writers){
                writer.Add(copWrit);
            }
        }
        public override string ToString()
        {
            string res="";
            if (writer.Count != 0) {
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
        public  string ToShortString()
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
