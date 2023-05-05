using Tasks.Models;

namespace Tasks.Views.Auth
{
    class Login
    {
        // Help for getting credentials of a user
        public static User display()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Username: ");
            Console.SetCursorPosition(0, 2);
            Console.Write("Password: ");
            Console.SetCursorPosition(10, 0);

            string username = Console.ReadLine();
            Console.SetCursorPosition(10, 2);
            string password = User.hidePassword('*');
            Console.Clear();

            return new User(username, password);
        }
    }
}