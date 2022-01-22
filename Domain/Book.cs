using System;

namespace LibraryManagement.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string Author { get; set; } 
        public string Category { get; set; }
        public DateTime PublishDate  { get; set; }
    }
}