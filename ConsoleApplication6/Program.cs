using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            Console.WriteLine("Please type 'yes' of you want to introduce a user");
            string yes = Console.ReadLine();
            if (yes == "yes") {
                Console.WriteLine("Please insert an User Name:\n");
                string name = Console.ReadLine();
                Console.WriteLine("Please insert the role of the user:\n 1 - Developer\n 2 - Technical Lead\n 3 - Architect\n");
                string role = Console.ReadLine();
                Console.WriteLine("Please insert the Experience of the user:\n");
                string exp = Console.ReadLine();
                if (Int32.Parse(role) == 1)
                    users.Add(new User(name, UserRole.Developer, Int32.Parse(exp)));
                if (Int32.Parse(role) == 2)
                    users.Add(new User(name, UserRole.TehnicalLead, Int32.Parse(exp)));
                if (Int32.Parse(role) == 3)
                    users.Add(new User(name, UserRole.Architect, Int32.Parse(exp)));
            }

            users.Add(new User("Luke Sywalker", UserRole.TehnicalLead,2));
            users.Add(new User("Obi-WAn Kenobi", UserRole.TehnicalLead,5));
            users.Add(new User("Han Solo", UserRole.TehnicalLead,7));
            users.Add(new User("Leia Skywalker", UserRole.Architect,3));
            users.Add(new User("Mace Windu", UserRole.Architect,6));
            users.Add(new User("Ahsoka Tano", UserRole.Architect,9));


            foreach (User user in users)
            {
                Console.WriteLine("User: "+user.Name+" Role: "+user.Role+" Experience: "+user.Experience);
            }

            var approvalModule = new Utils(users);

            Console.WriteLine("Design Difficulty: 5");
            Console.WriteLine(approvalModule.StartReview(5) + "\n");
 
            Console.WriteLine("Design Difficulty: 10");
            Console.WriteLine(approvalModule.StartReview(10) + "\n");

            Console.WriteLine("Design Difficulty: 12");
            Console.WriteLine(approvalModule.StartReview(12) + "\n");

            Console.WriteLine("Design Difficulty: 23");
            Console.WriteLine(approvalModule.StartReview(23) + "\n");

            Console.WriteLine("Design Difficulty: 30");
            Console.WriteLine(approvalModule.StartReview(30) + "\n");

            Console.WriteLine("Design Difficulty: 35");
            Console.WriteLine(approvalModule.StartReview(12) + "\n");

            Console.WriteLine("Design Difficulty: 40");
            Console.WriteLine(approvalModule.StartReview(23) + "\n");

            Console.WriteLine("Design Difficulty: 42");
            Console.WriteLine(approvalModule.StartReview(30) + "\n");


            Console.ReadLine();
        }
    }
}
