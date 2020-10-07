using System;

namespace blazorcore.Models
{

    public class Article
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublishDate { get; set; }
        public string TickerCode { get; set; }
        public string TickerFullName { get; set; }
        public bool IsPremium { get; set; }
        public bool IsMergerArbitrage { get; set; }

    }

}
