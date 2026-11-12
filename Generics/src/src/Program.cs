using System;
using System.Collections.Generic;
using src;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 1. Testing Store<Student> ===");
        var studentStore = new Store<Student>();
        
      
        studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
        studentStore.Add(new Student { Id = 2, Name = "Mohamed" });
        studentStore.Add(new Student { Id = 3, Name = "Ali" });
        studentStore.Add(new Student { Id = 4, Name = "Sara" });
        studentStore.Add(new Student { Id = 5, Name = "Mona" });

        
        var student = studentStore.GetById(3);
        Console.WriteLine($"Found Student: {student?.Name}");


        Console.WriteLine("\n=== 2. Testing Store<Course> ===");
        var courseStore = new Store<Course>();
        
     
        courseStore.Add(new Course { Id = 101, Title = "C# Basics", Price = 100m });
        courseStore.Add(new Course { Id = 102, Title = "Advanced Generics", Price = 150m });
        courseStore.Add(new Course { Id = 103, Title = "Entity Framework", Price = 200m });

     
        var course = courseStore.GetById(102);
        Console.WriteLine($"Found Course: {course?.Title} - Price: ${course?.Price}");


        Console.WriteLine("\n=== 3. Testing Duplicate ID Exception ===");
        try
        {
         
            studentStore.Add(new Student { Id = 1, Name = "Duplicate Ahmed" });
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Caught Expected Exception: {ex.Message}");
        }


        Console.WriteLine("\n=== 4. Testing Extension Methods (Page & FindById) ===");
        var allStudents = studentStore.GetAll();
        
        Console.WriteLine("\nAll tests executed successfully!");
    }
}