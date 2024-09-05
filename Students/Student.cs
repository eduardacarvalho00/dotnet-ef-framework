namespace api_crud.Students;

public class Student
{
    //Guid is a Id that doesn't repeat
    // Init is for after the id is seted he doesn't permited to edit or changet the id
    public Guid Id { get; init; }
    public string Name { get; private set; }
    public bool IsActive { get; private set; }

    public Student(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
        IsActive = true;
    }
}