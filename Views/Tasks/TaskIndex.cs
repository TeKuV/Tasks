using Tasks.Models;

namespace Tasks.Views.Tasks
{
    class TaskIndex
    {
        public static void display(User user, Tache task=null)
        {
            Console.Clear();
            Console.WriteLine("\n-------- List of Tasks ----------\n");
            Console.WriteLine("The auth user " + user.Username);

            Console.Read();
        }
    }
}