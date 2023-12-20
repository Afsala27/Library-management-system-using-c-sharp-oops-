using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

class Book {
    public string Title ;
    public string Author ;
    public int BookId ;
    public int Quantity;

    public Book(string title, string author, int bookId, int quantity) {
        Title = title;
        Author = author;
        BookId = bookId;
        Quantity = quantity;
    }

    public override string ToString() {
        return $"Title: {Title}, Author: {Author}, Book id : {BookId}, Quantity: {Quantity}";
    }
}

class User {
    public string Name ;
    public int ID ;

    public User(string uname, int uID) {
        Name = uname;
        ID = uID;
    }

    public override string ToString() {
        return $"Name: {Name}, ID: {ID}";
    }
}

class Library {
    private List<Book> books;
    private List<User> users;

    public Library() {
        books = new List<Book>();

        users = new List<User>();
    }

    public void AddBook(Book book) {
        books.Add(book);
    }

    public void DisplayBooks() {
        foreach (var book in books) {
            Console.WriteLine(book);
        }
    }

    public void AddUsers(User user) {
        users.Add(user);
    }

    public void DisplayUsers() {
        foreach (var user in users) {
            Console.WriteLine(user);
        }
    }

    public void BorrowBooks(string bname) {
        foreach (var i in books){
        if (i.Title == bname && i.Quantity > 0){
            Console.WriteLine("The " + i.Title + " is borrowed");
            i.Quantity --;
        } else if(i.Title != bname || i.Quantity <= 0) {
            Console.WriteLine("The " + i.Title + " is not available ath this time");
        }
        }
    }
    public void SubmitBooks(string bname) {
        foreach (var i in books){
        if (i.Quantity >= 0 && i.Quantity <= i.Quantity){
            Console.WriteLine("The " + i.Title + " is submitted");
            i.Quantity ++;
        } else if(i.Quantity > i.Quantity) {
            Console.WriteLine("That action is not possible");
        } else {
            Console.WriteLine("Please try again");
        }
        }
    }
}

class Program {
    static void Main(string[] args) {
        Library library = new Library();

        for (int a=0; a<8; a++){
        Console.WriteLine("Select options from menu:");
        Console.WriteLine(@"
        1. Add Book
        2. Display Book
        3. Add User
        4. Display User
        5. Borrow Book
        6. Submit Book
        7. Exit");
        Console.WriteLine("Enter your option:");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num == 1){

        string  bookname, bookauthorname;
        int bookid, bookquantity;

        Console.WriteLine("Enter your Limit:");
        int n = Convert.ToInt32(Console.ReadLine());

        for(int i =0; i<n; i++){
        Console.WriteLine("Press enter to add book");
        Console.WriteLine("Book Name:");
        bookname = Console.ReadLine();
        Console.WriteLine("Author Name:");
        bookauthorname = Console.ReadLine();
        Console.WriteLine("Book ID:");
        bookid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Book quantity:");
        bookquantity = Convert.ToInt32(Console.ReadLine());

        library.AddBook(new Book(bookname, bookauthorname, bookid, bookquantity));
        }
        } else if(num == 2) {

            library.DisplayBooks();

        } else if(num == 3){

        string username;
        int userid;

        Console.WriteLine("Enter your Limit:");
        int b = Convert.ToInt32(Console.ReadLine());

        for(int j =0; j<b; j++){
        Console.WriteLine("Press enter the user details:");
        Console.WriteLine("Enter User Name:");
        username = Console.ReadLine();
        Console.WriteLine("Enter user id:");
        userid = Convert.ToInt32(Console.ReadLine());
        library.AddUsers(new User(username, userid ));
        }
        } else if(num == 4){
         library.DisplayUsers();
        } else if(num == 5){
            string bname1;

            library.DisplayBooks();
            Console.WriteLine("Enter your book title");
            bname1 = Console.ReadLine();

            library.BorrowBooks(bname1);
        } else if(num == 6){
            string bname2;
            library.DisplayBooks();
            Console.WriteLine("Enter your book title");
            bname2 = Console.ReadLine();
            library.SubmitBooks(bname2);
        } else if(num == 7){
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        } else {
            Console.WriteLine("That action is not possible");
        }
        }
    }
}
