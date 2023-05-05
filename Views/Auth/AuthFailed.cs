namespace Tasks.Views.Auth
{
    class AuthFailed
    {
        public static void display()
        {
            Console.Clear();
            Console.Beep(440, 1000);
            Console.WriteLine("Authentication failed ! Try again...");
            Console.ReadLine();
        }
    }
}