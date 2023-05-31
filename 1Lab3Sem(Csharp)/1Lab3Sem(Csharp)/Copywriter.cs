using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab3Sem_Csharp_
{
    class Copywriter : Person, IDateAndCopy
    {
        /*private Person person;
        private string nickName;
        private Level authorRang;
        private int rating;
        private Article[] publishedArticles;*/
        //new
        private string nickName;
        private Level authorRang;
        private int rating;
        private List<Article> publishedArticles;
        private List<Order> order;
        public Copywriter(Person Person, string NickName, Level AuthorRang, int Rating)
            : base(Person.FirstName, Person.LastName, Person.Date)
        {
            nickName = NickName;
            authorRang = AuthorRang;
            rating = Rating;
            publishedArticles = new List<Article>();
            order = new List<Order>();
        }
        public Copywriter() : base()
        {
            nickName = "BlankNickName";
            authorRang = Level.Junior;
            rating = 0;
            publishedArticles = new List<Article>();
            order = new List<Order>();
        }
        public Person Person
        {
            get => new Person(FirstName, LastName, Date);
            set
            {
                FirstName = value.FirstName;
                LastName = value.LastName;
                Date = value.Date;
            }
        }
        public Article LastArticle
        {
            get
            {
                if (publishedArticles.Count == 0)
                {
                    return null;
                }
                Article last = publishedArticles.Last();
                return last;
            }
        }
        public List<Order> Order
        {
            get => order;
            set => order = value;
        }
        public int Rating
        {
            get => rating;
            set
            {

                if (value <= 0 || value > 5)
                {
                    throw new ArgumentException("value must be more than 0 and less than 5");
                }
                rating = value;
            }
        }
        public int Average
        {

            get
            {
                int count = 0, i = 0;
                if (publishedArticles.Count == 0)
                {
                    return 0;
                }
                else
                {
                    foreach (Article article in publishedArticles)
                    {
                        count += article.NumberOfCharacter;
                        i++;
                    }
                }
                return count / i;
            }
        }

        public void AddArticles(params Article[] articles)
        {
            publishedArticles.AddRange(articles);
        }
        public void AddOrder(params Order[] orders)
        {
            order.AddRange(orders);
        }
        public override string ToString()
        {
            string res = $"Person: {Person} \nNick name of the person:{nickName} \nAuthor rang: {authorRang} \nRatingating of published artical is : {rating}\n";
            if (LastArticle != null)
            {
                res += "Published articals are:";
                foreach (Article publishedArticle in publishedArticles)
                {
                    res += "\n" + publishedArticle.ToString();
                }
            }
            else
            {
                res += "\nAny artical isn't published\n";
            }
            if (order.Count != 0)
            {
                foreach (Order ord in order)
                {
                    res += "\n" + ord.ToString();
                }
                res += "\n";
            }
            else
            {
                res += "\nAny order isn't exists\n\n";
            }
            return res;
        }
        public virtual new string ToShortString()
        {
            return $"Person: {Person} \nNick name of the person: {nickName} \nAuthor rang: {authorRang} \nRatingating of published artical is : {rating} \nAll published artical: {publishedArticles.Count} \nNumber of order: {Order.Count} \n\n";
        }


        public override object DeepCopy()
        {
            Copywriter deepCopy = (Copywriter)this.MemberwiseClone();

            deepCopy.publishedArticles = new List<Article>();
            foreach (Article art in publishedArticles)
            {
                deepCopy.publishedArticles.Add(new Article(art));
            }
            deepCopy.order = new List<Order>();
            foreach (Order ord in order)
            {
                deepCopy.order.Add(new Order(ord));
            }
            return deepCopy;
        }
        public IEnumerable<object> GetEnumeratorArticleAndOrder()
        {
            List<object> collection = new List<object>();
            collection.AddRange(PublishedArticles);
            collection.AddRange(Order);
            foreach (object ob in collection)
            {
                yield return ob;
            }
        }
        public IEnumerable<Order> GetEnumeratorOrder(int n)
        {
            foreach (Order ord in order)
            {
                if (ord.ExecutionTime < n)
                    yield return ord;
            }
        }
        //old
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

        public List<Article> PublishedArticles
        {
            get => publishedArticles;
            set => publishedArticles = value;
        }






    }
}
