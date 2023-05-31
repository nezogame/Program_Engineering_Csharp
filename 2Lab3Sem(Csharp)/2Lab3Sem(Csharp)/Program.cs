using System;

namespace _2Lab3Sem_Csharp_
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------ 2 Lab 3 Sem  ----------------------------------
            //1
            Console.WriteLine("Task 1");
            Console.WriteLine("------------------------------------------------------------------------------");
            CopywriterCollection<string> firstCollection = new CopywriterCollection<string>((cw) => cw.ToShortString());
            firstCollection.CollectionName = "FIRST COLLECTION";
            CopywriterCollection<string> secondCollection = new CopywriterCollection<string>((cw) => cw.ToShortString());
            secondCollection.CollectionName = "SECOND COLLECTION";
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Task 2");
            Console.WriteLine("------------------------------------------------------------------------------");

            Journal Jornal = new Journal();
            firstCollection.CopywritersChanged += Jornal.CopywritersChanged;
            secondCollection.CopywritersChanged += Jornal.CopywritersChanged;
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Task 3");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------");

            //---------1
            Copywriter first = new Copywriter(new Person("Vas9", "Semonenko", new DateTime(2034, 03, 25)), "Codic", Level.Professor, 1643);
            first.AddOrder(new Order(), new Order(), new Order(), new Order());
            first.AddArticles(new Article(), new Article(), new Article());
            Copywriter second = new Copywriter(new Person("CAPSOM LYTSHE WIDNO", "Tail", new DateTime(1912, 08, 15)), "Codic", Level.MidLevel, 478);
            second.AddOrder(new Order(), new Order());
            second.AddArticles(new Article(), new Article());
            Copywriter third = new Copywriter(new Person("Martin", "Aoty", new DateTime(1981, 01, 1)), "Codic", Level.Junior, 14);
            third.AddOrder(new Order());
            third.AddArticles(new Article());
            Copywriter four = new Copywriter(new Person("Fast", "Man", new DateTime(231, 03, 25)), "Moric", Level.Professor, 1500);
            first.AddOrder(new Order(), new Order(), new Order(), new Order());
            first.AddArticles(new Article(), new Article(), new Article());

            firstCollection.AddCopywriter(first, second, third, four);
            firstCollection.AddDefaults();
            
            secondCollection.AddCopywriter(first, second, third);

            //----------2
            firstCollection.Collection[new Copywriter().ToShortString()].NickName = "New Funny Nick";
            firstCollection.Collection[new Copywriter().ToShortString()].YearOfBirth = 2022;

            //----------3
            secondCollection.Remove(third);
            //----------4
            third.Rating = 3;

            Console.WriteLine("Task 4");



            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine($"\n\n/*/*/*/*JORNAL/*/*/*/*/\n{Jornal}\n/*/*/*/*END JORNAL/*/*/*/*/");


            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Task 5");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine(firstCollection.Max);
            foreach (var c in firstCollection.LevelForm(Level.Junior))
            {
                Console.WriteLine(c);
                Console.WriteLine("===================");
            }
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            foreach (var c in firstCollection.GroupByLevel)
            {
                Console.WriteLine($"{c.Key}:");
                foreach (var p in c)
                {
                    Console.WriteLine(p);
                }
                
                    Console.WriteLine("//////===================////////");
            }
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            foreach (var c in firstCollection.DescRating())
            {

                    Console.WriteLine(c.ToShortString());
                    Console.WriteLine("===================");
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}
