using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExamCleanCode.Core;
using Newtonsoft.Json;

namespace ExamCleanCode.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SolidLibraryApp app = new SolidLibraryApp();
            app.Execute();

            /*List<Book> books = new List<Book>();

            books.Add(new Book
            {
                Title = "wassup",
                Author = "heey"
            });
            books.Add(new Book
            {
                Title = "wassup2",
                Author = "heey2"
            });

            List<User> users = new List<User>();
            Role r = new Role();

            users.Add(new User
            {
                Role = r,
                Login = "john"
            });
            users.Add(new User
            {
                Role = r,
                Login = "john2"
            });*/

            /*Role r = new Role();
            User a = new User()
            {
                Login = "suuup"
            };*/
            //var jsonText = File.ReadAllText("filepath");
            //var sponsors = JsonConvert.DeserializeObject<IList<SponsorInfo>>(jsonText);

            //File.WriteAllText("C:\\Users\\yanis.touahri\\source\\repos\\ESGI\\ExamCleanCode\\src\\ExamCleanCode.App\\Data\\users.json", JsonConvert.SerializeObject(users));
            //File.WriteAllText("C:\\Users\\yanis.touahri\\source\\repos\\ESGI\\ExamCleanCode\\src\\ExamCleanCode.App\\Data\\books.json", JsonConvert.SerializeObject(books));

            //var jsonText = File.ReadAllText("C:\\Users\\yanis.touahri\\source\\repos\\ESGI\\ExamCleanCode\\src\\ExamCleanCode.App\\Resources\\books.txt");
            //var sponsors = JsonConvert.DeserializeObject<User>(jsonText);

            // a = Resources.books;
            //Console.WriteLine(sponsors.Login);
        }
    }
}
