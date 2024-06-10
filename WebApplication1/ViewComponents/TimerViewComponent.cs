using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace WebApplication1.ViewComponents
{
    //public class TimerViewComponent
    //{
    //    public string Invoke()
    //    {
    //        return $"Current time: {DateTime.Now.ToString("hh:mm:ss")}";
    //    }
    //}

    //public class Timer : ViewComponent
    //{
    //    public string Invoke()
    //    {
    //        return $"Current time: {DateTime.Now.ToString("hh:mm:ss")}";
    //    }
    //}

    //[ViewComponent]
    //public class Timer
    //{
    //    public string Invoke()
    //    {
    //        return $"Current time: {DateTime.Now.ToString("hh:mm:ss")}";
    //    }
    //}

    public class TimerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(bool includeSeconds, bool format24)
        {
            string time = String.Empty;
            DateTime now = DateTime.Now;


            if (format24)
                time = now.ToString("HH:mm");
            else
                time = now.ToString("hh:mm");


            if (includeSeconds)
                time = $"{time}:{now.Second}";


            return Content($"Current time: {time}");

        }
    }

}
