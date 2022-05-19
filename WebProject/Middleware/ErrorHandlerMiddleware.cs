
namespace WebProject.Middleware
{
    //https://jasonwatmore.com/post/2022/01/17/net-6-global-error-handler-tutorial-with-example
    //https://stackoverflow.com/questions/58354613/how-handle-exceptions-from-400-to-500-in-asp-net-core-3
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ErrorHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);

                //  Handle specific HTTP status codes
                switch (context.Response.StatusCode)
                {
                    case 404:
                        HandlePageNotFound(context);
                        break;

                    case 418:
                        //  Not implemented
                        break;

                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                //Handle uncaught global exceptions(treat as 500 error)
                HandleException(context, e);
            }
            finally
            {
            }
        }

        //  500
        private void HandleException(HttpContext context, Exception e)
        {
            string path = context.Request.Path.ToString().TrimStart('/');
            _logger.LogError($"{path}, error => {e.Message}");
            context.Response.Redirect("/home/error");
        }

        //  404
        private void HandlePageNotFound(HttpContext context)
        {
            string path = context.Request.Path.ToString().TrimStart('/');
            _logger.LogInformation($"{path} not found");
            context.Response.Redirect("/home/notfound");
        }
    }
}