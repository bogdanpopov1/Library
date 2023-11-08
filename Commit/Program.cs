Console.WriteLine("Какой жанр книги хотите прочитать?");
string prompt = Console.ReadLine();
Book book_client = null;
if (prompt != null)
    book_client = Library.RentBook(prompt);

Fiction coffee = book_client as Fiction;
Console.WriteLine();

public class Book
{
    public void readBook()
    {
    }
    public void retellBook()
    {
    }
}
public class Fiction : Book { }
public class Classic : Book { }
public class Adventure : Book { }
public class Drama : Book { }
public class Mystery : Book { }

public static class Library
{
    public static Book RentBook(string type)
    {
        Book book = null;

        switch (type)
        {
            case "Fiction":
                book = new Fiction();
                break;
            case "Classic":
                book = new Classic();
                break;
            case "Adventure":
                book = new Adventure();
                break;
            case "Drama":
                book = new Drama();
                break;
            case "Mystery":
                book = new Mystery();
                break;
        }

        Console.WriteLine($"Вот ваша книга жанра {book.GetType()}! Не забудьте вернуть ее в библиотеку!");
        return book;
    }
}