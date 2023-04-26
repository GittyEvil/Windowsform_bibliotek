using Bibliotektemp;
using Newtonsoft.Json;
using System.IO;
using System;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    

    public partial class FirstPage : Form
    {
        
        public FirstPage()
        {
            string Data = File.ReadAllText("C:\\Users\\adrian.stude\\Documents\\Prog2\\Windowsform_bibliotek\\WinFormsApp1\\userAccounts.json");
            List<Person> UserList = JsonConvert.DeserializeObject<List<Person>>(Data)!;
            string BookData = File.ReadAllText(@"C:\Users\adrian.stude\Documents\Prog2\Windowsform_bibliotek\WinFormsApp1\Books.json");
            List<Book> BookList = JsonConvert.DeserializeObject<List<Book>>(BookData)!;
            bool UserisRenting = false;
            Person User = null;
            Book chosenbook = null;
            InitializeComponent();
            button3.Click += (sender, e) => button3_Click(sender, e, UserList, BookList);
            button4.Click += (sender, e) => button4_Click(sender, e, UserList, BookList, UserisRenting);
            button1.Click += (sender, e) => button1_Click(sender, e, BookList, UserList, UserisRenting);
            button7.Click += (sender, e) => button7_Click(sender, e, BookList, UserList, UserisRenting);
            button8.Click += (sender, e) => button8_Click(sender, e, User,chosenbook,BookList, UserList, UserisRenting);
            button9.Click += (sender, e) => button9_Click(sender, e, User, chosenbook, BookList, UserList, UserisRenting);
            //label12.Click += (sender, e) => label12_Click(sender, e, BookList, UserList, UserisRenting, User, chosenbook);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //f�r att visa inlogg
            panel1.BringToFront();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //f�r att visa registrering
            panel2.BringToFront();
        }

        

        public void button4_Click(object sender, EventArgs e, List<Person> UserList, List<Book> BookList, bool UserisRenting)
        {
            //kanpp f�r att registrera
            UserList ??= new List<Person>();
            Console.WriteLine("skriv personnummer:");
            string personnummer1 = nummerRegisterButton.Text;
            Console.WriteLine("skriv ett l�senord");
            string l�senord1 = passwordRegisterButton.Text;
            Console.WriteLine("du har nu skapat ett konto.");

            Person newUser = new("", "", Int32.Parse(personnummer1!), Int32.Parse(l�senord1!));


            UserList.Add(newUser);

            string dataToSave = JsonConvert.SerializeObject(UserList);
            File.WriteAllText("C:\\Users\\adrian.stude\\Documents\\Prog2\\Windowsform_bibliotek\\WinFormsApp1\\userAccounts.json", dataToSave);

            panel1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e, List<Person> UserList, List<Book> BookList)
        {
            //kanpp f�r att inlogg
            //beh�ver ta input som skrevs och j�mf�ra med det konto som redan existerar
            Person User = null;
            var number = nummerLoginBox.Text;
            var password = passwordLoginButton.Text;
            foreach (Person user in UserList)
            {
                var personnummer = user.personnummer;
                var password1 = user.l�senord;


                if (personnummer.ToString() == number && password == password1.ToString())
                {
                    User = user;
                    panel4.BringToFront();
                    return;
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e, List<Book> BookList, List<Person> UserList, bool UserisRenting)
        {
            //lista alla b�cker knappen(mainpage)
            panel5.BringToFront();
            //denna knappen kommer g�ra alla b�cker synliga 
            for (var i = 0; i < BookList.Count; i++)
            {
                Book book = BookList[i];
                var books = $"{i + 1}.{book.Titel} {book.F�rfattare} {book.Serienummer} {book.Antal}";
                //listofbooks.Text = books;
                ListofBooksbox.Items.Add(books);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //s�ka efter bok knappen(mainpage)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //�ndra konto uppgifter(mainpage)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //logga ut knapp(mainpage)
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e, List<Book> BookList, List<Person> UserList, bool UserisRenting)
        {
            //knappen som tar dig vidare f�r att l�na bok och l�mna tillbaka
            var choice = Choosebook.Text;
            int number;

            var isNumber = int.TryParse(choice, out number);

            if (isNumber && number > 0 && number < BookList.Count + 1)
            {
                Book book = BookList[number - 1];
                var books = $"{book.Titel} {book.F�rfattare} {book.Serienummer} {book.Antal}";
                label12.Text = books;
                panel6.BringToFront();
                
                
            }

            
        }
            
        private void Choosebook_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e,Person User, Book book, List<Book> BookList, List<Person> UserList, bool UserisRenting)
        {
            //knappen f�r att l�na bok

            if (User.RentedBooks != null)
            {
                foreach (Book Book in User.RentedBooks)
                {
                    if (Book.Serienummer == book.Serienummer)
                    {
                        UserisRenting = true;
                        break;
                    }
                }
            }
            if (UserisRenting == false)
            {
                Person loggedInUser = UserList.FirstOrDefault(u => u.id == User.id)!;

                Book rentedBook = new(book.Titel!, book.Serienummer, book.F�rfattare, book.Antal);

                book.Ledig = false;

                loggedInUser.RentedBooks.Add(rentedBook);

                string data = @"C:\Users\adria\Documents\Bibliotektemp\Bibliotektemp\userAccounts.json";
                string json = JsonConvert.SerializeObject(UserList, Formatting.Indented);

                File.WriteAllText(data, json);

                Console.WriteLine($"Du har l�nat boken '{book.Titel}'. Gl�m inte att l�mna tillbaka den senast om tre veckor.");
            }
        }
        public static void UpdateJson(List<Person> UserList, List<Book> BookList)
        {
            string jsonString = JsonConvert.SerializeObject(UserList, Formatting.Indented);
            File.WriteAllText(@"C:\Users\adria\Documents\Bibliotektemp\Bibliotektemp\userAccounts.json", jsonString);

            jsonString = JsonConvert.SerializeObject(BookList, Formatting.Indented);
            File.WriteAllText(@"C:\Users\adria\Documents\Bibliotektemp\Bibliotektemp\Books.json", jsonString);
        }

        private void button9_Click(object sender, EventArgs e, Person User, Book book, List<Book> BookList, List<Person> UserList, bool UserisRenting)
        {
            //knappen f�r att l�mna tillbaka bok
            if (User.RentedBooks != null)
            {
                foreach (Book Book in User.RentedBooks)
                {
                    if (Book.Serienummer == book.Serienummer)
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
                    Console.WriteLine("Boken �r nu �terl�mnad.");
                    book.Ledig = true;
                    //firstordefault letar efter den inloggade anv�ndaren i UserList f�r att sedan ta bort dess bok som den l�nade
                    Person updatedUser = UserList.FirstOrDefault(u => u.personnummer == User.personnummer)!;
                    if (updatedUser != null)
                    {
                        updatedUser.RentedBooks = User.RentedBooks;
                        UpdateJson(UserList, BookList);
                        return;
                    }
                }
            }
            Console.WriteLine("Kunde inte hitta boken i anv�ndarens hyrda b�cker.");
        }
    }
}