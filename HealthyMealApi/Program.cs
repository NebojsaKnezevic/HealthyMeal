using HealthyMeal.api.Services;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddSingleton<IHealthyMealService, HealthyMealService>(); 
}


var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    //app.UseAuthorization();
    app.MapControllers();

    //app.Use(async (HttpContext context, RequestDelegate next) =>
    //{
    //    Console.WriteLine($"Request Method: {context.Request.Method}");
    //    Console.WriteLine($"Request Path: {context.Request.Path}");
    //    Console.WriteLine($"Request QueryString: {context.Request.QueryString}");
    //    await next(context);
    //});

    app.Run();
}


