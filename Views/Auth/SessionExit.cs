using Tasks.Models;

namespace Tasks.Views.Auth
{
    class SessionExit
    {
        public static ConsoleKeyInfo display(User user)
        {
            Console.Clear();
            Console.Write("\nGood bye " + user.Username + ".... Press Enter to continue \nAnd Any other key to exit...");

            return Console.ReadKey();
        }
    }
}