using System;
using System.ComponentModel.DataAnnotations;

namespace WpfBlazorBooks.Data
{
    public sealed record Book()
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime Published { get; set; } = DateTime.Now;

        public Book(string title, string author, DateTime published) : this()
        {
            Title = title;
            Author = author;
            Published = published;
        }
    }
}
