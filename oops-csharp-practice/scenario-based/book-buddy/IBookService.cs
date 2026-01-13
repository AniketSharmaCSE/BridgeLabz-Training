using System;

public interface IBookService
{
    void AddBook(string title, string author);
    void SortBooksAlphabetically();
    void SearchByAuthor(string author);
    void DisplayAllBooks();

}
