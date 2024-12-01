using HW_10_ServiceGetDate;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IGetDate, LongDateService>();
//builder.Services.AddTransient<IGetDate, ShortDateService>();

var app = builder.Build();

app.Run(async context =>
{
	var response = context.Response;
	response.ContentType = "text/html; charset=utf-8";
	var dateService = app.Services.GetRequiredService<IGetDate>();
	await context.Response.WriteAsync($"Date: {dateService?.GetDate()}");
});

app.Run();