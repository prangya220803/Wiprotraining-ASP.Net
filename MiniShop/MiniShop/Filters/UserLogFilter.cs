using Microsoft.AspNetCore.Mvc.Filters;
using MiniShop.Models;
using Microsoft.AspNetCore.Http;
using MiniShop;

namespace MiniShop.Filters
{
    public class UserLogFilter : IActionFilter
    {
        private readonly IHttpContextAccessor _http;

        public UserLogFilter(IHttpContextAccessor http) => _http = http;

        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var http = _http.HttpContext;
            var user = http?.Session.GetString(SessionKeys.UserName) ?? "Anonymous";
            var controller = context.RouteData.Values["controller"]?.ToString();
            var action = context.RouteData.Values["action"]?.ToString();

            // simple file log in wwwroot/logs/userlog.txt
            var root = Directory.GetCurrentDirectory();
            var dir = Path.Combine(root, "wwwroot", "logs");
            Directory.CreateDirectory(dir);
            var line = $"{DateTime.Now:u} | {user} | {controller}/{action}";
            File.AppendAllLines(Path.Combine(dir, "userlog.txt"), [line]);
        }
    }
}
