namespace Spotify.Middleware
{
    public class SongLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<SongLoggingMiddleware> _logger;

        public SongLoggingMiddleware(RequestDelegate next, ILogger<SongLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("SongLoggingMiddleware executing..");

            // foreach request of song details we will log the request
            if (context.Request.Path.Value.ToLower().ToString().Contains("songs/details"))
            {
                _logger.LogInformation("Request for song details");

                StreamWriter streamWriter = new StreamWriter("songlog.txt", true);
                await streamWriter.WriteLineAsync($"Request for song details at {DateTime.Now}");
                await streamWriter.DisposeAsync();
            }
            await _next(context);
        }
    }

    public static class SongLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseSongLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SongLoggingMiddleware>();
        }
    }
}
