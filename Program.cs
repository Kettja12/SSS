using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SSS.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddDepedencies();
var app = builder.Build();
app.AddInterfaces();
app.Run();
