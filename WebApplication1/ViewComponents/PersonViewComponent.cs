using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class PersonViewComponent : ViewComponent
    {
        public string Invoke(Person user)
        {
            return $"Name: {user.Name}  Age: {user.Age}";
        }
    }

}
