using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lab2Sem_Csharp_
{
    class Copywriter
    {
        private Person person;
        private string nickName;
        private Level authorRang;
        private int rating;
        private Article[] publishedArticles;

        public Person Person {
            get => person;
            set => person = value;
        }
        public string NickName
        {
            get => nickName;
            set => nickName = value;
        }
        public Level AuthorRang
        {
            get => authorRang;
            set => authorRang = value;
        }
        public int Rating
        {
            get => rating;
            set => rating = value;
        }
        public Article[] PublishedArticles
        {
            get => publishedArticles;
            set => publishedArticles = value;
        }
        public Copywriter(Person Person, string NickName, Level AuthorRang, int Rating)
        {
            this.Person = Person;
            this.NickName = NickName;
            this.AuthorRang = AuthorRang;
            this.Rating = Rating;
            publishedArticles = new Article[0];
        }
        public Copywriter()
        {
            Person = new Person();
            NickName = "BlankNickName";
            AuthorRang = Level.Junior;
            Rating = 0;
            publishedArticles = new Article[0];
        }
        
        public int Average
        { 

            get 
            {
                int count = 0;
                int j = 0;
                if (publishedArticles.Length == 0)
                {
                    return 0;
                }
                else
                    for (int i = 0; i < publishedArticles.Length; i++)
                    {

                        count += publishedArticles[i].NumberOfCharacter;
                        j++;
                    }
                return count / j;
            }
        }
        public void AddArticles(params Article[] articles )
        {
            foreach (Article article in articles)
            {
                Array.Resize<Article>(ref publishedArticles, publishedArticles.Length + 1);
                publishedArticles[publishedArticles.Length - 1] = article;
            }  
        }
        public override string ToString()
        {
        string res = $"Person: {person} \nNick name of the person:{nickName} \nAuthor rang: {authorRang} \nRatingating of published artical is : {rating}\n";
            if (Average != 0)
            {
                res += "Published articals are:";
                foreach(Article publishedArticle in publishedArticles)
                {
                    res += "\n"+publishedArticle.ToString();
                }
            }
            else
            {
                res += "\nAny artical aren't published";
            }
            return res;
        }
        public virtual string ToShortString()
        {
            return $"Person: {person} \nNick name of the person: {nickName} \nAuthor rang: {authorRang} \nRatingating of published artical is : {rating} \nAll published artical: {PublishedArticles.Length} \n\n";
        }
    }
}
