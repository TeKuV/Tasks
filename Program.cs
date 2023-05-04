using System;
using Taches.Models;
using Taches.Views;

namespace Taches;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Username: ");
        Console.SetCursorPosition(0, 1);
        Console.Write("Password: ");
        Console.SetCursorPosition(10, 0);
        string username = Console.ReadLine();
        Console.SetCursorPosition(10, 1);
        string password = User.hidePassword('*');
        Console.Clear();

        // Auth verification
        Program.menu();
    }

    static int menu()
    {
        Console.WriteLine("1- Display list of task \n");
        Console.WriteLine("2- Create new task \n");
        Console.WriteLine("3- Edit task \n");

        Console.Write("Faite votre choix : ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);

        while(choice < 0 || choice > 3)
        {
            Console.WriteLine("Please enter the correct choice ! \n");
            choice = Program.menu();
        }

        return choice;
    }

    static void App()
    {
        
    }
}
