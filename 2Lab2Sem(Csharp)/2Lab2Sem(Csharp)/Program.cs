using System;
using System.Diagnostics;

namespace _2Lab2Sem_Csharp_
{
    enum Level { 
    Junior,
    MidLevel,
    Professor
    }

    class Program
    {
        public static void stopWatch(Article[] one, Article[,] two, Article[][] sharp, int row, int column)
        {

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    one[i * row + j] = new Article();
                    two[i, j] = new Article();
                    sharp[i][j] = new Article();
                }
            }

            var sw = new Stopwatch();
            sw.Start();
            var start = sw.ElapsedMilliseconds;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    one[i * row + j].NumberOfCharacter = 4300;
                }
            }

            
            var oneDimensionArr = sw.ElapsedMilliseconds - start;
           
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    two[i, j].NumberOfCharacter = 4300;
                }
            }

            var twoDimensionArr = sw.ElapsedMilliseconds - oneDimensionArr;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sharp[i][j].NumberOfCharacter = 4300;
                }
            }

            sw.Stop();
            var sharpDimensionArr = sw.ElapsedMilliseconds - twoDimensionArr;

            Console.WriteLine($"one Dimension array - { oneDimensionArr}. two Dimension array  - {twoDimensionArr}. Sharp  array  - {sharpDimensionArr}\n row: {row}, column: {column} ");
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            //1
            Copywriter member = new Copywriter();
            Console.WriteLine(member.ToString());
            //2
            member.Person = new Person("Martin", "Goty", new DateTime(2000, 11, 21));
            member.NickName = "Ven";
            member.AuthorRang = Level.Professor;
            member.Rating = 3012;
            member.PublishedArticles = new Article[1069];
            Console.WriteLine(member.ToShortString()+"\n");
            //3
            Copywriter Tos = new Copywriter(new Person("Vas9", "Semonenko", new DateTime(1991, 03, 25)), "Codic", Level.MidLevel, 1643 );
            Console.WriteLine(Tos.ToString()+"\n");
            //4
            Article[] uou = new Article[4];
            uou[0] = new Article("article", 187, new DateTime(191, 06, 1));
            uou[1] = new Article("tail", 376, new DateTime(23, 01, 9));
            uou[2] = new Article("help", 56, new DateTime(1765, 5, 12));
            uou[3] = new Article("info", 3021, new DateTime(2011, 10, 18));
            Tos.AddArticles(uou);
            Tos.AddArticles(uou);
            Console.WriteLine(Tos);
            //5
            Console.WriteLine($"The average number of characters was published in articles by Vas9: {Tos.Average}\n");
            //6
            string enterNumber;
            string[] arrStrNumber;
            Console.WriteLine("Enter number of row and column, separete them by space: \n");
            enterNumber = Console.ReadLine();
            int[] arrSize = new int[enterNumber.Length];

            arrStrNumber = enterNumber.Split(' ');
            for (int i = 0; i < arrStrNumber.Length; i++)
            {
                arrSize[i] = int.Parse(arrStrNumber[i]);
            }
            int row= arrSize[0], column = arrSize[1];
            Article[] oneDimensionArr = new Article[row * column];

            Article[,] twoDimensionArr = new Article[row, column];

            Article[][] sharpArr = new Article[row][];
            for (int i = 0; i < row; i++)
            {
                sharpArr[i] = new Article[column];
            }

            stopWatch(oneDimensionArr, twoDimensionArr, sharpArr, row, column);
        }
    }
}
