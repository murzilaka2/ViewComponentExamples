using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace WebApplication1.ViewComponents
{
    public class UsersListViewComponent : ViewComponent
    {
        List<string> users;
        public UsersListViewComponent()
        {
            users = new List<string>
        {
            "Tom", "Tim", "Bob", "Sam"
        };
        }
        public ViewViewComponentResult Invoke()
        {
            return View(users);
        }
    }

}
