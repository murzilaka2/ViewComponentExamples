using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class UsersListQueryViewComponent : ViewComponent
    {
        List<string> users;
        public UsersListQueryViewComponent()
        {
            users = new List<string>
        {
            "Tom", "Tim", "Bob", "Sam", "Alice", "Kate"
        };
        }
        public IViewComponentResult Invoke()
        {
            int number = users.Count;
            // если передан параметр number
            if (Request.Query.ContainsKey("number"))
            {
                Int32.TryParse(Request.Query["number"].ToString(), out number);
            }

            ViewData["Header"] = $"Users count: {number}.";
            return View(users.Take(number));
        }
    }

}
