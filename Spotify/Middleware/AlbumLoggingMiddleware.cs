namespace Spotify.Middleware
{
    public class AlbumLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AlbumLoggingMiddleware> _logger;

        public AlbumLoggingMiddleware(RequestDelegate next, ILogger<AlbumLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("AlbumLoggingMiddleware executing..");

            // foreach request of album details we will log the request
            if (context.Request.Path.Value.ToLower().ToString().Contains("albums/details"))
            {
                _logger.LogInformation("Request for album details");

                StreamWriter streamWriter = new StreamWriter("albumlog.txt", true);
                await streamWriter.WriteLineAsync($"Request for album details at {DateTime.Now}");
                await streamWriter.DisposeAsync();
            }
            await _next(context);
        }
    }

    public static class AlbumLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseAlbumLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AlbumLoggingMiddleware>();
        }
    }
}