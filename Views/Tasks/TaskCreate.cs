using Tasks.Models;

namespace Tasks.Views.Tasks
{
    class TaskCreate
    {
        public static void display(User user, Tache task = null)
        {
            Console.Clear();
            Console.WriteLine("\n-------- Create a new Task ----------\n");
            Console.WriteLine("The auth user " + user.Username);

            Console.Read();
        }
    }
}