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
        Person User = null;
        bool UserisRenting = false;
        Book book = null;
        Person chosenUser = null;
        bool bibliotikarie = false;

        public FirstPage()
        {
            string Data = File.ReadAllText("C:\\Users\\adria\\Documents\\Bibliotek-Windowsform-main\\Bibliotek-Windowsform-main\\WinFormsApp1\\WinFormsApp1\\userAccounts.json");
            List<Person> UserList = JsonConvert.DeserializeObject<List<Person>>(Data)!;
            string BookData = File.ReadAllText(@"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\Books.json");
            List<Book> BookList = JsonConvert.DeserializeObject<List<Book>>(BookData)!;

            InitializeComponent();
            button3.Click += (sender, e) => button3_Click(sender, e, UserList, BookList);
            button4.Click += (sender, e) => button4_Click(sender, e, UserList, BookList, UserisRenting, bibliotikarie);
            button1.Click += (sender, e) => button1_Click(sender, e, BookList, UserList, UserisRenting, User);
            button7.Click += (sender, e) => button7_Click(sender, e, BookList, UserList, UserisRenting, User);
            button8.Click += (sender, e) => button8_Click(sender, e, User,BookList, UserList, UserisRenting);
            button9.Click += (sender, e) => button9_Click(sender, e, User, BookList, UserList, UserisRenting);
            button10.Click += (sender, e) => button10_Click(sender, e,UserList);
            button15.Click += (sender, e) => button15_Click(sender, e, UserList);
            button18.Click += (sender, e) => button18_Click(sender, e, UserList);
            button20.Click += (sender, e) => button20_Click(sender, e, UserList);
            button21.Click += (sender, e) => button21_Click(sender, e, BookList);
            button19.Click += (sender, e) => button19_Click(sender, e, UserList);
            button22.Click += (sender, e) => button22_Click(sender, e, UserList);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //för att visa inlogg
            panel1.BringToFront();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //för att visa registrering
            panel2.BringToFront();
        }

        

        public void button4_Click(object sender, EventArgs e, List<Person> UserList, List<Book> BookList, bool UserisRenting, bool bibliotikarie)
        {
            //kanpp för att registrera
            UserList ??= new List<Person>();
            Console.WriteLine("skriv personnummer:");
            string personnummer1 = nummerRegisterButton.Text;
            Console.WriteLine("skriv ett lösenord");
            string lösenord1 = passwordRegisterButton.Text;
            Console.WriteLine("du har nu skapat ett konto.");

            Person newUser = new("", "", Int32.Parse(personnummer1!), Int32.Parse(lösenord1!) ,bibliotikarie);


            UserList.Add(newUser);

            string dataToSave = JsonConvert.SerializeObject(UserList);
            File.WriteAllText("C:\\Users\\adria\\Documents\\Bibliotek-Windowsform-main\\Bibliotek-Windowsform-main\\WinFormsApp1\\WinFormsApp1\\userAccounts.json", dataToSave);

            panel1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e, List<Person> UserList, List<Book> BookList)
        {
            //kanpp för att inlogg
            //behöver ta input som skrevs och jämföra med det konto som redan existerar
            var number = nummerLoginBox.Text;
            var password = passwordLoginButton.Text;
            foreach (Person user in UserList)
            {
                var personnummer = user.personnummer;
                var password1 = user.lösenord;
                var bibliotikarie = user.bibliotikarie;


                if (personnummer.ToString() == number && password == password1.ToString())
                {
                    User = user;
                    if(bibliotikarie == false)
                    {
                        panel4.BringToFront();
                    }
                    if (bibliotikarie == true)
                    {
                        panel8.BringToFront();
                    }
                    
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

        private void button1_Click(object sender, EventArgs e, List<Book> BookList, List<Person> UserList, bool UserisRenting, Person User)
        {
            //lista alla böcker knappen(mainpage)
            panel5.BringToFront();
            //denna knappen kommer göra alla böcker synliga 
            for (var i = 0; i < BookList.Count; i++)
            {
                Book book = BookList[i];
                var books = $"{i + 1}.{book.Titel} {book.Författare} {book.Serienummer} {book.Antal}";
                //listofbooks.Text = books;
                ListofBooksbox.Items.Add(books);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //söka efter bok knappen(mainpage)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ändra konto uppgifter(mainpage)
            panel7.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //logga ut knapp(mainpage)
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e, List<Book> BookList, List<Person> UserList, bool UserisRenting, Person User)
        {
            //knappen som tar dig vidare för att låna bok och lämna tillbaka
            var choice = Choosebook.Text;
            int number;

            var isNumber = int.TryParse(choice, out number);

            if (isNumber && number > 0 && number < BookList.Count + 1)
            {
                book = BookList[number - 1];
                var books = $"{book.Titel} {book.Författare} {book.Serienummer} {book.Antal}";
                label12.Text = books;
                panel6.BringToFront();

                
            }

            
        }
            
        private void Choosebook_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e,Person User, List<Book> BookList, List<Person> UserList, bool UserisRenting)
        {
            //knappen för att låna bok

            if (User.RentedBooks != null)
            {
                foreach (Book book in User.RentedBooks)
                {
                    if (book.Serienummer == book.Serienummer)
                    {
                        UserisRenting = true;
                        break;
                    }
                }
            }
            if (UserisRenting == false)
            {
                Person loggedInUser = UserList.FirstOrDefault(u => u.id == User.id)!;

                Book rentedBook = new(book.Titel!, book.Serienummer, book.Författare, book.Antal);

                book.Ledig = false;

                loggedInUser.RentedBooks.Add(rentedBook);

                string data = @"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\userAccounts.json";
                string json = JsonConvert.SerializeObject(UserList, Formatting.Indented);

                File.WriteAllText(data, json);

                string line = $"Du har lånat boken '{book.Titel}'. Glöm inte att lämna tillbaka den senast om tre veckor.";
                label13.Text = line;
                panel3.BringToFront();
            }
        }
        public static void UpdateJson(List<Person> UserList, List<Book> BookList)
        {
            string jsonString = JsonConvert.SerializeObject(UserList, Formatting.Indented);
            File.WriteAllText(@"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\userAccounts.json", jsonString);

            jsonString = JsonConvert.SerializeObject(BookList, Formatting.Indented);
            File.WriteAllText(@"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\Books.json", jsonString);
        }

        private void button9_Click(object sender, EventArgs e, Person User,List<Book> BookList, List<Person> UserList, bool UserisRenting)
        {
            //knappen för att lämna tillbaka bok
            if (User.RentedBooks != null)
            {
                foreach (Book book in User.RentedBooks)
                {
                    if (book.Serienummer == book.Serienummer)
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
                    string line ="Boken är nu återlämnad.";
                    label13.Text = line;
                    book.Ledig = true;
                    //firstordefault letar efter den inloggade användaren i UserList för att sedan ta bort dess bok som den lånade
                    Person updatedUser = UserList.FirstOrDefault(u => u.personnummer == User.personnummer)!;
                    if (updatedUser != null)
                    {
                        updatedUser.RentedBooks = User.RentedBooks;
                        UpdateJson(UserList, BookList);
                        panel3.BringToFront();
                        return;
                    }
                }
            }
            string line2 = "Kunde inte hitta boken i användarens hyrda böcker.";
            label13.Text = line2;
            panel3.BringToFront();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e, List<Person> UserList)
        {
            //denna knapp byter lösenord
            Console.WriteLine("Skriv in ditt nya lösenord du skulle vilja ha, endast siffror");
            int newPassword = Int32.Parse(textBox1.Text);

            //hittar användaren i userlistan(den som är inloggad)
            Person loggedInUser = UserList.FirstOrDefault(u => u.lösenord == User.lösenord)!;

            //ger nytt lösenord till användaren som hittats
            loggedInUser.lösenord = newPassword;

            string data = @"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\userAccounts.json";
            string json = JsonConvert.SerializeObject(UserList, Formatting.Indented);

            File.WriteAllText(data, json);
            panel3.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textbox1 är boxen där man skriver input för att byta lösenord
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //lägger till bok(bibliotikarie sida
            panel11.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //tar bort bok (bibliotikare sida
        }

        private void button15_Click(object sender, EventArgs e,List<Person> UserList)
        {
            //visa alla användare
            panel9.BringToFront();

            for(var i = 0; i < UserList.Count; i++)
            {
                Person person = UserList[i];
                var users = $"{i + 1}. förnamn:{person.förnamn}   Efternamn:{person.efternamn}   Personnummer:{person.personnummer}   Lösenord:{person.lösenord}";
                //listofbooks.Text = books;
                listBox1.Items.Add(users);
            }
            
        }

        private void button18_Click(object sender, EventArgs e, List<Person> UserList)
        {
            var choice = textBox3.Text;
            int number;

            var isNumber = int.TryParse(choice, out number);

            if (isNumber && number > 0 && number < UserList.Count + 1)
            {
                chosenUser = UserList[number - 1];
                var users = $"förnamn:{chosenUser.förnamn}   Efternamn:{chosenUser.efternamn}   Personnummer:{chosenUser.personnummer}   Lösenord:{chosenUser.lösenord}";
                label19.Text = users;
                panel10.BringToFront();
            }
        }


        private void button20_Click(object sender, EventArgs e, List<Person> UserList)
        {
            //knappen som redigerar vald användare
            int newPassword = Int32.Parse(textBox2.Text);

            //hittar användaren i userlistan(den som är inloggad)
            Person changeUser = UserList.FirstOrDefault(u => u.lösenord == chosenUser.lösenord)!;

            //ger nytt lösenord till användaren som hittats
            changeUser.lösenord = newPassword;

            string data = @"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\userAccounts.json";
            string json = JsonConvert.SerializeObject(UserList, Formatting.Indented);

            File.WriteAllText(data, json);
            panel3.BringToFront();
        }


        private void button21_Click(object sender, EventArgs e,List<Book> BookList)
        {
            //knappen som lägger till böcker i json fil
            BookList ??= new List<Book>();
            string titel = textBox4.Text;
            int serienummer = Int32.Parse(textBox5.Text);
            int antal = Int32.Parse(textBox6.Text);
            string författare = textBox7.Text;

            Book newBook = new(titel,serienummer,antal,författare);


            BookList.Add(newBook);

            string dataToSave = JsonConvert.SerializeObject(BookList);
            File.WriteAllText("C:\\Users\\adria\\Documents\\Bibliotek-Windowsform-main\\Bibliotek-Windowsform-main\\WinFormsApp1\\WinFormsApp1\\Books.json", dataToSave);

            panel3.BringToFront();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //input box för att ändra lösenord för en användare(bibliotikarie)
        }

        private void button19_Click(object sender, EventArgs e, List<Person> UserList)
        {
            //knappen öppnar prompt ifall du vill ta bort användare
            panel12.BringToFront();
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void button22_Click(object sender, EventArgs e, List<Person> UserList)
        {
            //knappen tar bort vald användare
            Person changeUser = UserList.FirstOrDefault(u => u.lösenord == chosenUser.lösenord)!;

            //ger nytt lösenord till användaren som hittats
            UserList.Remove(changeUser);

            string data = @"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\userAccounts.json";
            string json = JsonConvert.SerializeObject(UserList, Formatting.Indented);

            File.WriteAllText(data, json);
            panel3.BringToFront();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}