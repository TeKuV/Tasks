namespace Taches.Models
{
    class User
    {
        string username{ get; set; } = "";

        string password { get; set; } = "";

        public User(string username, string password)
        {
            this.password = password;
            this.username = username;
        }

        public static string hidePassword(char mask)
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
                else if (info.KeyChar != '\u0000' && !char.IsControl(info.KeyChar))
                {
                    password += info.KeyChar;
                    Console.Write(mask);
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }

        public static bool login(string username, string password) =>  username == "User" && password == "1234" ? true : false;
    }
}