using api_crud.Data;

namespace api_crud.Students;

public static class StudentsEndpoint
{
    public static void AddPathsStudents(this WebApplication app)
    {
        app.MapPost("create-student", async (AddStudentsRequest body, AppDbContext context) =>
        {
            var newStudent = new Student(body.Name);
            await context.Students.AddAsync(newStudent);

            await context.SaveChangesAsync();
        });

        app.MapGet("students", 
            () => new Student(name: "duda"));
    }
}