using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotektemp
{
    public class BookHandler
    {
        public class Handlebook
        {
            
            //låna bok funktionen,tar reda på den inloggade användaren och lägger boken i dens lista
            public static void RentBook(Book book, Person User, List<Book> BookList, List<Person> UserList, bool UserisRenting)
            {
                if (User.RentedBooks != null)
                {
                    foreach (Book Book in User.RentedBooks)
                    {
                        if (Book.Serienummer == Book.Serienummer)
                        {
                            UserisRenting = true;
                            break;
                        }
                    }
                }
                if (UserisRenting == false)
                {
                    Person loggedInUser = UserList.FirstOrDefault(u => u.personnummer == User.personnummer)!;

                    Book rentedBook = new(book.Titel!, book.Serienummer, book.Författare, book.Antal);

                    book.Ledig = false;

                    loggedInUser.RentedBooks.Add(rentedBook);

                    string data = @"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\userAccounts.json";
                    string json = JsonConvert.SerializeObject(UserList, Formatting.Indented);

                    File.WriteAllText(data, json);

                    string line = $"Du har lånat boken '{book.Titel}'. Glöm inte att lämna tillbaka den senast om tre veckor.";

                }
            }
            //funktionen hanterar att söka upp en bok ifrån listan med alla böcker, det går att låna/lämna tillbaka efter
            public static void SearchForBook(List<Book> BookList, List<Person> UserList, bool UserisRenting, Person User, string searchQuery,ref Book book)
            {
                string searchQuery1 = searchQuery;
                //letar upp boken som man sökt efter, firstordefault loopar igenom listan och tar första bästa som matchar värdet/kraven
                book = BookList.FirstOrDefault(b => b.Titel?.ToLower() == searchQuery.ToLower() || b.Författare?.ToLower() == searchQuery.ToLower() || b.Serienummer.ToString() == searchQuery)!;
            }

            //skapade denna för att spara den nya informationen/ändringen som skett, ska fixa så att den körs vid alla tillfällen över projektet
            public static void UpdateJson(List<Person> UserList, List<Book> BookList)
            {
                string jsonString = JsonConvert.SerializeObject(UserList, Formatting.Indented);
                File.WriteAllText(@"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\userAccounts.json", jsonString);

                jsonString = JsonConvert.SerializeObject(BookList, Formatting.Indented);
                File.WriteAllText(@"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\Books.json", jsonString);
            }

            public static void ReturnBooks(Book book, Person User, List<Book> BookList, List<Person> UserList,ref bool UserisRenting)
            {
                if (User.RentedBooks != null)
                {
                    foreach (Book Book in User.RentedBooks)
                    {
                        if (Book.Serienummer == Book.Serienummer)
                        {
                            UserisRenting = true;
                            break;
                        }
                    }
                }
                foreach (Book rentedBook in User.RentedBooks)
                {
                    if (rentedBook.Serienummer == book.Serienummer)
                    {
                        User.RentedBooks.Remove(rentedBook);
                        
                        book.Ledig = true;
                        //firstordefault letar efter den inloggade användaren i UserList för att sedan ta bort dess bok som den lånade
                        Person updatedUser = UserList.FirstOrDefault(u => u.personnummer == User.personnummer)!;
                        if (updatedUser != null)
                        {
                            updatedUser.RentedBooks = User.RentedBooks;
                            UpdateJson(UserList, BookList);
                            //panel3.BringToFront();
                            return;
                        }
                    }
                }


            }

        }
    }
}
