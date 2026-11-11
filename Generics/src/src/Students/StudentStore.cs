namespace src.Students;

public class StudentStore
{
    private List<Student> _students = new List<Student>();

    public void Add(Student student)
    {
        _students.Add(student);
    }

    public Student? GetById(int id)
    {
        return _students.FirstOrDefault(s => s.Id == id); 
    }

    public IReadOnlyList<Student> GetAll()
    {
        return _students; 
    }

    public void Remove(int id)
    {
        var searchedStudent = GetById(id);
        if (searchedStudent != null)
            _students.Remove(searchedStudent); 
    }
}