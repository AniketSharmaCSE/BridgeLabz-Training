class GenreNode
{
    public string genre;
    public BookLinkedList bookList;

    public GenreNode(string genre)
    {
        this.genre = genre;
        this.bookList = new BookLinkedList();
    }
}
