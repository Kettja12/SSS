using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SSS.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddIntefrace();
var app = builder.Build();
app.AddRouting();
app.Run();
