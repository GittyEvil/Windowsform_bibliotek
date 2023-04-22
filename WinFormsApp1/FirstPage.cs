using Bibliotektemp;
using Newtonsoft.Json;
using System.IO;
using System;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace WinFormsApp1
{
    

    public partial class FirstPage : Form
    {
        
        public FirstPage()
        {
            string Data = File.ReadAllText("C:\\Users\\adria\\Documents\\Bibliotek-Windowsform-main\\Bibliotek-Windowsform-main\\WinFormsApp1\\WinFormsApp1\\userAccounts.json");
            List<Person> UserList = JsonConvert.DeserializeObject<List<Person>>(Data)!;
            string BookData = File.ReadAllText(@"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\Books.json");
            List<Book> BookList = JsonConvert.DeserializeObject<List<Book>>(BookData)!;
            bool UserisRenting = false;
            InitializeComponent();
            button3.Click += (sender, e) => button3_Click(sender, e, UserList, BookList);
            button4.Click += (sender, e) => button4_Click(sender, e, UserList, BookList, UserisRenting);
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

        

        public void button4_Click(object sender, EventArgs e, List<Person> UserList, List<Book> BookList, bool UserisRenting)
        {
            //kanpp för att registrera
            UserList ??= new List<Person>();
            Console.WriteLine("skriv personnummer:");
            string personnummer1 = nummerRegisterButton.Text;
            Console.WriteLine("skriv ett lösenord");
            string lösenord1 = passwordRegisterButton.Text;
            Console.WriteLine("du har nu skapat ett konto.");

            Person newUser = new("", "", Int32.Parse(personnummer1!), Int32.Parse(lösenord1!));


            UserList.Add(newUser);

            string dataToSave = JsonConvert.SerializeObject(UserList);
            File.WriteAllText("C:\\Users\\adria\\Documents\\Bibliotek-Windowsform-main\\Bibliotek-Windowsform-main\\WinFormsApp1\\WinFormsApp1\\userAccounts.json", dataToSave);

            panel1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e, List<Person> UserList, List<Book> BookList)
        {
            //kanpp för att inlogg
            //behöver ta input som skrevs och jämföra med det konto som redan existerar
            Person User = null;
            var number = nummerLoginBox.Text;
            var password = passwordLoginButton.Text;
            foreach (Person user in UserList)
            {
                var personnummer = user.personnummer;
                var password1 = user.lösenord;


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
            //denna label kommer visa alla böcker som man sedan kan låna

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lista alla böcker knappen(mainpage)
            panel5.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //söka efter bok knappen(mainpage)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ändra konto uppgifter(mainpage)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //logga ut knapp(mainpage)
        }
    }
}