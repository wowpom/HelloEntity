using System;
using System.Linq;

namespace HelloEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext()) { 
                User user1 = new User { Name = "Kirill", Age = 19 };
                User user2 = new User { Name = "Polina", Age = 19 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно добавлены");

                var users = db.Users.ToList();
                Console.WriteLine("Список объектов");
                foreach(User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }


        }
    }
}
