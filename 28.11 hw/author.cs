using System.Collections.Generic;

namespace hw
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }    
        public string Name { get; set; }   
        public virtual ICollection<Book> Books { get; set; }
    }
}