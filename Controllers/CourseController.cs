using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

//Course
public class CourseController : Controller
{
    // /course/index
    public IActionResult Index(){
        Course course = new Course();
        course.CourseId = 1;
        course.CourseTitle = "ASP.NET Core";

        return View(course);
    }
    // /course/list
    public IActionResult List(){
        var courses = new List<Course>()
        {
            new Course{CourseId = 1, CourseTitle = "ASP.NET Core",CourseImage = "aspnet.jpg" },
            new Course{CourseId = 2, CourseTitle = "Angular",CourseImage = "angular.jpg" },
            new Course{CourseId = 3, CourseTitle = "React"  ,CourseImage = "react.jpg" },
            new Course{CourseId = 4, CourseTitle = "Vue",CourseImage = "vue.jpg"},
            new Course{CourseId = 5, CourseTitle = "Blazor",CourseImage = "blazor.jpg"}
        };
        return View("CourseList", courses);
        
    }
    public IActionResult CourseList(){
        return View();
    }
}