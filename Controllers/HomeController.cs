using Tasks.Models;
using Tasks.Views;
using Tasks.Views.Tasks;
using Tasks.Views.Auth;

namespace Tasks.Controllers
{
    class HomeController
    {
        public static void app(User user)
        {
            // Auth verification
            if (User.login(user.Username, user.Password))
            {
                switch (Home.display())
                {
                    case 1:
                        TaskIndex.display(user);

                        Continue.display(); // display message : "Press any key to continue..."
                        HomeController.app(user);
                        break;
                        
                    case 2:
                        break;

                    default:
                        if (SessionExit.display(user).Key == ConsoleKey.Enter)
                            HomeController.app(Login.display());

                        break;
                };
            }
            else // User is not logged in
            {
                AuthFailed.display();

                HomeController.app(Login.display());
            }
        }
    }
}