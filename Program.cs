using Tasks.Views.Auth;
using Tasks.Controllers;

namespace Tasks;
class Program
{
    static void Main(string[] args)
    {
        HomeController.app(Login.display());
    }
}
