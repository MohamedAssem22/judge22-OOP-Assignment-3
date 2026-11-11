namespace src.Courses;

public class CourseStore
{
    private List<Course> _courses = new List<Course>();

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public Course? GetById(int id)
    {
        return _courses.FirstOrDefault(x => x.Id == id);
    }

    public IReadOnlyList<Course> GetAll() => _courses.AsReadOnly();

    public void Remove(int courseId)
    {
        var course = GetById(courseId);
        if (course != null)
            _courses.Remove(course); 
    }
}