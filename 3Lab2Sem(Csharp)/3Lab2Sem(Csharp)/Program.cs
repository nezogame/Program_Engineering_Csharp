using System;
using System.Diagnostics;

namespace _3Lab2Sem_Csharp_
{
    enum Level
    {
        Junior,
        MidLevel,
        Professor
    }

    class Program
    {

        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Task 1");
            Console.WriteLine("------------------------------------------------------------------------------");
            Person p1 = new Person("Martin", "Goty", new DateTime(2000, 11, 21));
            Person p2 = new Person("Martin", "Goty", new DateTime(2000, 11, 21));
            Console.WriteLine(ReferenceEquals(p1,p2));
            Console.WriteLine($"{p1.Equals(p2)} \nHash code of p1: {p1.GetHashCode()} \nHash code of p2: {p2.GetHashCode()}");
            Console.WriteLine("------------------------------------------------------------------------------");
            //2
            Console.WriteLine("Task 2");
            Console.WriteLine("------------------------------------------------------------------------------");

            Copywriter copywriterNew = new Copywriter(new Person("Vas9", "Semonenko", new DateTime(1991, 03, 25)), "Codic", Level.MidLevel, 1643);
            copywriterNew.AddArticles(new Article("Article", 230, new DateTime(1991, 09, 7)));
            copywriterNew.AddArticles(new Article("Cool story", 500, new DateTime(2011, 10, 18)));
            copywriterNew.AddOrder(new Order("Tail", new DateTime(191, 06, 1), 72));
            copywriterNew.AddOrder(new Order("Help", new DateTime(1765, 5, 12), 12));
            Console.WriteLine(copywriterNew);
            Console.WriteLine("------------------------------------------------------------------------------");
            //3
            Console.WriteLine("Task 3");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine(copywriterNew.ToShortString());
            Console.WriteLine("------------------------------------------------------------------------------");
            //4
            Console.WriteLine("Task 4");
            Console.WriteLine("------------------------------------------------------------------------------");
            Copywriter DeepCopyCopiwriter = (Copywriter)copywriterNew.DeepCopy();
            copywriterNew.FirstName = "CAPSOM LYTSHE WIDNO";
            copywriterNew.PublishedArticles[0].ArticleName = "MANGA";
            copywriterNew.PublishedArticles[0].DateOfPublication = new DateTime(1, 1, 1);
            copywriterNew.AuthorRang = Level.Professor;
            Console.WriteLine("Original Copywriter: \n"+ copywriterNew);
            Console.WriteLine("\n");
            Console.WriteLine("DeepCopy of Copywriter: \n"+ DeepCopyCopiwriter);
            Console.WriteLine("------------------------------------------------------------------------------");
            //5
            Console.WriteLine("Task 5");
            Console.WriteLine("------------------------------------------------------------------------------");
            try
            {
                copywriterNew.Rating = 12;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            //6
            Console.WriteLine("Task 6");
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (object obj in copywriterNew.GetEnumeratorArticleAndOrder())
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            //7
            Console.WriteLine("Task 7");
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (Order ord in copywriterNew.GetEnumeratorOrder(48))
            { 
                Console.WriteLine(ord);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("------------------------------------------------------------------------------");



            
            
        }
    }
}
