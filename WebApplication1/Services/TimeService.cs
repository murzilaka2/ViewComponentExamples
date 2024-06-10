using WebApplication1.Interfaces;

namespace WebApplication1.Services
{
    public class TimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
