using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lab3Sem_Csharp_
{
    // 2Lab3Sem start
    public delegate TKey KeySelector<TKey>(Copywriter cw);
    public delegate void CopywritersChangedHandler<TKey>(object source, CopywritersChangedEventArgs<TKey> args);

    class CopywriterCollection<TKey>
    {
        public string CollectionName { get; set; }
        private Dictionary<TKey, Copywriter> writer = new Dictionary<TKey, Copywriter>();
        private KeySelector<TKey> selector;

        public Dictionary<TKey, Copywriter> Collection
        {
            get => writer;
            set => writer = value;
        }

        public event CopywritersChangedHandler<TKey> CopywritersChanged;

        public CopywriterCollection(KeySelector<TKey> selector)
        {
            this.selector = selector;
        }
        private void OnPropertyChanged(object source, PropertyChangedEventArgs args)
        {
            CopywritersChanged?.Invoke(source,
                new CopywritersChangedEventArgs<TKey>(CollectionName, Action.Property, args.PropertyName, selector(source as Copywriter)));
        }
        public int Max
        {
            get => writer.Max(x => x.Value.Rating);
        }
        public IEnumerable<IGrouping<Level, KeyValuePair<TKey, Copywriter>>> GroupByLevel
        {
            get => writer.GroupBy(x => x.Value.AuthorRang);
        }
        public IEnumerable<KeyValuePair<TKey, Copywriter>> LevelForm(Level value)
        {
            return writer.Where(x => x.Value.AuthorRang == value);
        }
        public List<Copywriter> DescRating()
        {
            List<Copywriter> res = new List<Copywriter>();
            var seq = writer.OrderByDescending(x => x.Value.Rating);
            foreach (var r in seq)
            {
                res.Add(r.Value);
            }
            return res;
        }
        public void AddDefaults()
        {
            Copywriter w = new Copywriter();
            writer.Add(selector(w), w);
            writer[selector(w)].PropertyChanged += OnPropertyChanged;
            CopywritersChanged?.Invoke(this, new CopywritersChangedEventArgs<TKey>(CollectionName, Action.Add, "Not a property", selector(w)));
        }
        public void AddCopywriter(params Copywriter[] writers){

            foreach (Copywriter w in writers)
            {
                writer.Add(selector(w), w);
                writer[selector(w)].PropertyChanged += OnPropertyChanged;
                CopywritersChanged?.Invoke(this, new CopywritersChangedEventArgs<TKey>(CollectionName, Action.Add, "Not a property", selector(w)));
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (TKey key in writer.Keys)
            {
                s += writer[key].ToString();
            }
            return s;
        }
        public string ToShortString()
        {
            string s = "";
            foreach (TKey key in writer.Keys)
            {
                s += writer[key].ToString();
            }
            return s;
        }
        public bool Remove(Copywriter cw)
        {
            if (writer.ContainsKey(selector(cw))) {
                writer[selector(cw)].PropertyChanged -= OnPropertyChanged;
                writer.Remove(selector(cw));
                CopywritersChanged?.Invoke(this, new CopywritersChangedEventArgs<TKey>(CollectionName, Action.Remove, "Not a property", selector(cw)));

                return true;
            }
            return false;
        }
        
    }
    // 2Lab3Sem end
}
