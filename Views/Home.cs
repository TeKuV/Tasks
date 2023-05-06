using Tasks.Models;

namespace Tasks.Views
{
    class Home
    {
        public static int display()
        {
            Console.Clear();
            Console.WriteLine("\n--------- Home -------------\n");

            Console.WriteLine("1- Display list of task \n");
            Console.WriteLine("2- Create new task \n");
            Console.WriteLine("3- Edit task \n");
            Console.WriteLine("0- Exit \n");

            Console.Write("Faite votre choix : ");
            string input = Console.ReadLine();

            int choice = int.Parse(input);
            while (choice < 0 || choice > 3)
            {
                Console.Clear();
                Console.WriteLine("Please enter the correct choice ! \n");
                choice = Home.display();
            }

            return choice;
        }
    }
}