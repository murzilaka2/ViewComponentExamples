using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class TimerServiceViewComponent : ViewComponent
    {
        private readonly ITimeService _timeService;

        public TimerServiceViewComponent(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public string Invoke()
        {
            return $"Current time: {_timeService.GetTime()}";
        }
    }
}
