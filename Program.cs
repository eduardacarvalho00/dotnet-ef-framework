using api_crud.Data;
using api_crud.Students;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.Use((context, next) =>
    {
        context.Response.Headers.AccessControlAllowOrigin = "*";
        return next.Invoke();
    });
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Without "this" in props we call the endpoint like that ↓
// StudentsEndpoint.AddPathsStudents(app);

// with this in props app ↓
app.AddPathsStudents();


app.Run();

