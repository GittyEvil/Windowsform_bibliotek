using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotektemp
{
   

    public class AccountHandler

    {
        //kollar genom lista och ifall information stämmer loggas man in
        public static void LoginPage(bool UserisRenting)
        {
            string Data = File.ReadAllText("C:\\Users\\adria\\Documents\\Bibliotektemp\\Bibliotektemp\\userAccounts.json");
            List<Person> UserList = JsonConvert.DeserializeObject<List<Person>>(Data)!;


            Console.WriteLine("Logga in:");
            Console.WriteLine("Personnummer:");
            string number = Console.ReadLine()!;
            Console.WriteLine("Lösenord:");
            string password = Console.ReadLine()!;

            Person User = null;

            foreach(Person user in UserList)
            {
                var personnummer = user.personnummer;
                var password1 = user.lösenord;


                if (personnummer.ToString() == number && password == password1.ToString())
                {
                    User = user;
                    
                    return;
                }

            }
        }
        //registrering som lägger till ny användare i json fil, läggs även till i lista för att kunna lätt hantera senare
        public static void RegisterPage(List<Person> UserList, bool UserisRenting)
        {
            
            if (UserList == null)
            {
                UserList = new List<Person>(); 
            }
            Console.WriteLine("skriv personnummer:");
            string personnummer1 = Console.ReadLine()!;
            Console.WriteLine("skriv ett lösenord");
            string lösenord1 = Console.ReadLine()!;
            Console.WriteLine("du har nu skapat ett konto.");

            Person newUser = new ("", "", Int32.Parse(personnummer1!), Int32.Parse(lösenord1!));

            
            UserList.Add(newUser);

            string dataToSave = JsonConvert.SerializeObject(UserList);
            File.WriteAllText("C:\\Users\\adria\\Documents\\Bibliotektemp\\Bibliotektemp\\userAccounts.json", dataToSave);

            LoginPage(UserisRenting);

        }
        //hanterar konto uppgift ändringar(lösenords ändring)
        public static void UserInfoChanger(List<Person> UserList, Person User, List<Book> BookList, int newPassword)
        {
            int newPassword1 = newPassword;

            //hittar användaren i userlistan (den som är inloggad)
            Person loggedInUser = UserList.FirstOrDefault(u => u.personnummer == User.personnummer);

            if (loggedInUser != null)
            {
                //ger nytt lösenord till användaren som hittats
                loggedInUser.lösenord = newPassword1;

                string data = @"C:\Users\adria\Documents\Bibliotek-Windowsform-main\Bibliotek-Windowsform-main\WinFormsApp1\WinFormsApp1\userAccounts.json";
                string json = JsonConvert.SerializeObject(UserList, Formatting.Indented);

                File.WriteAllText(data, json);
            }
            
        }

    }
}
