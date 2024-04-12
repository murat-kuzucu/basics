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
        return View();
    }
    public IActionResult CourseList(){
        return View();
    }
}