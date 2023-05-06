namespace Tasks.Models
{
    class User
    {

        int id;
        public int Id { get => id;set => id = value; }

        string username;
        public string Username { get => username; set => username = value; }

        string password;
        public string Password { get => password; set => password = value; }

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

        // Create a new user
        public static User create(string username, string password)
        {
            // insert username and password into database
            // code ....

            return new User(username, password);
        }
    }
}