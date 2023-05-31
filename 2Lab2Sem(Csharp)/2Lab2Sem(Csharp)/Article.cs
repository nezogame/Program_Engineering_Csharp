using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lab2Sem_Csharp_
{
    class Article
    {
        public string ArticleName { get; set; }
        public int NumberOfCharacter { get; set; }
        public DateTime DateOfPublication{ get; set; }

        public Article (string ArticleName, int NumberOfCharacter, DateTime DateOfPublication)
        {
            this.ArticleName = ArticleName;
            this.NumberOfCharacter = NumberOfCharacter;
            this.DateOfPublication = DateOfPublication;
        }
        public Article()
        {
            ArticleName = "Document";
            NumberOfCharacter = 2000;
            DateOfPublication = new DateTime(2022, 5, 3, 6,00,00);
        }
        public override string ToString()
        {
            return $"Name of the artical: {ArticleName} \nNumber of character in the artical: {NumberOfCharacter} \nArtical is publicated at: {DateOfPublication}\n\n";
        }
    }
}
