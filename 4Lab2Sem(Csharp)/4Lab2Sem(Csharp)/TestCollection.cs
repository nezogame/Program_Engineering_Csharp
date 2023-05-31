using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Lab2Sem_Csharp_
{
    class TestCollection
    {
        List<Person> list;
        List<string> info;
        Dictionary<Person, Copywriter> firstDictionary;
        Dictionary<string, Copywriter> secondDictionary;
        static Copywriter autoGeneration (int x)
        {
            Copywriter writer = new Copywriter();
            writer.FirstName += x;
            writer.LastName += x;
            writer.Date =  writer.Date.AddDays(x);
            writer.NickName += x;
            return writer;
        }
        public TestCollection(int nummberOfColection)
        {

            list = new List<Person>();
            info = new List<string>();
            firstDictionary=new Dictionary<Person, Copywriter>();
            secondDictionary=new Dictionary<string, Copywriter>();
            Copywriter auto;
            for (int i = 0; i < nummberOfColection; i++)
            {
                auto = autoGeneration(i);
                list.Add(auto.Person);
                info.Add(auto.NickName);
                firstDictionary.Add(auto.Person, auto);
                secondDictionary.Add(auto.NickName, auto);
            }

        }
        public void stopWatch (int element)
        {

            Console.WriteLine($"\nFinding {element} element of collections:\n");
            Stopwatch timer = new Stopwatch();
            Copywriter writer = autoGeneration(element);
            bool res;

            timer.Start();
            res = list.Contains(writer.Person);
            timer.Stop();
            Console.WriteLine($"Finding element in List<Person> ending by {timer.Elapsed} with result: {res}\n");

            timer.Start();
            res = info.Contains(writer.NickName);
            timer.Stop();
            Console.WriteLine($"Finding element in List<string> ending by {timer.Elapsed} with result: {res}\n");

            timer.Start();
            res = firstDictionary.ContainsKey(writer.Person);
            timer.Stop();
            Console.WriteLine($"Finding element in Dictionary<Person, Copywriter> by /-/-/KEY/-/-/ ending by {timer.Elapsed} with result: {res}\n");

            timer.Start();
            res = secondDictionary.ContainsKey(writer.NickName);
            timer.Stop();
            Console.WriteLine($"Finding element in Dictionary<string, Copywriter> by /-/-/KEY/-/-/ ending by {timer.Elapsed} with result: {res}\n");

            timer.Start();
            res = firstDictionary.ContainsValue(writer);
            timer.Stop();
            Console.WriteLine($"Finding element in Dictionary<Person, Copywriter> by /-/-/VALUE/-/-/ ending by {timer.Elapsed} with result: {res}\n");

            timer.Start();
            res = secondDictionary.ContainsValue(writer);
            timer.Stop();
            Console.WriteLine($"Finding element in Dictionary<string, Copywriter> by /-/-/VALUE/-/-/ ending by {timer.Elapsed} with result: {res}\n");

            
        }



    }
}
