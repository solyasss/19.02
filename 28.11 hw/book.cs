namespace hw
{
    public partial class Book
    {
        public int BookId { get; set; }     
        public string Title { get; set; }   
        public int AuthorId { get; set; }   
        public virtual Author Author { get; set; }
    }
}